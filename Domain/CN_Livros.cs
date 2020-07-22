using AcessoBancoDados;
using CamadaTransferencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewUser.Cache;

namespace Domain
{
    public class CN_Livros
    {
        private readonly ConexaoBd Conexao = new ConexaoBd();
        SqlDataReader leerDados;//mesma funçaõ do foreach
        #region VIEW
        public DataTable MostraLivros()
        {
            // SqlDataReader leerDados;
            SqlCommand c = new SqlCommand();
            DataTable Tabela = new DataTable();
            c.Connection = Conexao.AbrirConexao();
            c.CommandText = "select * from tblLivro";
            c.CommandType = CommandType.Text;

            leerDados = c.ExecuteReader();
            Tabela.Load(leerDados);

            leerDados.Close();

            return Tabela;
        }
        public DataTable MostraLivrosid(string Id_Livro)
        {
            DataTable Tabela = new DataTable();

            SqlCommand c = new SqlCommand
            {
                Connection = Conexao.AbrirConexao(),
                CommandText = "select * from tblLivro where Id_Livro=" + Id_Livro,
                CommandType = CommandType.Text
            };

            leerDados = c.ExecuteReader();
            Tabela.Load(leerDados);

            leerDados.Close();

            return Tabela;
        }
        #endregion
        //---------------------------------------
        #region  CRUD

