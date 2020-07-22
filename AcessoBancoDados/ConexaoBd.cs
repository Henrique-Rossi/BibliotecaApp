using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AcessoBancoDados
{
    public  class ConexaoBd
    {
       
        public SqlConnection ConexaoSql = new SqlConnection("Data Source=DESKTOP-3AP1KQU\\SQLEXPRESS;Initial Catalog=BibliotecaDb;Integrated Security=True");
        private SqlParameterCollection sqlParameterCollection = new SqlCommand().Parameters;

        //Limpar parâmetros
        public void LimparParametros()
        {
            sqlParameterCollection.Clear();
        }

        public SqlConnection AbrirConexao()
        {
            try
            {
                if (ConexaoSql.State == ConnectionState.Closed)
                    ConexaoSql.Open();
                
                return ConexaoSql;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }

        }
        
        public SqlConnection EncerrarConexao()
        {
            try
            {
                LimparParametros();
                if (ConexaoSql.State == ConnectionState.Open)
                    ConexaoSql.Close();
                return ConexaoSql;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }

        }

        public void AdicionarParametros(string nomeParametro, object valorParametro)
        {
            sqlParameterCollection.Add(new SqlParameter(nomeParametro, valorParametro));
        }
        public object ExecutarManipulacao(CommandType commandType, string nomeStoredProcedureOuTextoSql)
        {
            
            try
            {
                
                SqlConnection sqlConnection = AbrirConexao();
               
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
               
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = nomeStoredProcedureOuTextoSql;
                sqlCommand.CommandTimeout = 7200;
               
                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }

               
                return sqlCommand.ExecuteScalar();
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
        //Consultar informações do banco de dados
        public DataTable ExecutarConsulta(CommandType commandType, string nomeStoredProcedureOuTextoSql)
        {
            try
            {
               
                SqlConnection sqlConnection =AbrirConexao();
               
                //Criar comando para levar informações para o banco de dados
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                //Colocar dentro do comando o que será enviado no canal de comunicação
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = nomeStoredProcedureOuTextoSql;
                sqlCommand.CommandTimeout = 7200; //Segundos

                //Adicionar parametros para enviar ao banco de dados
                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }

                //Criar Adaptador 
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                //Data Table Tabela de dados vazia onde serão colocados os dados da consulta do banco de dados
                DataTable dataTable = new DataTable();

                //Mandar o comando ir até o banco e buscar os dados para preencher o adaptador que setara o meu data table
                sqlDataAdapter.Fill(dataTable);

                return dataTable;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
        public object Backup(string Diretorio)
        {
            try
            {
                SqlConnection sqlConnection = AbrirConexao();
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                // sqlConnection.Open();
                sqlCommand.Connection = sqlConnection;
                string sql = "";
                sql = "BACKUP DATABASE BibliotecaDb TO DISK='" + Diretorio + "\\" +
                DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString() + "-BibliotecaDb-" +
                DateTime.Now.Ticks.ToString() + ".bak'";
                sqlCommand.CommandText = sql;
                sqlCommand.ExecuteNonQuery();
                return sqlCommand.ExecuteScalar();
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
    }
}
