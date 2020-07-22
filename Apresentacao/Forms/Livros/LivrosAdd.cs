using AcessoBancoDados;
using CamadaTransferencia;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewUser.Cache;

namespace SqlMs.Forms
{
    public partial class LivrosAdd : Form
    {
        public LivrosAdd()
        {
            InitializeComponent();
        }


        Utilidades utilidades = new Utilidades();
        public void ComboGeneroLivro()
        {
            ConexaoBd Conexao = new ConexaoBd();
            SqlCommand c = new SqlCommand();
            c.Connection = Conexao.AbrirConexao();
            c.CommandText = "Select Genero from tblGenerolivro";
     
            SqlDataReader ler = c.ExecuteReader();

            DataTable tabela = new DataTable();//cria uma tabela virtual
            tabela.Load(ler);

            //aqui define o campo que quer exibir    
            comboBoxGen.DisplayMember = "Genero";

            //aqui instacia o objeto no campo
            comboBoxGen.DataSource = tabela;
       
            //Mascara para os combobox         
            comboBoxGen.Text = "[Selecione]";         
        }
        public void ComboAutorLivro()
        {
            ConexaoBd Conexao = new ConexaoBd();
            SqlCommand c = new SqlCommand();
            c.Connection = Conexao.AbrirConexao();
            c.CommandText = "Select Autor from ComboboxAutor";

            SqlDataReader ler = c.ExecuteReader();

            DataTable tabela = new DataTable();//cria uma tabela virtual
            tabela.Load(ler);

            //aqui define o campo que quer exibir    
            textAutor.DisplayMember = "Autor";

            //aqui instacia o objeto no campo
            textAutor.DataSource = tabela;

            //Mascara para os combobox         
            textAutor.Text = "[Selecione]";
        }
        public void ComboEditoraLivro()
        {
            ConexaoBd Conexao = new ConexaoBd();
            SqlCommand c = new SqlCommand();
            c.Connection = Conexao.AbrirConexao();
            c.CommandText = "Select Editora from ComboboxEditora";

            SqlDataReader ler = c.ExecuteReader();

            DataTable tabela = new DataTable();//cria uma tabela virtual
            tabela.Load(ler);

            //aqui define o campo que quer exibir    
            textEditora.DisplayMember = "Editora";

            //aqui instacia o objeto no campo
            textEditora.DataSource = tabela;

            //Mascara para os combobox         
            textEditora.Text = "[Selecione]";
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            try 
            { 

                Livro objetoCT = new Livro
                {
                    Id_Livro = 0,
                    Nome_Livro = textNome.Text,
                    Autor_Livro = textAutor.Text,
                    Ano_Livro = textano.Text,
                    Genero_Livro = comboBoxGen.Text,
                    Editora_Livro = textEditora.Text,
                    Paginas_Livro = Convert.ToInt16(numericUpDownPag.Text),
                    Status_Livro = true,
                    Quantidade_Livro = Convert.ToInt16(numericUpDownQuantidade.Text),
                    Codigo_Livro = Convert.ToInt32(numericUpDownCod.Text),
                    Classificacao_Livro = numericUpDownClass.Text,
                    FormaRecebimento = textReci.Text,
                    Volume = textVolume.Text,
                    LocalizacaoEstante = textLocal.Text,
                    Disponibilidade = true,
                    Id_FuncionarioCadastro = UserLoginCache.Id_Funcionario
                };


                    CN_Livros objetoCN = new CN_Livros();
                    string retorno= objetoCN.InserirLivro(objetoCT);
                    try
                    {
                        int IdLivro = Convert.ToInt32(retorno);
                        MessageBox.Show($"Cadastrado com sucesso  {textNome.Text} com id {IdLivro} ");
                        utilidades.LimpaCampos(this.panel1.Controls);

                        //this.Close();

                    }
                    catch (FormatException)
                    {
                        MessageBox.Show($"Não foi possivel cadastrar por {retorno}{MessageBoxButtons.OK}");
                        throw;
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel inserir  por: " + ex);
            }
        }

        private void LivrosAdd_Load(object sender, EventArgs e)
        {
            ComboGeneroLivro();
            ComboAutorLivro();
            ComboEditoraLivro();
        }

        #region Picture
        //autor
        private void pictureBox1_Click(object sender, EventArgs e)
        {

            string message = "Deseja Cadastrar um novo Ator??";
            string caption = "Alerta";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);


            if (result == DialogResult.Yes)
            {
                ComboAutor cadastrar = new ComboAutor();
                cadastrar.ShowDialog();
                ComboAutorLivro();
            }
        }
        //Genero
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
            string message = "Deseja Cadastrar um novo Genero??";
            string caption = "Alerta";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);


            if (result == DialogResult.Yes)
            {
                CadastroComboGenero cadastrar = new CadastroComboGenero();
                cadastrar.ShowDialog();
                ComboGeneroLivro();
            }
        }
        //Editora
        private void pictureBox2_Click(object sender, EventArgs e)
        {

            string message = "Deseja Cadastrar uma nova Editora?";
            string caption = "Alerta";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);


            if (result == DialogResult.Yes)
            {
                ComboboxEditora cadastrar = new ComboboxEditora();
                cadastrar.ShowDialog();
                ComboEditoraLivro();
            }
        }

        #endregion

       
    }


}
