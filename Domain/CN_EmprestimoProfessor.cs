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
    public class CN_EmprestimoProfessor
    {
         ConexaoBd Conexao = new ConexaoBd();
         SqlDataReader leerDados;
        public DataTable MostrarEmprestimos()
        {
            // SqlDataReader leerDados;
            SqlCommand c = new SqlCommand();
            DataTable Tabela = new DataTable();
            c.Connection = Conexao.AbrirConexao();
            c.CommandText = "USP_Emprestimo";
            c.CommandType = CommandType.StoredProcedure;

            leerDados = c.ExecuteReader();
            Tabela.Load(leerDados);

            leerDados.Close();

            return Tabela;
        }
        public DataTable MostrarUsuarioPendentesDevolucao()
        {
            // SqlDataReader leerDados;
            SqlCommand c = new SqlCommand();
            DataTable Tabela = new DataTable();
            c.Connection = Conexao.AbrirConexao();
            c.CommandText = "USP_ExibirProfessorDevolucao";
            c.CommandType = CommandType.StoredProcedure;

            leerDados = c.ExecuteReader();
            Tabela.Load(leerDados);

            leerDados.Close();

            return Tabela;
        }
        
        public DataTable MostrarEmprestimoUnico (int id)
        {

            // SqlDataReader leerDados;
            SqlCommand c = new SqlCommand();
            DataTable Tabela = new DataTable();
            c.Connection = Conexao.AbrirConexao();
            c. Parameters.Add(new SqlParameter("@idProfessor",id));
            c.CommandText = "USP_ExibirListaEmprestimoUnicoProf";
            c.CommandType = CommandType.StoredProcedure;

            leerDados = c.ExecuteReader();
            Tabela.Load(leerDados);

            leerDados.Close();

            return Tabela;
        }
        
        public DataTable ExecutarRenovacao(int IdEmprestimo)
        {
            SqlCommand c = new SqlCommand();
            DataTable Tabela = new DataTable();
            c.Connection = Conexao.AbrirConexao();
            c.Parameters.Add(new SqlParameter("@IdEmprestimo", IdEmprestimo));
            c.CommandText = "USP_RenovacaoProfesssor";
            c.CommandType = CommandType.StoredProcedure;

            leerDados = c.ExecuteReader();
            Tabela.Load(leerDados);

            leerDados.Close();

            return Tabela;
        }

        public void Devolucao(EmprestimoProfessor professor)
        {

            try
            {

                Conexao.LimparParametros();


                Conexao.AdicionarParametros("@IdEmprestimo", professor.IdEmprestimo);
                Conexao.AdicionarParametros("@IdProfessor",professor.IdProfessor);
                Conexao.AdicionarParametros("@IdLivro", professor.IdLivro);


                Conexao.ExecutarManipulacao(CommandType.StoredProcedure, "USP_DevolucaoProfessor").ToString();
                                                                      
            }
            catch (SqlException erro)
            {
                throw erro;
            }
        }
        public string InserirEmprestimoprofessor(EmprestimoProfessor professor)
        {

            try 
            {
                //professor nao tem prazo de devolução,ou seja nao precisa atualziar  a data de devolução
                Conexao.LimparParametros();

             
                Conexao.AdicionarParametros("@IdEmprestimo", professor.IdEmprestimo);
                Conexao.AdicionarParametros("@IdOperacao", professor.IdOperacao);
                Conexao.AdicionarParametros("@IdSituacao", professor.IdSituacao);
                Conexao.AdicionarParametros("@IdProfessor", professor.IdProfessor); 
                Conexao.AdicionarParametros("@Id_FuncionarioCadastro", professor.Id_FuncionarioCadastro);
                Conexao.AdicionarParametros("@IdLivro", professor.IdLivro);
                Conexao.AdicionarParametros("@Dataatual", professor.DataAtual);
                Conexao.AdicionarParametros("@DataEntregou", DateTime.Now);
                Conexao.AdicionarParametros("@DataProcesso", DateTime.Now);


                 string codigo = Conexao.ExecutarManipulacao(CommandType.StoredProcedure, "USP_EmprestimoInsertProfessor").ToString();



                 return codigo;
               
            }
            catch (SqlException erro)
            {
                throw erro;
            }

        }


        public void AtualizaDataVencimento(EmprestimoProfessor professor)
        {

            try
            {

                Conexao.LimparParametros();
                Conexao.AdicionarParametros("@IdEmprestimo", professor.IdEmprestimo);
                Conexao.ExecutarManipulacao(CommandType.StoredProcedure, "USP_AtualizaCampoVencimentoProfessor").ToString();
                //erro de objeto é so colocar pra retornar  o id

            }
            catch (SqlException erro)
            {
                throw erro;
            }
        }

    }



}
