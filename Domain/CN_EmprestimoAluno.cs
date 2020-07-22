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
    public  class CN_EmprestimoAluno
    {
        ConexaoBd Conexao = new ConexaoBd();
        SqlDataReader leerDados;
    /*    public DataTable MostrarEmprestimos()
        {
            // SqlDataReader leerDados;
            SqlCommand c = new SqlCommand();
            DataTable Tabela = new DataTable();
            c.Connection = Conexao.AbrirConexao();
            c.CommandText = "USP_ExibirEmprestimosAluno";
            c.CommandType = CommandType.StoredProcedure;

            leerDados = c.ExecuteReader();
            Tabela.Load(leerDados);

            leerDados.Close();

            return Tabela;
        }*/
        public DataTable ConsultaralunosDevolu()
        {
            SqlCommand c = new SqlCommand();
            DataTable Tabela = new DataTable();
            c.Connection = Conexao.AbrirConexao();
            c.CommandText = "USP_ExibirAlunosDevolucao";
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
            c.Parameters.Add(new SqlParameter("@idAluno", id));
            c.CommandText = "USP_ExibirListaEmprestimoUnicoAluno";
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
            c.Parameters.Add(new SqlParameter("@idAluno", id));
            c.CommandText = "USP_ExibirListaEmprestimoUnicoAlunoRenovacao";
            c.CommandType = CommandType.StoredProcedure;

            leerDados = c.ExecuteReader();
            Tabela.Load(leerDados);

            leerDados.Close();

            return Tabela;
        }
        public string InserirEmprestimoAluno(EmprestimoAluno aluno)
        {

            try
            {

                Conexao.LimparParametros();


                Conexao.AdicionarParametros("@IdEmprestimo", aluno.IdEmprestimo);
                Conexao.AdicionarParametros("@IdOperacao", aluno.IdOperacao);
                Conexao.AdicionarParametros("@IdSituacao", aluno.IdSituacao);
                Conexao.AdicionarParametros("@Idaluno", aluno.Id_Aluno);
                Conexao.AdicionarParametros("@Id_FuncionarioCadastro", aluno.Id_FuncionarioCadastro);
                Conexao.AdicionarParametros("@IdLivro", aluno.IdLivro);
                Conexao.AdicionarParametros("@Dataatual", aluno.DataAtual);
                Conexao.AdicionarParametros("@DataSaida", aluno.DataSaida);
                Conexao.AdicionarParametros("@DataEntregou", DateTime.Now);
                Conexao.AdicionarParametros("@DataProcesso", DateTime.Now);


                string codigo = Conexao.ExecutarManipulacao(CommandType.StoredProcedure, "USP_EmprestimoAddAluno").ToString();



                return codigo;

            }
            catch (SqlException erro)
            {
                throw erro;
            }
        }
       /* public DataTable ExecutarDevolucao(int IdEmprestimo, int IdLivro,int idAluno)
        {// USP_DevolucaoProfesssor
            Conexao.LimparParametros();
            SqlCommand c = new SqlCommand();
            DataTable Tabela = new DataTable();
            c.Connection = Conexao.AbrirConexao();
            c.Parameters.Add(new SqlParameter("@IdEmprestimo", IdEmprestimo));
            c.Parameters.Add(new SqlParameter("@IdLivro", IdLivro));
            c.Parameters.Add(new SqlParameter("@IdAluno", idAluno));
            c.CommandText = "USP_DevolucaoAluno";
            c.CommandType = CommandType.StoredProcedure;

            leerDados = c.ExecuteReader();
            Tabela.Load(leerDados);

            leerDados.Close();

            return Tabela;
        }*/
        
        public DataTable ExecutarRenovacao(int IdEmprestimo)
        {
            SqlCommand c = new SqlCommand();
            DataTable Tabela = new DataTable();
            c.Connection = Conexao.AbrirConexao();
            c.Parameters.Add(new SqlParameter("@IdEmprestimo", IdEmprestimo));
            c.CommandText = "USP_RenovacaoAluno";
            c.CommandType = CommandType.StoredProcedure;

            leerDados = c.ExecuteReader();
            Tabela.Load(leerDados);

            leerDados.Close();

            return Tabela;
        }
       /* public DataTable ExecutarAtt(int IdEmprestimo)
        {
            SqlCommand c = new SqlCommand();
            DataTable Tabela = new DataTable();
            c.Connection = Conexao.AbrirConexao();
            c.Parameters.Add(new SqlParameter("@IdEmprestimo", IdEmprestimo));
            c.CommandText = "USP_AtualizaCampoVencimento";
            c.CommandType = CommandType.StoredProcedure;

            leerDados = c.ExecuteReader();
            Tabela.Load(leerDados);

            leerDados.Close();

            return Tabela;
        }*/

        public void AtualizaDataVencimento(EmprestimoAluno aluno)
        {

            try
            {

                Conexao.LimparParametros();
                Conexao.AdicionarParametros("@IdEmprestimo", aluno.IdEmprestimo);              
                Conexao.ExecutarManipulacao(CommandType.StoredProcedure, "USP_AtualizaCampoVencimento").ToString();        
                //erro de objeto é so colocar pra retornar  o id
               
            }
            catch (SqlException erro)
            {
                throw erro;
            }
        }

        public void Devolucao(EmprestimoAluno aluno)
        {

            try
            {

                Conexao.LimparParametros();


                Conexao.AdicionarParametros("@IdEmprestimo", aluno.IdEmprestimo);              
                Conexao.AdicionarParametros("@Idaluno", aluno.Id_Aluno);
                Conexao.AdicionarParametros("@IdLivro", aluno.IdLivro);
                

                Conexao.ExecutarManipulacao(CommandType.StoredProcedure, "USP_DevolucaoAluno").ToString();

            }
            catch (SqlException erro)
            {
                throw erro;
            }
        }

     

        public EmprestimoAlunoColecao Consulta()
        {
            EmprestimoAlunoColecao Colecao = new EmprestimoAlunoColecao();
            Conexao.LimparParametros();

            DataTable dataTablealuno = Conexao.ExecutarConsulta(CommandType.StoredProcedure, "MostrarEmprestimosAlunos");
            foreach (DataRow alunoLinha in dataTablealuno.Rows)
            {
                Aluno aluno = new Aluno();
                EmprestimoAluno emprestimo = new EmprestimoAluno();
                Funcionarios funcionarios = new Funcionarios();
                //Livro livro = new Livro();

                aluno.IdAluno = Convert.ToInt32(alunoLinha["Id_Aluno"]);
                aluno.Nome = Convert.ToString(alunoLinha["Nome"]);
            /*  aluno.Cpf = Convert.ToString(alunoLinha["Cpf"]);
                aluno.Matricula = Convert.ToString(alunoLinha["Matricula"]);
                aluno.Telefone = Convert.ToString(alunoLinha["Telefone"]);
                aluno.Email = Convert.ToString(alunoLinha["Email"]);
                aluno.Id_FuncionarioCadastro = Convert.ToInt32(alunoLinha["Id_FuncionarioCadastro"]);
                */

              
                funcionarios.Nome = alunoLinha["Nomef"].ToString();
                aluno.Funcionarios = funcionarios;

               
                emprestimo.IdEmprestimo = Convert.ToInt32(alunoLinha["IdEmprestimo"].ToString());
                
               // livro.Codigo_Livro= Convert.ToInt32(alunoLinha["Codigo_Livro"].ToString());
               // livro.Nome_Livro = alunoLinha["Nome_Livro"].ToString();
                emprestimo.IdSituacao = Convert.ToInt32(alunoLinha["IdSituacao"].ToString());
                emprestimo.DataAtual = Convert.ToDateTime(alunoLinha["DataAtual"].ToString());
                emprestimo.DataEntregou = Convert.ToDateTime(alunoLinha["DataProcesso"].ToString());
                emprestimo.DataProcesso = Convert.ToDateTime(alunoLinha["DataEntregou"].ToString());
                emprestimo.DataSaida = Convert.ToDateTime(alunoLinha["DataSaida"].ToString());





                //emprestimo.Livro = livro;
                emprestimo.Aluno = aluno;
                
                Colecao.Add(emprestimo);

            }
            return Colecao;
        }


        public DataTable MostrarEmprestimosOrdem( int opcao)
        {
            // SqlDataReader leerDados;
            SqlCommand c = new SqlCommand();
            DataTable Tabela = new DataTable();
            c.Connection = Conexao.AbrirConexao();
            c.Parameters.Add(new SqlParameter("@Opcao", opcao));
            c.CommandText = "USP_OrderAlunoEmprestimo";
            c.CommandType = CommandType.StoredProcedure;

            leerDados = c.ExecuteReader();
            Tabela.Load(leerDados);

            leerDados.Close();

            return Tabela;
        }
        public DataTable MostrarEmprestimosOrdemNome(int Opcao, String Nome)
        {
            // SqlDataReader leerDados;
            SqlCommand c = new SqlCommand();
            DataTable Tabela = new DataTable();
            c.Connection = Conexao.AbrirConexao();
            c.Parameters.Add(new SqlParameter("@Opcao", Opcao));
            c.Parameters.Add(new SqlParameter("@Nome", Nome));
            c.CommandText = "USP_OrderAlunoEmprestimo";
            c.CommandType = CommandType.StoredProcedure;

            leerDados = c.ExecuteReader();
            Tabela.Load(leerDados);

            leerDados.Close();

            return Tabela;
        }
    }
}