        public string InserirLivro(Livro Livro)
        {

            try
            {

                Conexao.LimparParametros();
                Conexao.AdicionarParametros("@Opcao", 1);
                Conexao.AdicionarParametros("@id_livro", Livro.Id_Livro);
                Conexao.AdicionarParametros("@Nome_Livro", Livro.Nome_Livro);
                Conexao.AdicionarParametros("@Autor_Livro", Livro.Autor_Livro);
                Conexao.AdicionarParametros("@Ano_Livro", Livro.Ano_Livro);
                Conexao.AdicionarParametros("@Genero_Livro", Livro.Genero_Livro);
                Conexao.AdicionarParametros("@Editora_Livro", Livro.Editora_Livro);
                Conexao.AdicionarParametros("@Paginas_Livro", Livro.Paginas_Livro);
                Conexao.AdicionarParametros("@Status_Livro", Livro.Status_Livro);
                Conexao.AdicionarParametros("@Quantidade_Livro", Livro.Quantidade_Livro);
                Conexao.AdicionarParametros("@Codigo_Livro", Livro.Codigo_Livro);
                Conexao.AdicionarParametros("@Classificacao_Livro", Livro.Classificacao_Livro);
                Conexao.AdicionarParametros("@Id_FuncionarioCadastro", UserLoginCache.Id_Funcionario);
                Conexao.AdicionarParametros("@FormaRecebimento", Livro.FormaRecebimento);
                Conexao.AdicionarParametros("@Volume", Livro.Volume);
                Conexao.AdicionarParametros("@LocalizacaoEstante", Livro.LocalizacaoEstante);
                Conexao.AdicionarParametros("@Disponibilidade", Livro.Disponibilidade);
                Conexao.AdicionarParametros("@Datacadastro", DateTime.Now);
                Conexao.AdicionarParametros("@DataAlteracao", DateTime.Now);
                //string codigo = Conexao.ExecutarManipulacao(CommandType.Text, "insert into tblLivro(Nome_Livro,Autor_Livro,Ano_Livro,Genero_Livro,Editora_Livro,Paginas_Livro,Status_Livro,Quantidade_Livro,Codigo_Livro,Classificacao_Livro,Id_FuncionarioCadastro,Datacadastro,DataAlteracao,FormaRecebimento,Disponibilidade)Values" +"(@Nome_Livro,@Autor_Livro,@Ano_Livro,@Genero_Livro,@Editora_Livro,@Paginas_Livro,@Status_Livro,@Quantidade_Livro,@Codigo_Livro,@Classificacao_Livro,@Id_FuncionarioCadastro,@Datacadastro,@DataAlteracao,@FormaRecebimento,@Disponibilidade)").ToString();
                string codigo = Conexao.ExecutarManipulacao(CommandType.StoredProcedure, "USP_Livros").ToString();
                return codigo;


            }
            catch (SqlException erro)
            {
                throw erro;
            }

        }
        public string AlterarLivro(Livro Livro)
        {
            try
            {

                Conexao.LimparParametros();
                Conexao.AdicionarParametros("@Opcao", 2);
                Conexao.AdicionarParametros("@id_livro", Livro.Id_Livro);
                Conexao.AdicionarParametros("@Nome_Livro", Livro.Nome_Livro);
                Conexao.AdicionarParametros("@Autor_Livro", Livro.Autor_Livro);
                Conexao.AdicionarParametros("@Ano_Livro", Livro.Ano_Livro);
                Conexao.AdicionarParametros("@Genero_Livro", Livro.Genero_Livro);
                Conexao.AdicionarParametros("@Editora_Livro", Livro.Editora_Livro);
                Conexao.AdicionarParametros("@Paginas_Livro", Livro.Paginas_Livro);
                Conexao.AdicionarParametros("@Status_Livro", Livro.Status_Livro);
                Conexao.AdicionarParametros("@Quantidade_Livro", Livro.Quantidade_Livro);
                Conexao.AdicionarParametros("@Codigo_Livro", Livro.Codigo_Livro);
                Conexao.AdicionarParametros("@Classificacao_Livro", Livro.Classificacao_Livro);
                Conexao.AdicionarParametros("@Id_FuncionarioCadastro", UserLoginCache.Id_Funcionario);
                Conexao.AdicionarParametros("@FormaRecebimento", Livro.FormaRecebimento);
                Conexao.AdicionarParametros("@Volume", Livro.Volume);
                Conexao.AdicionarParametros("@LocalizacaoEstante", Livro.LocalizacaoEstante);
                Conexao.AdicionarParametros("@Disponibilidade", Livro.Disponibilidade);
                Conexao.AdicionarParametros("@Datacadastro", DateTime.Now);
                Conexao.AdicionarParametros("@DataAlteracao", DateTime.Now);

                string codigo = Conexao.ExecutarManipulacao(CommandType.StoredProcedure, "USP_Livros").ToString();
                return codigo;


            }
            catch (SqlException erro)
            {
                throw erro;
            }
        }
        public string Excluir(Livro Livro)
        {
            try
            {

                Conexao.LimparParametros();
                Conexao.AdicionarParametros("@Opcao", 3);
                Conexao.AdicionarParametros("@id_livro", Livro.Id_Livro);
                Conexao.AdicionarParametros("@Nome_Livro", Livro.Nome_Livro);
                Conexao.AdicionarParametros("@Autor_Livro", Livro.Autor_Livro);
                Conexao.AdicionarParametros("@Ano_Livro", Livro.Ano_Livro);
                Conexao.AdicionarParametros("@Genero_Livro", Livro.Genero_Livro);
                Conexao.AdicionarParametros("@Editora_Livro", Livro.Editora_Livro);
                Conexao.AdicionarParametros("@Paginas_Livro", Livro.Paginas_Livro);
                Conexao.AdicionarParametros("@Status_Livro", Livro.Status_Livro);
                Conexao.AdicionarParametros("@Quantidade_Livro", Livro.Quantidade_Livro);
                Conexao.AdicionarParametros("@Codigo_Livro", Livro.Codigo_Livro);
                Conexao.AdicionarParametros("@Classificacao_Livro", Livro.Classificacao_Livro);
                Conexao.AdicionarParametros("@Id_FuncionarioCadastro", UserLoginCache.Id_Funcionario);
                Conexao.AdicionarParametros("@FormaRecebimento", Livro.FormaRecebimento);
                Conexao.AdicionarParametros("@Volume", Livro.Volume);
                Conexao.AdicionarParametros("@LocalizacaoEstante", Livro.LocalizacaoEstante);
                Conexao.AdicionarParametros("@Disponibilidade", Livro.Disponibilidade);
                Conexao.AdicionarParametros("@Datacadastro", DateTime.Now);
                Conexao.AdicionarParametros("@DataAlteracao", DateTime.Now);

                string codigo = Conexao.ExecutarManipulacao(CommandType.StoredProcedure, "USP_Livros").ToString();
                return codigo;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        #endregion
        //--------------------------------------
        #region COMBOX
        public string CadatrarGenero(string genero)
        {
            try
            {
                Conexao.LimparParametros();
                Conexao.AdicionarParametros("@Genero", genero);
                string codigo = Conexao.ExecutarManipulacao(CommandType.StoredProcedure, "Usp_ComboBoxGenero").ToString();
                return codigo;
            }
            catch (SqlException erro)
            {
                throw erro;
            }


        }
        public string CadastrarAutor(string autor)
        {
            try
            {
                Conexao.LimparParametros();
                Conexao.AdicionarParametros("@Autor", autor);
                string codigo = Conexao.ExecutarManipulacao(CommandType.StoredProcedure, "Usp_ComboboxAutor").ToString();
                return codigo;
            }
            catch (SqlException erro)
            {
                throw erro;
            }
        }

        public string CadastrarEditora(string Editora)
        {
            try
            {
                Conexao.LimparParametros();
                Conexao.AdicionarParametros("@Editora", Editora);
                string codigo = Conexao.ExecutarManipulacao(CommandType.StoredProcedure, "Usp_ComboboxEditora").ToString();
                return codigo;
            }
            catch (SqlException erro)
            {
                throw erro;
            }
            #endregion
        }
    }
}
