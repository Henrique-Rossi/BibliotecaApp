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
    public class CN_Professor
    {


        private ConexaoBd Conexao = new ConexaoBd();
        private SqlDataReader leerDados;
        public string Inserirprofessor(Professor professor)
        {

            try
            {

                Conexao.LimparParametros();

                Conexao.AdicionarParametros("@Opcao", 1);
                Conexao.AdicionarParametros("@idprofessor", professor.Idprofessor);
                Conexao.AdicionarParametros("@Nome", professor.Nome);
                Conexao.AdicionarParametros("@Endereco", professor.Endereco);
                Conexao.AdicionarParametros("@NumeroEndereco", professor.NumeroEndereco);
                Conexao.AdicionarParametros("@Bairro", professor.Bairro);
                Conexao.AdicionarParametros("@Cidade", professor.Cidade);
                Conexao.AdicionarParametros("@Cep", professor.Cep);
                Conexao.AdicionarParametros("@Estado", professor.Estado);
                Conexao.AdicionarParametros("@Telefone", professor.Telefone);
                Conexao.AdicionarParametros("@Codigoprofessor", professor.Codigoprofessor);
                Conexao.AdicionarParametros("@Disponibilidade", professor.Disponibilidade);
                Conexao.AdicionarParametros("@Id_FuncionarioCadastro", professor.Id_FuncionarioCada);
                Conexao.AdicionarParametros("@Sexo", professor.Sexo);
                Conexao.AdicionarParametros("@Situacao", professor.Situacao);
                Conexao.AdicionarParametros("@Cpf", professor.Cpf);
                Conexao.AdicionarParametros("@DataNascimento", professor.DataNascimento);
                Conexao.AdicionarParametros("@DataCadastro", DateTime.Now);
                Conexao.AdicionarParametros("@DataAlteracao", DateTime.Now);
                string codigo = Conexao.ExecutarManipulacao(CommandType.StoredProcedure, "USP_professor").ToString();
                return codigo;


            }
            catch (SqlException erro)
            {
                throw erro;
            }

        }

        public string Alterarprofessor(Professor professor)
        {
            try
            {

                Conexao.LimparParametros();

                Conexao.AdicionarParametros("@Opcao", 2);
                Conexao.AdicionarParametros("@idprofessor", Convert.ToInt32(professor.Idprofessor));
                Conexao.AdicionarParametros("@Nome", professor.Nome);
                Conexao.AdicionarParametros("@Endereco", professor.Endereco);
                Conexao.AdicionarParametros("@NumeroEndereco", professor.NumeroEndereco);
                Conexao.AdicionarParametros("@Bairro", professor.Bairro);
                Conexao.AdicionarParametros("@Cidade", professor.Cidade);
                Conexao.AdicionarParametros("@Cep", professor.Cep);
                Conexao.AdicionarParametros("@Estado", professor.Estado);
                Conexao.AdicionarParametros("@Telefone", professor.Telefone);
                Conexao.AdicionarParametros("@Codigoprofessor", professor.Codigoprofessor);
                Conexao.AdicionarParametros("@Disponibilidade", professor.Disponibilidade);
                Conexao.AdicionarParametros("@Id_FuncionarioCadastro", professor.Id_FuncionarioCada);
                Conexao.AdicionarParametros("@Sexo", professor.Sexo);
                Conexao.AdicionarParametros("@Situacao", professor.Situacao);
                Conexao.AdicionarParametros("@Cpf", professor.Cpf);
                Conexao.AdicionarParametros("@DataNascimento", professor.DataNascimento);
                Conexao.AdicionarParametros("@DataCadastro", DateTime.Now);
                Conexao.AdicionarParametros("@DataAlteracao", DateTime.Now);
                string codigo = Conexao.ExecutarManipulacao(CommandType.StoredProcedure, "USP_professor").ToString();
                return codigo;


            }
            catch (SqlException erro)
            {
                throw erro;
            }
        }

        public string Excluir(Professor professor)
        {
            try
            {
                Conexao.LimparParametros();
                Conexao.AdicionarParametros("@Opcao", 3);
                Conexao.AdicionarParametros("@idprofessor", professor.Idprofessor);
                Conexao.AdicionarParametros("@Nome", professor.Nome);
                Conexao.AdicionarParametros("@Endereco", professor.Endereco);
                Conexao.AdicionarParametros("@NumeroEndereco", professor.NumeroEndereco);
                Conexao.AdicionarParametros("@Bairro", professor.Bairro);
                Conexao.AdicionarParametros("@Cidade", professor.Cidade);
                Conexao.AdicionarParametros("@Cep", professor.Cep);
                Conexao.AdicionarParametros("@Estado", professor.Estado);
                Conexao.AdicionarParametros("@Telefone", professor.Telefone);
                Conexao.AdicionarParametros("@Codigoprofessor", professor.Codigoprofessor);
                Conexao.AdicionarParametros("@Disponibilidade", professor.Disponibilidade);
                Conexao.AdicionarParametros("@Id_FuncionarioCadastro", professor.Id_FuncionarioCada);
                Conexao.AdicionarParametros("@Sexo", professor.Sexo);
                Conexao.AdicionarParametros("@Situacao", professor.Situacao);
                Conexao.AdicionarParametros("@Cpf", professor.Cpf);
                Conexao.AdicionarParametros("@DataNascimento", professor.DataNascimento);
                Conexao.AdicionarParametros("@DataCadastro", DateTime.Now);
                Conexao.AdicionarParametros("@DataAlteracao", DateTime.Now);
                string codigo = Conexao.ExecutarManipulacao(CommandType.StoredProcedure, "USP_professor").ToString();
                return codigo;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }




        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //                                                                                         CONSULTAS
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        public ProfessorColecao ConsultaProfessor()
        {
            ProfessorColecao professorColecao = new ProfessorColecao();
            Conexao.LimparParametros();

            DataTable dataTableProfessor = Conexao.ExecutarConsulta(CommandType.StoredProcedure, "MostrarProfessores");
            foreach (DataRow ProfessorLinha in dataTableProfessor.Rows)
            {
                Professor professor = new Professor();
                Funcionarios funcionarios = new Funcionarios();
               

                professor.Idprofessor = Convert.ToInt32(ProfessorLinha["Idprofessor"]);
                professor.Nome = Convert.ToString(ProfessorLinha["Nome"]);
                professor.Sexo = Convert.ToBoolean(ProfessorLinha["Sexo"]);
                professor.Cpf = Convert.ToString(ProfessorLinha["Cpf"]);
                professor.Cidade = Convert.ToString(ProfessorLinha["Cidade"]);
                professor.Estado = Convert.ToString(ProfessorLinha["Estado"]);
                professor.Endereco = Convert.ToString(ProfessorLinha["Endereco"]);
                professor.NumeroEndereco = Convert.ToString(ProfessorLinha["NumeroEndereco"]);
                professor.Bairro = Convert.ToString(ProfessorLinha["Bairro"]);
                professor.Codigoprofessor = Convert.ToString(ProfessorLinha["CodigoProfessor"]);
                professor.DataNascimento = Convert.ToDateTime(ProfessorLinha["DataNascimento"]);
                professor.Telefone = Convert.ToString(ProfessorLinha["Telefone"]);
               // professor.Email = Convert.ToString(ProfessorLinha["Email"]);
                professor.DataAlteracao = Convert.ToDateTime(ProfessorLinha["DataAlteracao"]);
                professor.DataCadastro = Convert.ToDateTime(ProfessorLinha["DataCadastro"]);
                professor.Cep = Convert.ToString(ProfessorLinha["Cep"]);
                professor.Disponibilidade = Convert.ToBoolean(ProfessorLinha["Disponibilidade"]);
                professor.Situacao = Convert.ToBoolean(ProfessorLinha["Situacao"]);
                
                professor.Id_FuncionarioCada = Convert.ToInt32(ProfessorLinha["Id_FuncionarioCadastro"]);
              

                funcionarios.IdFuncionario = Convert.ToInt32(ProfessorLinha["Id_Funcionario"].ToString());
                funcionarios.Nome = ProfessorLinha["Nomef"].ToString();
                professor.Funcionarios = funcionarios;

                professorColecao.Add(professor);

            }
            return professorColecao;
        }
      
     
        public ProfessorColecao ConsultarPorId(string Idprofessor)
        {
            try
            {

                ProfessorColecao professorColecao = new ProfessorColecao();
                Conexao.LimparParametros();
                //Conexao.AdicionarParametros("@Opcao", 1);
                Conexao.AdicionarParametros("@idprofessor", Idprofessor);
                DataTable dataTableprofessor = Conexao.ExecutarConsulta(CommandType.Text, "SELECT * FROM tblprofessor WHERE idprofessor=@idprofessor");

                foreach (DataRow professorLinha in dataTableprofessor.Rows)
                {
                    Professor professor = new Professor();

                    professor.Idprofessor = Convert.ToInt32(professorLinha["idprofessor"]);
                    professor.Nome = professorLinha["Nome"].ToString();
                    professor.Endereco = professorLinha["Endereco"].ToString();
                    professor.NumeroEndereco = professorLinha["NumeroEndereco"].ToString();
                    professor.Bairro = professorLinha["Bairro"].ToString();
                    professor.Cidade = professorLinha["Cidade"].ToString();
                    professor.Cep = professorLinha["Cep"].ToString();
                    professor.Estado = professorLinha["Estado"].ToString();
                    professor.Telefone = professorLinha["Telefone"].ToString();
                    professor.Codigoprofessor = professorLinha["Codigoprofessor"].ToString();
                    professor.Disponibilidade = Convert.ToBoolean(professorLinha["Disponibilidade"]);
                    professor.Id_FuncionarioCada = Convert.ToInt32(professorLinha["Id_FuncionarioCadastro"].ToString());
                    professor.Sexo = Convert.ToBoolean(professorLinha["Sexo"].ToString());
                    professor.Situacao = Convert.ToBoolean(professorLinha["Situacao"].ToString());
                    professor.Cpf = professorLinha["Cpf"].ToString();
                    professor.DataNascimento = Convert.ToDateTime(professorLinha["DataNascimento"]);
                    professor.DataCadastro = Convert.ToDateTime(professorLinha["DataCadastro"]);
                    professor.DataAlteracao = Convert.ToDateTime(professorLinha["DataAlteracao"]);

                    professorColecao.Add(professor);
                }
                    return professorColecao;
            }
            catch (Exception exception)
            {

                throw new Exception("Não foi possível localizar o cliente por código. Detalhes: " + exception.Message);
            }
        }
        
        public ProfessorColecao ConsultarPorNome(string Nome)
        {
            try
            {

                ProfessorColecao professorColecao = new ProfessorColecao();
                Conexao.LimparParametros();
                Conexao.AdicionarParametros("@Opcao", 2);
                Conexao.AdicionarParametros("@Nome", Nome);
                DataTable dataTableprofessor = Conexao.ExecutarConsulta(CommandType.StoredProcedure, "USP_Consultaprofessor");

                foreach (DataRow professorLinha in dataTableprofessor.Rows)
                {
                    Professor professor = new Professor();

                    professor.Idprofessor = Convert.ToInt32(professorLinha["idprofessor"]);
                    professor.Nome = professorLinha["Nome"].ToString();
                    professor.Endereco = professorLinha["Endereco"].ToString();
                    professor.NumeroEndereco = professorLinha["NumeroEndereco"].ToString();
                    professor.Bairro = professorLinha["Bairro"].ToString();
                    professor.Cidade = professorLinha["Cidade"].ToString();
                    professor.Cep = professorLinha["Cep"].ToString();
                    professor.Estado = professorLinha["Estado"].ToString();
                    professor.Telefone = professorLinha["Telefone"].ToString();
                    professor.Codigoprofessor = professorLinha["Codigoprofessor"].ToString();
                    professor.Disponibilidade = Convert.ToBoolean(professorLinha["Disponibilidade"]);
                    professor.Id_FuncionarioCada = Convert.ToInt32(professorLinha["Id_FuncionarioCadastro"].ToString());
                    professor.Sexo = Convert.ToBoolean(professorLinha["Sexo"].ToString());
                    professor.Situacao = Convert.ToBoolean(professorLinha["Situacao"].ToString());
                    professor.Cpf = professorLinha["Cpf"].ToString();
                    professor.DataNascimento = Convert.ToDateTime(professorLinha["DataNascimento"]);
                    professor.DataCadastro = Convert.ToDateTime(professorLinha["DataCadastro"]);
                    professor.DataAlteracao = Convert.ToDateTime(professorLinha["DataAlteracao"]);

                    professorColecao.Add(professor);
                }
                return professorColecao;
            }
            catch (Exception exception)
            {

                throw new Exception("Não foi possível localizar o cliente por código. Detalhes: " + exception.Message);
            }
        }

        public ProfessorColecao ConsultarPorCodigo(string Codigoprofessor)
        {
            try
            {

                ProfessorColecao professorColecao = new ProfessorColecao();
                Conexao.LimparParametros();
                Conexao.AdicionarParametros("@Opcao", 3);
                Conexao.AdicionarParametros("@Codigoprofessor", Codigoprofessor);
                DataTable dataTableprofessor = Conexao.ExecutarConsulta(CommandType.StoredProcedure, "USP_Consultaprofessor");

                foreach (DataRow professorLinha in dataTableprofessor.Rows)
                {
                    Professor professor = new Professor();

                    professor.Idprofessor = Convert.ToInt32(professorLinha["idprofessor"]);
                    professor.Nome = professorLinha["Nome"].ToString();
                    professor.Endereco = professorLinha["Endereco"].ToString();
                    professor.NumeroEndereco = professorLinha["NumeroEndereco"].ToString();
                    professor.Bairro = professorLinha["Bairro"].ToString();
                    professor.Cidade = professorLinha["Cidade"].ToString();
                    professor.Cep = professorLinha["Cep"].ToString();
                    professor.Estado = professorLinha["Estado"].ToString();
                    professor.Telefone = professorLinha["Telefone"].ToString();
                    professor.Codigoprofessor = professorLinha["Codigoprofessor"].ToString();
                    professor.Disponibilidade = Convert.ToBoolean(professorLinha["Disponibilidade"]);
                    professor.Id_FuncionarioCada = Convert.ToInt32(professorLinha["Id_FuncionarioCadastro"].ToString());
                    professor.Sexo = Convert.ToBoolean(professorLinha["Sexo"].ToString());
                    professor.Situacao = Convert.ToBoolean(professorLinha["Situacao"].ToString());
                    professor.Cpf = professorLinha["Cpf"].ToString();
                    professor.DataNascimento = Convert.ToDateTime(professorLinha["DataNascimento"]);
                    professor.DataCadastro = Convert.ToDateTime(professorLinha["DataCadastro"]);
                    professor.DataAlteracao = Convert.ToDateTime(professorLinha["DataAlteracao"]);

                    professorColecao.Add(professor);
                }
                return professorColecao;
            }
            catch (Exception exception)
            {

                throw new Exception("Não foi possível localizar o cliente por código. Detalhes: " + exception.Message);
            }
        }

        public ProfessorColecao ConsultarPorSituacao(string Situacao)
        {
            try
            {

                ProfessorColecao professorColecao = new ProfessorColecao();
                Conexao.LimparParametros();
                Conexao.AdicionarParametros("@Opcao", 4);
                Conexao.AdicionarParametros("@Situacao", Situacao);
                DataTable dataTableprofessor = Conexao.ExecutarConsulta(CommandType.StoredProcedure, "USP_Consultaprofessor");

                foreach (DataRow professorLinha in dataTableprofessor.Rows)
                {
                    Professor professor = new Professor();

                    professor.Idprofessor = Convert.ToInt32(professorLinha["idprofessor"]);
                    professor.Nome = professorLinha["Nome"].ToString();
                    professor.Endereco = professorLinha["Endereco"].ToString();
                    professor.NumeroEndereco = professorLinha["NumeroEndereco"].ToString();
                    professor.Bairro = professorLinha["Bairro"].ToString();
                    professor.Cidade = professorLinha["Cidade"].ToString();
                    professor.Cep = professorLinha["Cep"].ToString();
                    professor.Estado = professorLinha["Estado"].ToString();
                    professor.Telefone = professorLinha["Telefone"].ToString();
                    professor.Codigoprofessor = professorLinha["Codigoprofessor"].ToString();
                    professor.Disponibilidade = Convert.ToBoolean(professorLinha["Disponibilidade"]);
                    professor.Id_FuncionarioCada = Convert.ToInt32(professorLinha["Id_FuncionarioCadastro"].ToString());
                    professor.Sexo = Convert.ToBoolean(professorLinha["Sexo"].ToString());
                    professor.Situacao = Convert.ToBoolean(professorLinha["Situacao"].ToString());
                    professor.Cpf = professorLinha["Cpf"].ToString();
                    professor.DataNascimento = Convert.ToDateTime(professorLinha["DataNascimento"]);
                    professor.DataCadastro = Convert.ToDateTime(professorLinha["DataCadastro"]);
                    professor.DataAlteracao = Convert.ToDateTime(professorLinha["DataAlteracao"]);

                    professorColecao.Add(professor);
                }
                return professorColecao;
            }
            catch (Exception exception)
            {

                throw new Exception("Não foi possível localizar o cliente por código. Detalhes: " + exception.Message);
            }
        }

        public ProfessorColecao ConsultarPorIdStiuacao(string Idprofessor,string situacao)
        {
            try
            {

                ProfessorColecao professorColecao = new ProfessorColecao();
                Conexao.LimparParametros();
                Conexao.AdicionarParametros("@Opcao", 4);
                Conexao.AdicionarParametros("@idprofessor", Idprofessor);
                Conexao.AdicionarParametros("@Situacao", situacao);
                DataTable dataTableprofessor = Conexao.ExecutarConsulta(CommandType.StoredProcedure, "USP_Consultaprofessor");

                foreach (DataRow professorLinha in dataTableprofessor.Rows)
                {
                    Professor professor = new Professor();

                    professor.Idprofessor = Convert.ToInt32(professorLinha["idprofessor"]);
                    professor.Nome = professorLinha["Nome"].ToString();
                    professor.Endereco = professorLinha["Endereco"].ToString();
                    professor.NumeroEndereco = professorLinha["NumeroEndereco"].ToString();
                    professor.Bairro = professorLinha["Bairro"].ToString();
                    professor.Cidade = professorLinha["Cidade"].ToString();
                    professor.Cep = professorLinha["Cep"].ToString();
                    professor.Estado = professorLinha["Estado"].ToString();
                    professor.Telefone = professorLinha["Telefone"].ToString();
                    professor.Codigoprofessor = professorLinha["Codigoprofessor"].ToString();
                    professor.Disponibilidade = Convert.ToBoolean(professorLinha["Disponibilidade"]);
                    professor.Id_FuncionarioCada = Convert.ToInt32(professorLinha["Id_FuncionarioCadastro"].ToString());
                    professor.Sexo = Convert.ToBoolean(professorLinha["Sexo"].ToString());
                    professor.Situacao = Convert.ToBoolean(professorLinha["Situacao"].ToString());
                    professor.Cpf = professorLinha["Cpf"].ToString();
                    professor.DataNascimento = Convert.ToDateTime(professorLinha["DataNascimento"]);
                    professor.DataCadastro = Convert.ToDateTime(professorLinha["DataCadastro"]);
                    professor.DataAlteracao = Convert.ToDateTime(professorLinha["DataAlteracao"]);

                    professorColecao.Add(professor);
                }
                return professorColecao;
            }
            catch (Exception exception)
            {

                throw new Exception("Não foi possível localizar o cliente por código. Detalhes: " + exception.Message);
            }
        }

        public DataTable ConsultarPorPendencias(string Pendencia)
        {
           
            // SqlDataReader leerDados;
            SqlCommand c = new SqlCommand();
            DataTable Tabela = new DataTable();
            c.Connection = Conexao.AbrirConexao();
            c.Parameters.Add(new SqlParameter("@Opcao", 5));
            c.Parameters.Add(new SqlParameter("@Disponibilidade", Pendencia));
            c.CommandText = "USP_Consultaprofessor";
            c.CommandType = CommandType.StoredProcedure;

            leerDados = c.ExecuteReader();
            Tabela.Load(leerDados);

            leerDados.Close();

            return Tabela;
        }

        public DataTable ConsultarPorPendenciaseSituacaoDisp(string Pendencia,string Situacao)
        {

            // SqlDataReader leerDados;
            SqlCommand c = new SqlCommand();
            DataTable Tabela = new DataTable();
            c.Connection = Conexao.AbrirConexao();
            c.Parameters.Add(new SqlParameter("@Opcao", 8));
            c.Parameters.Add(new SqlParameter("@Disponibilidade", Pendencia));
            c.Parameters.Add(new SqlParameter("@Situacao", Situacao));
            c.CommandText = "USP_Consultaprofessor";
            c.CommandType = CommandType.StoredProcedure;

            leerDados = c.ExecuteReader();
            Tabela.Load(leerDados);

            leerDados.Close();

            return Tabela;
        }
        public DataTable ConsultarPorPendenciaseSituacaoInDisp(string Pendencia, string Situacao)
        {

            // SqlDataReader leerDados;
            SqlCommand c = new SqlCommand();
            DataTable Tabela = new DataTable();
            c.Connection = Conexao.AbrirConexao();
            c.Parameters.Add(new SqlParameter("@Opcao", 9));
            c.Parameters.Add(new SqlParameter("@Disponibilidade", Pendencia));
            c.Parameters.Add(new SqlParameter("@Situacao", Situacao));
            c.CommandText = "USP_Consultaprofessor";
            c.CommandType = CommandType.StoredProcedure;

            leerDados = c.ExecuteReader();
            Tabela.Load(leerDados);

            leerDados.Close();

            return Tabela;
        }
        public DataTable ConsultarPorPendenciaseSituacaoInDispSem(string Pendencia, string Situacao)
        {

            // SqlDataReader leerDados;
            SqlCommand c = new SqlCommand();
            DataTable Tabela = new DataTable();
            c.Connection = Conexao.AbrirConexao();
            c.Parameters.Add(new SqlParameter("@Opcao", 11));
            c.Parameters.Add(new SqlParameter("@Disponibilidade", Pendencia));
            c.Parameters.Add(new SqlParameter("@Situacao", Situacao));
            c.CommandText = "USP_Consultaprofessor";
            c.CommandType = CommandType.StoredProcedure;

            leerDados = c.ExecuteReader();
            Tabela.Load(leerDados);

            leerDados.Close();

            return Tabela;
        }


        
    }
}
