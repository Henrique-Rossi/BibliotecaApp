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
    public class CN_Externos
    {
        private ConexaoBd Conexao = new ConexaoBd();
        public string CadastrarExterno(Externo externo)
        {
            try
            {

                Conexao.LimparParametros();

                Conexao.AdicionarParametros("@Opcao", 1);
                Conexao.AdicionarParametros("@IdExterno", externo.IdExterno);
                Conexao.AdicionarParametros("@Nome", externo.Nome);
                Conexao.AdicionarParametros("@Sexo", externo.Sexo);               
                Conexao.AdicionarParametros("@Cpf", externo.Cpf);
                Conexao.AdicionarParametros("@Descricao", externo.Descricao);
                Conexao.AdicionarParametros("@Cidade", externo.Cidade);
                Conexao.AdicionarParametros("@Estado", externo.Estado);
                Conexao.AdicionarParametros("@Endereco", externo.Endereco);
                Conexao.AdicionarParametros("@Numero", externo.Numero);
                Conexao.AdicionarParametros("@Bairro", externo.Bairro);
                Conexao.AdicionarParametros("@Complemento", externo.Complemento);
                Conexao.AdicionarParametros("@DataNascimento", externo.DataNascimento);
                Conexao.AdicionarParametros("@Telefone", externo.Telefone);
                Conexao.AdicionarParametros("@Email", externo.Email);
                Conexao.AdicionarParametros("@DataAlteracao", DateTime.Now);
                Conexao.AdicionarParametros("@DataCadastro", DateTime.Now);
                Conexao.AdicionarParametros("@Cep", externo.Cep);
                Conexao.AdicionarParametros("@Disponibilidade", externo.Disponibilidade);
                Conexao.AdicionarParametros("@Id_FuncionarioCadastro", externo.Id_FuncionarioCadastro);
                Conexao.AdicionarParametros("@Situacao", externo.Situacao);
                Conexao.AdicionarParametros("@Pais", externo.Pais);

                string codigo = Conexao.ExecutarManipulacao(CommandType.StoredProcedure, "USP_Externo").ToString();
                return codigo;


            }
            catch (SqlException erro)
            {
                throw erro;
            }
        }
        public string EditarExterno(Externo externo)
        {
            try
            {

                Conexao.LimparParametros();

                Conexao.AdicionarParametros("@Opcao", 2);
                Conexao.AdicionarParametros("@IdExterno", externo.IdExterno);
                Conexao.AdicionarParametros("@Nome", externo.Nome);
                Conexao.AdicionarParametros("@Sexo", externo.Sexo);
                Conexao.AdicionarParametros("@Cpf", externo.Cpf);
                Conexao.AdicionarParametros("@Descricao", externo.Descricao);
                Conexao.AdicionarParametros("@Cidade", externo.Cidade);
                Conexao.AdicionarParametros("@Estado", externo.Estado);
                Conexao.AdicionarParametros("@Endereco", externo.Endereco);
                Conexao.AdicionarParametros("@Numero", externo.Numero);
                Conexao.AdicionarParametros("@Bairro", externo.Bairro);
                Conexao.AdicionarParametros("@Complemento", externo.Complemento);
                Conexao.AdicionarParametros("@DataNascimento", externo.DataNascimento);
                Conexao.AdicionarParametros("@Telefone", externo.Telefone);
                Conexao.AdicionarParametros("@Email", externo.Email);
                Conexao.AdicionarParametros("@DataAlteracao", DateTime.Now);
                Conexao.AdicionarParametros("@DataCadastro", DateTime.Now);
                Conexao.AdicionarParametros("@Cep", externo.Cep);
                Conexao.AdicionarParametros("@Disponibilidade", externo.Disponibilidade);
                Conexao.AdicionarParametros("@Id_FuncionarioCadastro", externo.Id_FuncionarioCadastro);
                Conexao.AdicionarParametros("@Situacao", externo.Situacao);
                Conexao.AdicionarParametros("@Pais", externo.Pais);

                string codigo = Conexao.ExecutarManipulacao(CommandType.StoredProcedure, "USP_Externo").ToString();
                return codigo;


            }
            catch (SqlException erro)
            {
                throw erro;
            }
        }

        public string ExcluirExterno(Externo externo)
        {
            try
            {

                Conexao.LimparParametros();

                Conexao.AdicionarParametros("@Opcao", 3);
                Conexao.AdicionarParametros("@IdExterno", externo.IdExterno);
                Conexao.AdicionarParametros("@Nome", externo.Nome);
                Conexao.AdicionarParametros("@Sexo", externo.Sexo);
                Conexao.AdicionarParametros("@Cpf", externo.Cpf);
                Conexao.AdicionarParametros("@Descricao", externo.Descricao);
                Conexao.AdicionarParametros("@Cidade", externo.Cidade);
                Conexao.AdicionarParametros("@Estado", externo.Estado);
                Conexao.AdicionarParametros("@Endereco", externo.Endereco);
                Conexao.AdicionarParametros("@Numero", externo.Numero);
                Conexao.AdicionarParametros("@Bairro", externo.Bairro);
                Conexao.AdicionarParametros("@Complemento", externo.Complemento);
                Conexao.AdicionarParametros("@DataNascimento", externo.DataNascimento);
                Conexao.AdicionarParametros("@Telefone", externo.Telefone);
                Conexao.AdicionarParametros("@Email", externo.Email);
                Conexao.AdicionarParametros("@DataAlteracao", DateTime.Now);
                Conexao.AdicionarParametros("@DataCadastro", DateTime.Now);
                Conexao.AdicionarParametros("@Cep", externo.Cep);
                Conexao.AdicionarParametros("@Disponibilidade", externo.Disponibilidade);
                Conexao.AdicionarParametros("@Id_FuncionarioCadastro", externo.Id_FuncionarioCadastro);
                Conexao.AdicionarParametros("@Situacao", externo.Situacao);
                Conexao.AdicionarParametros("@Pais", externo.Pais);

                string codigo = Conexao.ExecutarManipulacao(CommandType.StoredProcedure, "USP_Externo").ToString();
                return codigo;


            }
            catch (SqlException erro)
            {
                throw erro;
            }
        }

     
        public ExternoColecao ConsultarExterno()
        {
            try
            {
                ExternoColecao externoColecao = new ExternoColecao();
                Conexao.LimparParametros();
                Conexao.AdicionarParametros("@Opcao", 1);
                DataTable dataTableExterno = Conexao.ExecutarConsulta(CommandType.StoredProcedure, "MostrarExternos");
                foreach (DataRow ExternoLinha in dataTableExterno.Rows)
                {

                    Externo externo = new Externo();
                    Funcionarios funcionarios = new Funcionarios();

                    externo.IdExterno             = Convert.ToInt32(ExternoLinha["IdExterno"]);
                    externo.Nome                  = Convert.ToString(ExternoLinha["Nome"]);
                    externo.Sexo                  = Convert.ToBoolean(ExternoLinha["Sexo"]);
                    externo.Cpf                   = Convert.ToString(ExternoLinha["Cpf"]);
                    externo.Descricao             = Convert.ToString(ExternoLinha["Descricao"]);
                    externo.Cidade                = Convert.ToString(ExternoLinha["Cidade"]);
                    externo.Estado                = Convert.ToString(ExternoLinha["Estado"]);
                    externo.Endereco              = Convert.ToString(ExternoLinha["Endereco"]);
                    externo.Numero                = Convert.ToString(ExternoLinha["Numero"]);
                    externo.Bairro                = Convert.ToString(ExternoLinha["Bairro"]);
                    externo.Complemento           = Convert.ToString(ExternoLinha["Complemento"]);
                    externo.DataNascimento        = Convert.ToDateTime(ExternoLinha["DataNascimento"]);
                    externo.Telefone              = Convert.ToString(ExternoLinha["Telefone"]);
                    externo.Email                 = Convert.ToString(ExternoLinha["Email"]);
                    externo.DataAlteracao         = Convert.ToDateTime(ExternoLinha["DataAlteracao"]);
                    externo.DataCadastro          = Convert.ToDateTime(ExternoLinha["DataCadastro"]);
                    externo.Cep                   = Convert.ToString(ExternoLinha["Cep"]);
                    externo.Disponibilidade       = Convert.ToBoolean(ExternoLinha["Disponibilidade"]);
                    externo.Situacao              = Convert.ToBoolean(ExternoLinha["Situacao"]);
                    externo.Pais                  = Convert.ToString(ExternoLinha["Pais"]);
                    externo.Id_FuncionarioCadastro= Convert.ToInt32(ExternoLinha["Id_FuncionarioCadastro"]);
                    
                    
                    funcionarios.IdFuncionario = Convert.ToInt32(ExternoLinha["Id_Funcionario"].ToString());
                    funcionarios.Nome = ExternoLinha["Nomef"].ToString();
                    externo.Funcionarios = funcionarios;
                    
                    
                

                    externoColecao.Add(externo);

                    
                    

                }
                return externoColecao;
            }
            catch (SqlException erro)
            {
                throw erro;
            }
        }
        public ExternoColecao ConsultarExternoAtivo(bool situacao)
        {
            try
            {
                ExternoColecao externoColecao = new ExternoColecao();
                Conexao.LimparParametros();
                Conexao.AdicionarParametros("@Opcao", 2);
                Conexao.AdicionarParametros("@Situacao",situacao);
                DataTable dataTableExterno = Conexao.ExecutarConsulta(CommandType.StoredProcedure, "MostrarExternos");
                foreach (DataRow ExternoLinha in dataTableExterno.Rows)
                {

                    Externo externo = new Externo();
                    Funcionarios funcionarios = new Funcionarios();

                    externo.IdExterno = Convert.ToInt32(ExternoLinha["IdExterno"]);
                    externo.Nome = Convert.ToString(ExternoLinha["Nome"]);
                    externo.Sexo = Convert.ToBoolean(ExternoLinha["Sexo"]);
                    externo.Cpf = Convert.ToString(ExternoLinha["Cpf"]);
                    externo.Descricao = Convert.ToString(ExternoLinha["Descricao"]);
                    externo.Cidade = Convert.ToString(ExternoLinha["Cidade"]);
                    externo.Estado = Convert.ToString(ExternoLinha["Estado"]);
                    externo.Endereco = Convert.ToString(ExternoLinha["Endereco"]);
                    externo.Numero = Convert.ToString(ExternoLinha["Numero"]);
                    externo.Bairro = Convert.ToString(ExternoLinha["Bairro"]);
                    externo.Complemento = Convert.ToString(ExternoLinha["Complemento"]);
                    externo.DataNascimento = Convert.ToDateTime(ExternoLinha["DataNascimento"]);
                    externo.Telefone = Convert.ToString(ExternoLinha["Telefone"]);
                    externo.Email = Convert.ToString(ExternoLinha["Email"]);
                    externo.DataAlteracao = Convert.ToDateTime(ExternoLinha["DataAlteracao"]);
                    externo.DataCadastro = Convert.ToDateTime(ExternoLinha["DataCadastro"]);
                    externo.Cep = Convert.ToString(ExternoLinha["Cep"]);
                    externo.Disponibilidade = Convert.ToBoolean(ExternoLinha["Disponibilidade"]);
                    externo.Situacao = Convert.ToBoolean(ExternoLinha["Situacao"]);
                    externo.Pais = Convert.ToString(ExternoLinha["Pais"]);
                    externo.Id_FuncionarioCadastro = Convert.ToInt32(ExternoLinha["Id_FuncionarioCadastro"]);


                    funcionarios.IdFuncionario = Convert.ToInt32(ExternoLinha["Id_Funcionario"].ToString());
                    funcionarios.Nome = ExternoLinha["Nomef"].ToString();
                    externo.Funcionarios = funcionarios;




                    externoColecao.Add(externo);




                }
                return externoColecao;
            }
            catch (SqlException erro)
            {
                throw erro;
            }
        }
     

    }
}
