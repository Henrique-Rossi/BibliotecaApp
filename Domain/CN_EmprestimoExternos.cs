using AcessoBancoDados;
using CamadaTransferencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class CN_EmprestimoExternos
    {
        ConexaoBd Conexao = new ConexaoBd();
        SqlDataReader leerDados;
        public string InserirEmprestimoExternos(EmprestimoExternos Externos)
        {

            try
            {

                Conexao.LimparParametros();


                Conexao.AdicionarParametros("@IdEmprestimo", Externos.IdEmprestimo);
                Conexao.AdicionarParametros("@IdOperacao", Externos.IdOperacao);
                Conexao.AdicionarParametros("@IdSituacao", Externos.IdSituacao);
                Conexao.AdicionarParametros("@IdExterno", Externos.IdExterno);
                Conexao.AdicionarParametros("@Id_FuncionarioCadastro", Externos.Id_FuncionarioCadastro);
                Conexao.AdicionarParametros("@IdLivro", Externos.IdLivro);
                Conexao.AdicionarParametros("@Dataatual", Externos.DataAtual);
                Conexao.AdicionarParametros("@DataSaida", Externos.DataSaida);
                Conexao.AdicionarParametros("@DataEntregou", DateTime.Now);
                Conexao.AdicionarParametros("@DataProcesso", DateTime.Now);


                string codigo = Conexao.ExecutarManipulacao(CommandType.StoredProcedure, "USP_EmprestimoAddExternos").ToString();



                return codigo;

            }
            catch (SqlException erro)
            {
                throw erro;
            }

        }
        public DataTable MostrarEmprestimos()
        {
            // SqlDataReader leerDados;
            SqlCommand c = new SqlCommand();
            DataTable Tabela = new DataTable();
            c.Connection = Conexao.AbrirConexao();
            c.CommandText = "USP_ExibirEmprestimosExterno";
            c.CommandType = CommandType.StoredProcedure;

            leerDados = c.ExecuteReader();
            Tabela.Load(leerDados);

            leerDados.Close();

            return Tabela;
        }

        public DataTable MostrarEmprestimoUnico(int id)
        {

           // SqlDataReader leerDados;
           SqlCommand c = new SqlCommand();
           DataTable Tabela = new DataTable();
           c.Connection = Conexao.AbrirConexao();
           c.Parameters.Add(new SqlParameter("@idExterno", id));
           c.CommandText = "USP_ExibirListaEmprestimoUnicoExterno";
           c.CommandType = CommandType.StoredProcedure;

           leerDados = c.ExecuteReader();
           Tabela.Load(leerDados);

           leerDados.Close();

           return Tabela;
        }
        public DataTable ConsultarexternosDevolu()
        {
            SqlCommand c = new SqlCommand();
            DataTable Tabela = new DataTable();
            c.Connection = Conexao.AbrirConexao();
            c.CommandText = "USP_ExibirExternosDevolucao";
            c.CommandType = CommandType.StoredProcedure;

            leerDados = c.ExecuteReader();
            Tabela.Load(leerDados);

            leerDados.Close();

            return Tabela;
        }
        public DataTable MostrarEmprestimoUnicoRenovacao(int id)
        {

            // SqlDataReader leerDados;
            SqlCommand c = new SqlCommand();
            DataTable Tabela = new DataTable();
            c.Connection = Conexao.AbrirConexao();
            c.Parameters.Add(new SqlParameter("@idExterno", id));
            c.CommandText = "USP_ExibirListaEmprestimoUnicoExternoRenovacao";
            c.CommandType = CommandType.StoredProcedure;

            leerDados = c.ExecuteReader();
            Tabela.Load(leerDados);

            leerDados.Close();

            return Tabela;
        }

        /*  public DataTable ExecutarDevolucao(int IdEmprestimo, int IdLivro,int IdExterno)
          {// USP_DevolucaoProfesssor
              SqlCommand c = new SqlCommand();
              DataTable Tabela = new DataTable();
              c.Connection = Conexao.AbrirConexao();
              c.Parameters.Add(new SqlParameter("@IdEmprestimo", IdEmprestimo));
              c.Parameters.Add(new SqlParameter("@IdLivro", IdLivro));
              c.Parameters.Add(new SqlParameter("@IdExterno", IdExterno));
              c.CommandText = "USP_DevolucaoExternos";
              c.CommandType = CommandType.StoredProcedure;

              leerDados = c.ExecuteReader();
              Tabela.Load(leerDados);

              leerDados.Close();

              return Tabela;
          }*/
        public void Devolucao(EmprestimoExternos externos)
        {

            try
            {

                Conexao.LimparParametros();


                Conexao.AdicionarParametros("@IdEmprestimo",externos.IdEmprestimo);
                Conexao.AdicionarParametros("@IdExterno",externos.IdExterno);
                Conexao.AdicionarParametros("@IdLivro", externos.IdLivro);


                Conexao.ExecutarManipulacao(CommandType.StoredProcedure, "USP_DevolucaoExternos").ToString();

            }
            catch (SqlException erro)
            {
                throw erro;
            }
        }

        public DataTable ExecutarRenovacao(int IdEmprestimo)
        {
            SqlCommand c = new SqlCommand();
            DataTable Tabela = new DataTable();
            c.Connection = Conexao.AbrirConexao();
            c.Parameters.Add(new SqlParameter("@IdEmprestimo", IdEmprestimo));
            c.CommandText = "USP_RenovacaoExterno";
            c.CommandType = CommandType.StoredProcedure;

            leerDados = c.ExecuteReader();
            Tabela.Load(leerDados);

            leerDados.Close();

            return Tabela;
        }
        public void AtualizaDataVencimento(EmprestimoExternos externos)
        {

            try
            {

                Conexao.LimparParametros();
                Conexao.AdicionarParametros("@IdEmprestimo", externos.IdEmprestimo);
                Conexao.ExecutarManipulacao(CommandType.StoredProcedure, "USP_AtualizaCampoVencimentoExterno").ToString();
                //erro de objeto é so colocar pra retornar  o id

            }
            catch (SqlException erro)
            {
                throw erro;
            }
        }

    }
}
