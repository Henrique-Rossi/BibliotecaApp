
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using ViewUser.Cache;
using System.Drawing.Imaging;
using CamadaTransferencia;

namespace SqlMs.Forms
{
    public partial class LivroEditar : Form 
    {
        public LivroEditar()
        {
            InitializeComponent();
        }
        bool situacao;   
        bool disponibilidade;
        public void ExibirConsultaNoForm(Livro livro)
        {
            label10.Text = Convert.ToString(livro.Id_Livro);
            textNomeLivro.Text = livro.Nome_Livro;
            textClassifica.Text = livro.Classificacao_Livro;
            textAutor.Text = livro.Autor_Livro;
            textAno.Text = livro.Ano_Livro;
            textGenero.Text = livro.Genero_Livro;
            textEditora.Text = livro.Editora_Livro;
            textPag.Text =Convert.ToString(livro.Paginas_Livro);
            TextQuantidade.Text = Convert.ToString(livro.Quantidade_Livro);
            textForm.Text = livro.FormaRecebimento;
            textCod.Text = Convert.ToString(livro.Codigo_Livro);
            textVolume.Text = livro.Volume;
            textLocal.Text=livro.LocalizacaoEstante;
            situacao = livro.Status_Livro;
            if (situacao == true)
            {

                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }
            disponibilidade = livro.Disponibilidade;
          
            if (disponibilidade == true)
            {
                radioButton4.Checked = true;
            }
            else
            {
                radioButton3.Checked = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "Tem Certeza que deseja Alterar o Resgistro ?";
            string caption = "Alerta";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {

                try
                {

                    CN_Livros objetoCN = new CN_Livros();
                    Livro objetoCT = new Livro();

                    objetoCT.Id_Livro = Convert.ToInt32(label10.Text);
                    objetoCT.Nome_Livro = textNomeLivro.Text;
                    objetoCT.Autor_Livro = textAutor.Text;
                    objetoCT.Ano_Livro = textAno.Text;
                    objetoCT.Volume = textVolume.Text;
                    objetoCT.FormaRecebimento = textForm.Text;
                    objetoCT.Classificacao_Livro = textClassifica.Text;
                    objetoCT.Genero_Livro = textGenero.Text;
                    objetoCT.Editora_Livro = textEditora.Text;
                    objetoCT.Paginas_Livro = Convert.ToInt16(textPag.Text);
                    objetoCT.Quantidade_Livro = Convert.ToInt32(TextQuantidade.Text);
                    objetoCT.Codigo_Livro = Convert.ToInt32(textCod.Text);
                    objetoCT.LocalizacaoEstante = textLocal.Text;
                    objetoCT.Id_FuncionarioCadastro = UserLoginCache.Id_Funcionario;
                                                  
                    objetoCT.Status_Livro = radioButton1.Checked;
                    objetoCT.Disponibilidade = radioButton4.Checked;
                    string retorno = objetoCN.AlterarLivro(objetoCT);

                    try
                    {
                        int IdLivro = Convert.ToInt32(retorno);
                        MessageBox.Show($"Alterado com sucesso  {textNomeLivro.Text}  ");                      
                        this.Close();

                    }
                    catch (FormatException)
                    {
                        MessageBox.Show($"Não foi possivel cadastrar por {retorno}{MessageBoxButtons.OK}");
                        //throw;
                    }
                }
                catch (Exception)
                {

                    //throw;
                }
              
            }
        }

       

       
    }
}
