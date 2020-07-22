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
    public class CN_Alunos
    {
        

       
        private ConexaoBd Conexao = new ConexaoBd();
        private SqlCommand c = new SqlCommand();

        private SqlDataReader leerDados;
     
     
        public DataTable ConsultarPorSituacao(string Situacao)
        {

            // SqlDataReader leerDados;
            SqlCommand c = new SqlCommand();
            DataTable Tabela = new DataTable();
            c.Connection = Conexao.AbrirConexao();
            c.Parameters.Add(new SqlParameter("@Situacao", Situacao));
            c.CommandText = "Usp_ConsultaAluno";
            c.CommandType = CommandType.StoredProcedure;

            leerDados = c.ExecuteReader();
            Tabela.Load(leerDados);

            leerDados.Close();

            return Tabela;
        }
        public DataTable ConsultarPorDependencia(string Disponibilidade)
        {

            // SqlDataReader leerDados;
            SqlCommand c = new SqlCommand();
            DataTable Tabela = new DataTable();
            c.Connection = Conexao.AbrirConexao();
            c.Parameters.Add(new SqlParameter("@Opcao", 4));
            c.Parameters.Add(new SqlParameter("@Disponibilidade", Disponibilidade));
            c.CommandText = "USP_ConsultaAutomaticaAluno";
            c.CommandType = CommandType.StoredProcedure;

            leerDados = c.ExecuteReader();
            Tabela.Load(leerDados);

            leerDados.Close();

            return Tabela;
        }
    
      /*  public DataTable  ConsultarPorId(Aluno aluno)
        {
            DataTable Tabela = new DataTable();
            c.Connection = Conexao.AbrirConexao();
            c.Parameters.Add(new SqlParameter("@Id",aluno.IdAluno));
            c.CommandText = "Usp_ConsultaAlunoPorId";
            c.CommandType = CommandType.StoredProcedure;

            leerDados = c.ExecuteReader();
            Tabela.Load(leerDados);

            leerDados.Close();
            

            return Tabela;
        }*/

        public Aluno ConsultarPorId(string id)
        {
            Aluno aluno = new Aluno();
            //Aluno alunoColecao = new Aluno();
            Conexao.LimparParametros();
            Conexao.AdicionarParametros("@Id", id);
            DataTable dataTablealuno = Conexao.ExecutarConsulta(CommandType.StoredProcedure, "Usp_ConsultaAlunoPorId");
    
            foreach (DataRow alunoLinha in dataTablealuno.Rows)
            {
                
                //Funcionarios funcionarios = new Funcionarios();


                aluno.IdAluno = Convert.ToInt32(alunoLinha["Id_Aluno"]);
                aluno.Nome = Convert.ToString(alunoLinha["Nome"]);
                aluno.Sexo = Convert.ToBoolean(alunoLinha["Sexo"]);
                aluno.Cpf = Convert.ToString(alunoLinha["Cpf"]);
                aluno.Cidade = Convert.ToString(alunoLinha["Cidade"]);
                aluno.Estado = Convert.ToString(alunoLinha["Estado"]);
                aluno.Endereco = Convert.ToString(alunoLinha["Endereco"]);
                aluno.Numeroend = Convert.ToInt32(alunoLinha["Numero"]);
                aluno.Bairro = Convert.ToString(alunoLinha["Bairro"]);
                aluno.Matricula = Convert.ToString(alunoLinha["Matricula"]);
                aluno.DataNascimento = Convert.ToDateTime(alunoLinha["DataNascimento"]);
                aluno.Telefone = Convert.ToString(alunoLinha["Telefone"]);
                aluno.Email = Convert.ToString(alunoLinha["Email"]);
                aluno.DataAlteracao = Convert.ToDateTime(alunoLinha["DataAlteracao"]);
                aluno.DataCadastro = Convert.ToDateTime(alunoLinha["DataCadastro"]);
                aluno.Cep = Convert.ToString(alunoLinha["Cep"]);
                aluno.Disponibilidade = Convert.ToBoolean(alunoLinha["Disponibilidade"]);
                aluno.Situacao = Convert.ToBoolean(alunoLinha["Situacao"]);
                aluno.Grau = Convert.ToString(alunoLinha["Grau"]);
                aluno.TelefoneResponsavel= Convert.ToString(alunoLinha["TelefoneRespo"]);
                aluno.Turma= Convert.ToString(alunoLinha["Turma"]);
                aluno.Turno= Convert.ToString(alunoLinha["Turno"]);
                aluno.Id_FuncionarioCadastro = Convert.ToInt32(alunoLinha["Id_FuncionarioCadastro"]);
                aluno.Complemento = Convert.ToString(alunoLinha["Complemento"]);
                aluno.Cep = Convert.ToString(alunoLinha["Cep"]);
                aluno.Descricao = Convert.ToString(alunoLinha["Descricao"]);

               // funcionarios.IdFuncionario = Convert.ToInt32(alunoLinha["Id_Funcionario"].ToString());
               // funcionarios.Nome = alunoLinha["Nomef"].ToString();
              //  aluno.Funcionarios = funcionarios;

             //   alunoColecao.Add(aluno);

            }
            return aluno;
        }

    
        //pesqusiar instantaneamente 

        //NOME
        public DataTable AtualizaDataInsta(Aluno aluno)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable Tabela = new DataTable();


            c.Connection = Conexao.AbrirConexao();
            c.Parameters.Add(new SqlParameter("@Opcao", 1));
            c.Parameters.Add(new SqlParameter("@Nome", aluno.Nome));
            c.CommandText = "USP_ConsultaAutomaticaAluno";
            c.CommandType = CommandType.StoredProcedure; 
            da.SelectCommand = c;
            da.Fill(Tabela);

           // leerDados = c.ExecuteReader();
           // Tabela.Load(leerDados);

            //leerDados.Close();
            //Conexao.EncerrarConexao();

            return Tabela;
        }
        //NOME-ATIVO
        public DataTable AtualizaDadosNomeAtivoInsta(Aluno aluno, int Situacao )
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable Tabela = new DataTable();


            c.Connection = Conexao.AbrirConexao();
            c.Parameters.Add(new SqlParameter("@Opcao",2));
            c.Parameters.Add(new SqlParameter("@Nome", aluno.Nome));
            c.Parameters.Add(new SqlParameter("@Situacao", Situacao));
            c.CommandText = "USP_ConsultaAutomaticaAluno";
            c.CommandType = CommandType.StoredProcedure;
            da.SelectCommand = c;
            da.Fill(Tabela);

            // leerDados = c.ExecuteReader();
            // Tabela.Load(leerDados);

            //leerDados.Close();
            //Conexao.EncerrarConexao();

            return Tabela;
        }

        public DataTable AtualizaDadosNomePendenteInsta(Aluno aluno, int Disponibilidade)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable Tabela = new DataTable();


            c.Connection = Conexao.AbrirConexao();
            c.Parameters.Add(new SqlParameter("@Opcao", 3));
            c.Parameters.Add(new SqlParameter("@Nome", aluno.Nome));
            c.Parameters.Add(new SqlParameter("@Disponibilidade", Disponibilidade));
            c.CommandText = "USP_ConsultaAutomaticaAluno";
            c.CommandType = CommandType.StoredProcedure;
            da.SelectCommand = c;
            da.Fill(Tabela);

            // leerDados = c.ExecuteReader();
            // Tabela.Load(leerDados);

            //leerDados.Close();
            //Conexao.EncerrarConexao();

            return Tabela;
        }
        public DataTable AtualizaDadosporMatricula(Aluno aluno)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable Tabela = new DataTable();


            c.Connection = Conexao.AbrirConexao();
            c.Parameters.Add(new SqlParameter("@Opcao", 5));
            c.Parameters.Add(new SqlParameter("@Matricula", aluno.Matricula));
            c.CommandText = "USP_ConsultaAutomaticaAluno";
            c.CommandType = CommandType.StoredProcedure;
            da.SelectCommand = c;
            da.Fill(Tabela);

            // leerDados = c.ExecuteReader();
            // Tabela.Load(leerDados);

            //leerDados.Close();
            //Conexao.EncerrarConexao();

            return Tabela;
        }
        public DataTable AtualizaDadosMatriculaAtivoInsta(Aluno aluno, int Situacao)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable Tabela = new DataTable();


            c.Connection = Conexao.AbrirConexao();
            c.Parameters.Add(new SqlParameter("@Opcao", 6));
            c.Parameters.Add(new SqlParameter("@Matricula", aluno.Matricula));
            c.Parameters.Add(new SqlParameter("@Situacao", Situacao));
            c.CommandText = "USP_ConsultaAutomaticaAluno";
            c.CommandType = CommandType.StoredProcedure;
            da.SelectCommand = c;
            da.Fill(Tabela);

            // leerDados = c.ExecuteReader();
            // Tabela.Load(leerDados);

            //leerDados.Close();
            //Conexao.EncerrarConexao();

            return Tabela;
        }

        public DataTable AtualizaDadosMatriculaPendenteInsta(Aluno aluno, int Disponibilidade)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable Tabela = new DataTable();


            c.Connection = Conexao.AbrirConexao();
            c.Parameters.Add(new SqlParameter("@Opcao", 7));
            c.Parameters.Add(new SqlParameter("@Matricula", aluno.Matricula));
            c.Parameters.Add(new SqlParameter("@Disponibilidade", Disponibilidade));
            c.CommandText = "USP_ConsultaAutomaticaAluno";
            c.CommandType = CommandType.StoredProcedure;
            da.SelectCommand = c;
            da.Fill(Tabela);

            // leerDados = c.ExecuteReader();
            // Tabela.Load(leerDados);

            //leerDados.Close();
            //Conexao.EncerrarConexao();

            return Tabela;
        }


        public DataTable MostraTurnos(Aluno aluno)
        {
            DataTable Tabela = new DataTable();
            c.Connection = Conexao.AbrirConexao();
            c.Parameters.Add(new SqlParameter("@Opcao", 8));
            c.Parameters.Add(new SqlParameter("@Turno", aluno.Turno));
            c.CommandText = "USP_ConsultaAutomaticaAluno";
            c.CommandType = CommandType.StoredProcedure;

            leerDados = c.ExecuteReader();
            Tabela.Load(leerDados);

            leerDados.Close();
            //Conexao.EncerrarConexao();

            return Tabela;
        }
        public DataTable MostraTurma(Aluno aluno)
        {
            DataTable Tabela = new DataTable();
            c.Connection = Conexao.AbrirConexao();
            c.Parameters.Add(new SqlParameter("@Opcao", 9));
            c.Parameters.Add(new SqlParameter("@Turma", aluno.Turma));
            c.CommandText = "USP_ConsultaAutomaticaAluno";
            c.CommandType = CommandType.StoredProcedure;

            leerDados = c.ExecuteReader();
            Tabela.Load(leerDados);

            leerDados.Close();
            //Conexao.EncerrarConexao();

            return Tabela;
        }
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //                                                                      AREA DE CONSULTA
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        public DataTable MostraAlunos()
        {
            DataTable Tabela = new DataTable();
            c.Connection = Conexao.AbrirConexao();
            c.CommandText = "MostrarAlunos";
            c.CommandType = CommandType.StoredProcedure;

            leerDados = c.ExecuteReader();
            Tabela.Load(leerDados);

            leerDados.Close();
            Conexao.EncerrarConexao();

            return Tabela;
        }

       

        public DataTable Consultar(string _consultar)
        {
            DataTable Tabela = new DataTable();
            c.Connection = Conexao.AbrirConexao();
            c.CommandText = "select * from tblAluno where nome LIKE '%" + _consultar + "%'"; 
            //c.CommandType = CommandType.StoredProcedure;

            leerDados = c.ExecuteReader();
            Tabela.Load(leerDados);

            leerDados.Close();
            //Conexao.EncerrarConexao();

            return Tabela;
        }


        //cadastro USP_Aluno
        public string CadastrarAluno(Aluno aluno)
        {
            try
            {

                Conexao.LimparParametros();

                Conexao.AdicionarParametros("@Opcao", 1);
                Conexao.AdicionarParametros("@Id_Aluno", aluno.IdAluno);
                Conexao.AdicionarParametros("@Nome", aluno.Nome);
                Conexao.AdicionarParametros("@Sexo", aluno.Sexo);
                Conexao.AdicionarParametros("@Matricula", aluno.Matricula);
                Conexao.AdicionarParametros("@Turma", aluno.Turma);
                Conexao.AdicionarParametros("@turno", aluno.Turno);
                Conexao.AdicionarParametros("@Grau", aluno.Grau);
                Conexao.AdicionarParametros("@Cpf", aluno.Cpf);
                Conexao.AdicionarParametros("@Descricao", aluno.Descricao);
                Conexao.AdicionarParametros("@Cidade", aluno.Cidade);
                Conexao.AdicionarParametros("@Estado", aluno.Estado);
                Conexao.AdicionarParametros("@Endereco", aluno.Endereco);
                Conexao.AdicionarParametros("@Numero", aluno.Numeroend);
                Conexao.AdicionarParametros("@Bairro", aluno.Bairro);
                Conexao.AdicionarParametros("@Complemento", aluno.Complemento);
                Conexao.AdicionarParametros("@DataNascimento", aluno.DataNascimento);
                Conexao.AdicionarParametros("@Telefone", aluno.Telefone);
                Conexao.AdicionarParametros("@Email", aluno.Email);                        
                Conexao.AdicionarParametros("@DataAlteracao", DateTime.Now);
                Conexao.AdicionarParametros("@DataCadastro", DateTime.Now);
                Conexao.AdicionarParametros("@Cep", aluno.Cep);
                Conexao.AdicionarParametros("@Disponibilidade", aluno.Disponibilidade);
                Conexao.AdicionarParametros("@Id_FuncionarioCadastro", aluno.Id_FuncionarioCadastro);              
                Conexao.AdicionarParametros("@Situacao", aluno.Situacao);
                Conexao.AdicionarParametros("@TelefoneRespo", aluno.TelefoneResponsavel);

                string codigo = Conexao.ExecutarManipulacao(CommandType.StoredProcedure, "USP_Aluno").ToString();
                return codigo;


            }
            catch (SqlException erro)
            {
                throw erro;
            }
        }

        public string Alterar(Aluno aluno)
        {
            Conexao.LimparParametros();

            Conexao.AdicionarParametros("@Opcao", 2);
            Conexao.AdicionarParametros("@Id_Aluno", aluno.IdAluno);
            Conexao.AdicionarParametros("@Nome", aluno.Nome);
            Conexao.AdicionarParametros("@Sexo", aluno.Sexo);
            Conexao.AdicionarParametros("@Matricula", aluno.Matricula);
            Conexao.AdicionarParametros("@Turma", aluno.Turma);
            Conexao.AdicionarParametros("@turno", aluno.Turno);
            Conexao.AdicionarParametros("@Grau", aluno.Grau);
            Conexao.AdicionarParametros("@Cpf", aluno.Cpf);
            Conexao.AdicionarParametros("@Descricao", aluno.Descricao);
            Conexao.AdicionarParametros("@Cidade", aluno.Cidade);
            Conexao.AdicionarParametros("@Estado", aluno.Estado);
            Conexao.AdicionarParametros("@Endereco", aluno.Endereco);
            Conexao.AdicionarParametros("@Numero", aluno.Numeroend);
            Conexao.AdicionarParametros("@Bairro", aluno.Bairro);
            Conexao.AdicionarParametros("@Complemento", aluno.Complemento);
            Conexao.AdicionarParametros("@DataNascimento", aluno.DataNascimento);
            Conexao.AdicionarParametros("@Telefone", aluno.Telefone);
            Conexao.AdicionarParametros("@Email", aluno.Email);
            Conexao.AdicionarParametros("@DataAlteracao", DateTime.Now);
            Conexao.AdicionarParametros("@DataCadastro", DateTime.Now);
            Conexao.AdicionarParametros("@Cep", aluno.Cep);
            Conexao.AdicionarParametros("@Disponibilidade", aluno.Disponibilidade);
            Conexao.AdicionarParametros("@Id_FuncionarioCadastro", aluno.Id_FuncionarioCadastro);
            Conexao.AdicionarParametros("@Situacao", aluno.Situacao);
            Conexao.AdicionarParametros("@TelefoneRespo", aluno.TelefoneResponsavel);

            string codigo = Conexao.ExecutarManipulacao(CommandType.StoredProcedure, "USP_Aluno").ToString();
            return codigo;
        }

        public string ExcluirAluno(Aluno aluno)
        {
            try
            {

                Conexao.LimparParametros();

                Conexao.AdicionarParametros("@Opcao", 3);
                Conexao.AdicionarParametros("@Id_Aluno", aluno.IdAluno);
                Conexao.AdicionarParametros("@Nome", aluno.Nome);
                Conexao.AdicionarParametros("@Sexo", aluno.Sexo);
                Conexao.AdicionarParametros("@Matricula", aluno.Matricula);
                Conexao.AdicionarParametros("@Turma", aluno.Turma);
                Conexao.AdicionarParametros("@turno", aluno.Turno);
                Conexao.AdicionarParametros("@Grau", aluno.Grau);
                Conexao.AdicionarParametros("@Cpf", aluno.Cpf);
                Conexao.AdicionarParametros("@Descricao", aluno.Descricao);
                Conexao.AdicionarParametros("@Cidade", aluno.Cidade);
                Conexao.AdicionarParametros("@Estado", aluno.Estado);
                Conexao.AdicionarParametros("@Endereco", aluno.Endereco);
                Conexao.AdicionarParametros("@Numero", aluno.Numeroend);
                Conexao.AdicionarParametros("@Bairro", aluno.Bairro);
                Conexao.AdicionarParametros("@Complemento", aluno.Complemento);
                Conexao.AdicionarParametros("@DataNascimento", aluno.DataNascimento);
                Conexao.AdicionarParametros("@Telefone", aluno.Telefone);
                Conexao.AdicionarParametros("@Email", aluno.Email);
                Conexao.AdicionarParametros("@DataAlteracao", DateTime.Now);
                Conexao.AdicionarParametros("@DataCadastro", DateTime.Now);
                Conexao.AdicionarParametros("@Cep", aluno.Cep);
                Conexao.AdicionarParametros("@Disponibilidade", aluno.Disponibilidade);
                Conexao.AdicionarParametros("@Id_FuncionarioCadastro", aluno.Id_FuncionarioCadastro);
                Conexao.AdicionarParametros("@Situacao", aluno.Situacao);
                Conexao.AdicionarParametros("@TelefoneRespo", aluno.TelefoneResponsavel);

                string codigo = Conexao.ExecutarManipulacao(CommandType.StoredProcedure, "USP_Aluno").ToString();
                return codigo;


            }
            catch (SqlException erro)
            {
                throw erro;
            }
        }

      

    }
}
