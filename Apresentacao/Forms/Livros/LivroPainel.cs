using AcessoBancoDados;
using CamadaTransferencia;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlMs.Forms
{
    public partial class LivroPainel : Form
    {
        private ConexaoBd Conexao = new ConexaoBd();
        public LivroPainel()
        {
            InitializeComponent();
        }

        public void MostrarLivros()
        {
            CN_Livros objeto = new CN_Livros();
            dataGridView1.DataSource = objeto.MostraLivros();
        }

        private void LivroPainel_Load(object sender, EventArgs e)
        {
            MostrarLivros();
        }

        private void btnFiltroConsulta_Click(object sender, EventArgs e)
        {
            CN_Livros objeto = new CN_Livros();
            try
            {
                if (radioConsulId.Checked == true)
                {
                    dataGridView1.DataSource = objeto.MostraLivrosid(comboBox1.Text);
                }
                else
                {
                    MostrarLivros();
                }
               
            }
            catch (Exception)
            {

                MessageBox.Show("Digite no campo o que Deseja");
            }
           
           
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            new LivrosAdd().ShowDialog();
            MostrarLivros();
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Livro foi selecionado.", "Consultar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
           
          

            Livro LivroSelecionado = new Livro
            {
                Id_Livro = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id_Livro"].Value.ToString()),
                Nome_Livro = dataGridView1.CurrentRow.Cells["Nome_Livro"].Value.ToString(),
                Autor_Livro = dataGridView1.CurrentRow.Cells["Autor_Livro"].Value.ToString(),
                Ano_Livro = dataGridView1.CurrentRow.Cells["Ano_Livro"].Value.ToString(),
                Genero_Livro = dataGridView1.CurrentRow.Cells["Genero_Livro"].Value.ToString(),
                Editora_Livro = dataGridView1.CurrentRow.Cells["Editora_Livro"].Value.ToString(),
                Paginas_Livro = Convert.ToInt16(dataGridView1.CurrentRow.Cells["Paginas_Livro"].Value.ToString()),
                Status_Livro = Convert.ToBoolean(dataGridView1.CurrentRow.Cells["Status_Livro"].Value.ToString()),
                Quantidade_Livro = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Quantidade_Livro"].Value.ToString()),
                Codigo_Livro = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Codigo_Livro"].Value.ToString()),
                Classificacao_Livro = dataGridView1.CurrentRow.Cells["Classificacao_Livro"].Value.ToString(),
                Id_FuncionarioCadastro = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id_FuncionarioCadastro"].Value.ToString()),
                //LivroSelecionado.Datacadastro = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["DataCadastro"].Value.ToString());
                //LivroSelecionado.DataAlteracao = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["DataAlteracao"].Value.ToString());
                FormaRecebimento = dataGridView1.CurrentRow.Cells["FormaRecebimento"].Value.ToString(),
                Volume = dataGridView1.CurrentRow.Cells["Volume"].Value.ToString(),
                LocalizacaoEstante = dataGridView1.CurrentRow.Cells["LocalizacaoEstante"].Value.ToString(),
                Disponibilidade = Convert.ToBoolean(dataGridView1.CurrentRow.Cells["Disponibilidade"].Value.ToString()),
            };
           



            LivroConsulta frmLivroConsulta = new LivroConsulta(LivroSelecionado);

            DialogResult dialog = frmLivroConsulta.ShowDialog();
            if (dialog == DialogResult.Yes)
            {
                MostrarLivros();
            }

        }
      

        private void buttonDeletar_Click(object sender, EventArgs e)
        {
          
              string  nomeLivro = dataGridView1.CurrentRow.Cells["Nome_Livro"].Value.ToString();
               


                if (dataGridView1.SelectedRows.Count > 0)
                {

                   
                    string message = "Tem Certeza que deseja Excluir o Resgistro ?";
                    string caption = "Alerta";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;
                    result = MessageBox.Show(message, caption, buttons);


                    if (result == DialogResult.Yes)
                    {
                        Livro LivroSelecionado = new Livro
                        {
                                Id_Livro = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id_Livro"].Value.ToString()),
                                Nome_Livro = dataGridView1.CurrentRow.Cells["Nome_Livro"].Value.ToString(),
                                Autor_Livro = dataGridView1.CurrentRow.Cells["Autor_Livro"].Value.ToString(),
                                Ano_Livro = dataGridView1.CurrentRow.Cells["Ano_Livro"].Value.ToString(),
                                Genero_Livro = dataGridView1.CurrentRow.Cells["Genero_Livro"].Value.ToString(),
                                Editora_Livro = dataGridView1.CurrentRow.Cells["Editora_Livro"].Value.ToString(),
                                Paginas_Livro = Convert.ToInt16(dataGridView1.CurrentRow.Cells["Paginas_Livro"].Value.ToString()),
                                Status_Livro = Convert.ToBoolean(dataGridView1.CurrentRow.Cells["Status_Livro"].Value.ToString()),
                                Quantidade_Livro = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Quantidade_Livro"].Value.ToString()),
                                Codigo_Livro = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Codigo_Livro"].Value.ToString()),
                                Classificacao_Livro = dataGridView1.CurrentRow.Cells["Classificacao_Livro"].Value.ToString(),
                                Id_FuncionarioCadastro = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id_FuncionarioCadastro"].Value.ToString()),
                               
                                FormaRecebimento = dataGridView1.CurrentRow.Cells["FormaRecebimento"].Value.ToString(),
                                Volume = dataGridView1.CurrentRow.Cells["Volume"].Value.ToString(),
                                LocalizacaoEstante = dataGridView1.CurrentRow.Cells["LocalizacaoEstante"].Value.ToString(),
                                Disponibilidade = Convert.ToBoolean(dataGridView1.CurrentRow.Cells["Disponibilidade"].Value.ToString()),
                        };

                         CN_Livros objetoCN = new CN_Livros();
                        string retorno = objetoCN.Excluir(LivroSelecionado);
                        MostrarLivros();

                        try
                        {

                            int IdLivro = Convert.ToInt32(retorno);
                            MessageBox.Show($"Excluido com sucesso  {nomeLivro} ");


                            //this.Close();

                        }
                        catch (FormatException)
                        {
                            MessageBox.Show($"Não foi possivel excluir por {retorno}{MessageBoxButtons.OK}");
                            throw;
                        }
                    }
                }
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
           
           string nomeLivro = dataGridView1.CurrentRow.Cells["Nome_livro"].Value.ToString();

            if (dataGridView1.SelectedCells.Count > 0)
            {

                 MessageBox.Show("Você Selecionou o Usuario " + nomeLivro);
                Livro objetoCT = new Livro
                {
                    Id_Livro = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id_Livro"].Value.ToString()),
                    Nome_Livro = dataGridView1.CurrentRow.Cells["Nome_Livro"].Value.ToString(),
                    Autor_Livro = dataGridView1.CurrentRow.Cells["Autor_Livro"].Value.ToString(),
                    Ano_Livro = dataGridView1.CurrentRow.Cells["Ano_Livro"].Value.ToString(),
                    Genero_Livro = dataGridView1.CurrentRow.Cells["Genero_Livro"].Value.ToString(),
                    Editora_Livro = dataGridView1.CurrentRow.Cells["Editora_Livro"].Value.ToString(),
                    Paginas_Livro = Convert.ToInt16(dataGridView1.CurrentRow.Cells["Paginas_Livro"].Value.ToString()),
                    Status_Livro = Convert.ToBoolean(dataGridView1.CurrentRow.Cells["Status_Livro"].Value.ToString()),
                    Quantidade_Livro = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Quantidade_Livro"].Value.ToString()),
                    Codigo_Livro = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Codigo_Livro"].Value.ToString()),
                    Classificacao_Livro = dataGridView1.CurrentRow.Cells["Classificacao_Livro"].Value.ToString(),
                    Id_FuncionarioCadastro = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id_FuncionarioCadastro"].Value.ToString()),
                    // LivroSelecionado.Datacadastro = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["DataCadastro"].Value.ToString());
                    //LivroSelecionado.DataAlteracao = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["DataAlteracao"].Value.ToString());
                    FormaRecebimento = dataGridView1.CurrentRow.Cells["FormaRecebimento"].Value.ToString(),
                    Volume = dataGridView1.CurrentRow.Cells["Volume"].Value.ToString(),
                    LocalizacaoEstante = dataGridView1.CurrentRow.Cells["LocalizacaoEstante"].Value.ToString(),
                        Disponibilidade = Convert.ToBoolean(dataGridView1.CurrentRow.Cells["Disponibilidade"].Value.ToString()),
                };


                LivroEditar editar = new LivroEditar();
                editar.ExibirConsultaNoForm(objetoCT);
                editar.ShowDialog();
                MostrarLivros();

            }
            else
            {
                MessageBox.Show("Selecione um Usuario");
            }
        }
    }
    
}
