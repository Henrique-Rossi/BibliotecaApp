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
   public class CN_Funcionario
    {
        private ConexaoBd Conexao = new ConexaoBd();
        private SqlCommand c = new SqlCommand();

        private SqlDataReader leerDados;

        public DataTable MostraFuncionarios()
        {
            DataTable Tabela = new DataTable();
            c.Connection = Conexao.AbrirConexao();
            c.CommandText = "MostrarFuncionarios";
            c.CommandType = CommandType.StoredProcedure;

            leerDados = c.ExecuteReader();
            Tabela.Load(leerDados);

            leerDados.Close();
            //Conexao.EncerrarConexao();

            return Tabela;
        }




        public FuncionarioColecao ConsultaFuncionario()
        {
            FuncionarioColecao funcionarioColecao = new FuncionarioColecao();
            Conexao.LimparParametros();

            DataTable dataTablefuncionario = Conexao.ExecutarConsulta(CommandType.StoredProcedure, "MostrarFuncionarios");
            foreach (DataRow funcionarioLinha in dataTablefuncionario.Rows)
            {
                Funcionarios funcionario = new Funcionarios();
                Restricoes restricoes = new Restricoes();


                funcionario.IdFuncionario = Convert.ToInt32(funcionarioLinha["Idfuncionario"]);
                funcionario.Nome = Convert.ToString(funcionarioLinha["Nome"]);
                funcionario.Sexo1 = Convert.ToString(funcionarioLinha["Sexo"]);
                funcionario.Cpf = Convert.ToString(funcionarioLinha["Cpf"]);
                funcionario.Cidade = Convert.ToString(funcionarioLinha["Cidade"]);
                funcionario.Estado = Convert.ToString(funcionarioLinha["Estado"]);
                funcionario.Endereco = Convert.ToString(funcionarioLinha["Endereco"]);
                funcionario.Numero = Convert.ToString(funcionarioLinha["Numero"]);
                funcionario.Bairro = Convert.ToString(funcionarioLinha["Bairro"]);
                funcionario.LoginUsuario= Convert.ToString(funcionarioLinha["LoginUsuario"]);
                funcionario.SenhaUsuario= Convert.ToString(funcionarioLinha["LoginSenha"]);
                funcionario.DataNascimento = Convert.ToDateTime(funcionarioLinha["DataNascimento"]);
                funcionario.Telefone = Convert.ToString(funcionarioLinha["Telefone"]);
                funcionario.Email = Convert.ToString(funcionarioLinha["Email"]);
                funcionario.DataAlteracao = Convert.ToDateTime(funcionarioLinha["DataAlteracao"]);
                funcionario.DataCadastro = Convert.ToDateTime(funcionarioLinha["DataCadastro"]);
                funcionario.Cep = Convert.ToString(funcionarioLinha["Cep"]);
                funcionario.Disponibilidade = Convert.ToBoolean(funcionarioLinha["Disponibilidade"]);
                funcionario.Situacao = Convert.ToBoolean(funcionarioLinha["Situacao"]);
                funcionario.Descricao=Convert.ToString(funcionarioLinha["Descricao"]);

                restricoes.BackupEx         = Convert.ToBoolean(funcionarioLinha["BackupEx"]);
                restricoes.BackupIm         = Convert.ToBoolean(funcionarioLinha["BackupIm"]);
                restricoes.Cadastro         = Convert.ToBoolean(funcionarioLinha["Cadastro"]);
                restricoes.CadastroFunc     = Convert.ToBoolean(funcionarioLinha["CadastroFunc"]);
                restricoes.Devolucao        = Convert.ToBoolean(funcionarioLinha["Devolucao"]);
                restricoes.Emprestimos      = Convert.ToBoolean(funcionarioLinha["Emprestimos"]);
                restricoes.Relatorios       = Convert.ToBoolean(funcionarioLinha["Relatorios"]);
                restricoes.Renovacao        = Convert.ToBoolean(funcionarioLinha["Renovacao"]);
                restricoes.Consulta         = Convert.ToBoolean(funcionarioLinha["Consultas"]);


                funcionario.Restricoes = restricoes;



                //funcionario.Id_FuncionarioCada = Convert.ToInt32(funcionarioLinha["Id_FuncionarioCadastro"]);


                // funcionarios.IdFuncionario = Convert.ToInt32(funcionarioLinha["Id_Funcionario"].ToString());
                //funcionarios.Nome = funcionarioLinha["Nomef"].ToString();
                //funcionario.Funcionarios = funcionarios;

                funcionarioColecao.Add(funcionario);

            }
            return funcionarioColecao;
        }
        public string CadastrarFuncionario(Funcionarios funcionario,Restricoes restricoes)
        {
            try
            {

                Conexao.LimparParametros();

                Conexao.AdicionarParametros("@Opcao", 1);
                Conexao.AdicionarParametros("@Id_funcionario", funcionario.IdFuncionario);
                Conexao.AdicionarParametros("@Nome", funcionario.Nome);
                Conexao.AdicionarParametros("@Sexo", funcionario.Sexo1);           
                Conexao.AdicionarParametros("@Cpf", funcionario.Cpf);
                Conexao.AdicionarParametros("@Descricao", funcionario.Descricao);
                Conexao.AdicionarParametros("@Cidade", funcionario.Cidade);
                Conexao.AdicionarParametros("@Estado", funcionario.Estado);
                Conexao.AdicionarParametros("@Endereco", funcionario.Endereco);
                Conexao.AdicionarParametros("@Numero", funcionario.Numero);
                Conexao.AdicionarParametros("@Bairro", funcionario.Bairro);
                Conexao.AdicionarParametros("@Complemento", funcionario.Complemento);
                Conexao.AdicionarParametros("@DataNascimento", funcionario.DataNascimento);
                Conexao.AdicionarParametros("@Telefone", funcionario.Telefone);
                Conexao.AdicionarParametros("@Email", funcionario.Email);
                Conexao.AdicionarParametros("@DataAlteracao", DateTime.Now);
                Conexao.AdicionarParametros("@DataCadastro", DateTime.Now);
                Conexao.AdicionarParametros("@Cep", funcionario.Cep);
                Conexao.AdicionarParametros("@Disponibilidade", funcionario.Disponibilidade);       
                Conexao.AdicionarParametros("@Situacao", funcionario.Situacao);
                Conexao.AdicionarParametros("@LoginUsuario", funcionario.LoginUsuario);
                Conexao.AdicionarParametros("@LoginSenha", funcionario.SenhaUsuario);

              //  Conexao.AdicionarParametros("@id", restricoes.IdFuncionario);
                Conexao.AdicionarParametros("@BackupEx ",    restricoes.BackupEx);
                Conexao.AdicionarParametros("@BackupIm ",    restricoes.BackupIm);
                Conexao.AdicionarParametros("@Cadastro",     restricoes.Cadastro);
                Conexao.AdicionarParametros("@CadastroFunc", restricoes.CadastroFunc);
                Conexao.AdicionarParametros("@Devolucao",    restricoes.Devolucao);
                Conexao.AdicionarParametros("@Emprestimos",  restricoes.Emprestimos);
                Conexao.AdicionarParametros("@Relatorios",   restricoes.Relatorios);
                Conexao.AdicionarParametros("@Renovacao",    restricoes.Renovacao);
                Conexao.AdicionarParametros("@Consultas",    restricoes.Consulta);
                //Conexao.AdicionarParametros(" ", restricoes.);
                string codigo = Conexao.ExecutarManipulacao(CommandType.StoredProcedure, "USP_funcionario").ToString();
                return codigo;


            }
            catch (SqlException erro)
            {
                throw erro;
            }
        }



        public string AlterarFuncionario(Funcionarios funcionario)
        {
            try
            {

                Conexao.LimparParametros();

                Conexao.AdicionarParametros("@Opcao", 2);
                Conexao.AdicionarParametros("@Id_funcionario", funcionario.IdFuncionario);
                Conexao.AdicionarParametros("@Nome", funcionario.Nome);
                Conexao.AdicionarParametros("@Sexo", funcionario.Sexo1);
                Conexao.AdicionarParametros("@Cpf", funcionario.Cpf);
                Conexao.AdicionarParametros("@Descricao", funcionario.Descricao);
                Conexao.AdicionarParametros("@Cidade", funcionario.Cidade);
                Conexao.AdicionarParametros("@Estado", funcionario.Estado);
                Conexao.AdicionarParametros("@Endereco", funcionario.Endereco);
                Conexao.AdicionarParametros("@Numero", funcionario.Numero);
                Conexao.AdicionarParametros("@Bairro", funcionario.Bairro);
                Conexao.AdicionarParametros("@Complemento", funcionario.Complemento);
                Conexao.AdicionarParametros("@DataNascimento", funcionario.DataNascimento);
                Conexao.AdicionarParametros("@Telefone", funcionario.Telefone);
                Conexao.AdicionarParametros("@Email", funcionario.Email);
                Conexao.AdicionarParametros("@DataAlteracao", DateTime.Now);
                Conexao.AdicionarParametros("@DataCadastro", DateTime.Now);
                Conexao.AdicionarParametros("@Cep", funcionario.Cep);
                Conexao.AdicionarParametros("@Disponibilidade", funcionario.Disponibilidade);
                Conexao.AdicionarParametros("@Situacao", funcionario.Situacao);
                Conexao.AdicionarParametros("@LoginUsuario", funcionario.LoginUsuario);
                Conexao.AdicionarParametros("@LoginSenha", funcionario.SenhaUsuario);

               
                //Conexao.AdicionarParametros(" ", restricoes.);
                string codigo = Conexao.ExecutarManipulacao(CommandType.StoredProcedure, "USP_funcionario").ToString();
                return codigo;


            }
            catch (SqlException erro)
            {
                throw erro;
            }
        }

        public string AtualizaRestricoes(Restricoes restricoes)
        {
            Conexao.LimparParametros();

           
            Conexao.AdicionarParametros("@IdFuncionario", restricoes.IdFuncionario);
            Conexao.AdicionarParametros("@BackupEx ", restricoes.BackupEx);
            Conexao.AdicionarParametros("@BackupIm ", restricoes.BackupIm);
            Conexao.AdicionarParametros("@Cadastro", restricoes.Cadastro);
            Conexao.AdicionarParametros("@CadastroFunc", restricoes.CadastroFunc);
            Conexao.AdicionarParametros("@Devolucao", restricoes.Devolucao);
            Conexao.AdicionarParametros("@Emprestimos", restricoes.Emprestimos);
            Conexao.AdicionarParametros("@Relatorios", restricoes.Relatorios);
            Conexao.AdicionarParametros("@Renovacao", restricoes.Renovacao);
            Conexao.AdicionarParametros("@Consultas", restricoes.Consulta);
            //Conexao.AdicionarParametros(" ", restricoes.);
            string codigo = Conexao.ExecutarManipulacao(CommandType.StoredProcedure, "USP_AtualizaRestricoes").ToString();
            return codigo;
        }
    }
}
