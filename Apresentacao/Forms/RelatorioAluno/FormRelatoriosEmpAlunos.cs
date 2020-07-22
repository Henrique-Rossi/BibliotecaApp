using AcessoBancoDados;
using Domain;
using SqlMs.Forms.RelatorioAluno;
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


namespace SqlMs
{
    public partial class Relatorios : Form
    {
        public Relatorios()
        {
            InitializeComponent();
        }
        DataTable dataTable = new DataTable();
        ConexaoBd Conexao = new ConexaoBd();
        SqlCommand c = new SqlCommand();
     
        public void ComboAluno()
        {
            c.Connection = Conexao.AbrirConexao();
            c.CommandText = "Select Nome,Matricula from tblAluno";
            //c.CommandType = CommandType.StoredProcedure;

            SqlDataReader ler = c.ExecuteReader();

            DataTable tabela = new DataTable();//cria uma tabela virtual
            tabela.Load(ler);

            //aqui define o campo que quer exibir
            if (radioButtonNome.Checked==true)
            {
                txtPesquisarAluno.DisplayMember = "Nome";
            }
            else if (rbMatricula.Checked == true)
            {
                txtPesquisarAluno.DisplayMember = "Matricula";
            }
            // comboBoxCodigoUsuario.DisplayMember = "Id_Aluno";



            //aqui instacia o objeto no campo
            txtPesquisarAluno.DataSource = tabela;
           // comboBoxCodigoUsuario.DataSource = tabela;

            //Mascara para os combobox         
         
            txtPesquisarAluno.Text = "[Selecione]";

            //comboBoxCodigoUsuario.Text = "[Selecione]";

           // label13.Text = "";

        }

        private void RealizarPesquisa()
        {
            try
            {                          
                if (radioButtonNome.Checked == true && rbVencidos.Checked==true)
                {                                 
                     RelatorioRegraNegocio relatorioRegraNegocio = new RelatorioRegraNegocio();
                     dataTable = relatorioRegraNegocio.ListagemAlunos(1,txtPesquisarAluno.Text, 2);
                                                       
                }
                if (radioButtonNome.Checked == true && btnFinalizados.Checked == true)
                {
                    RelatorioRegraNegocio relatorioRegraNegocio = new RelatorioRegraNegocio();
                    dataTable = relatorioRegraNegocio.ListagemAlunos(1,txtPesquisarAluno.Text, 3);

                }
                //--Matricula
                if (rbMatricula.Checked == true && rbVencidos.Checked == true)
                {
                    RelatorioRegraNegocio relatorioRegraNegocio = new RelatorioRegraNegocio();
                    dataTable = relatorioRegraNegocio.ListagemAlunos(2, txtPesquisarAluno.Text, 2);

                }
                if (rbMatricula.Checked == true && btnFinalizados.Checked == true)
                {
                    RelatorioRegraNegocio relatorioRegraNegocio = new RelatorioRegraNegocio();
                    dataTable = relatorioRegraNegocio.ListagemAlunos(2, txtPesquisarAluno.Text, 3);

                }
                /*
                if (Todos.Checked==true )
                {
                    RelatorioRegraNegocio relatorioRegraNegocio = new RelatorioRegraNegocio();
                    dataTable = relatorioRegraNegocio.ListagemAlunos(3,txtPesquisarAluno.Text,0);
                }*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível realizar a consulta. Detalhes: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
              
        private void rbMatricula_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisarAluno.Enabled = true;
            ComboAluno();
           
        }

        private void radioButtonNome_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisarAluno.Enabled = true;
            ComboAluno();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnFinalizados.Checked==false && rbVencidos.Checked==false)
                {
                    MessageBox.Show("Por Favor,selecione a condição do Empréstimo");
                }
                else
                {
                    RealizarPesquisa();
                    CrystalReport relatorio = new CrystalReport();
                    RelatorioAluno frmRelatorio = new RelatorioAluno(relatorio, dataTable);
                    frmRelatorio.Show();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível gerar o relatório selecionado.Detalhes: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

   

        private void txtPesquisarAluno_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (rbMatricula.Checked == true)
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                    MessageBox.Show("O Cambo Aceita apenas numeros");
                    txtPesquisarAluno.Text = "";
                }
            }
        }

        private void Relatorios_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /* private void Todos_CheckedChanged(object sender, EventArgs e)
         {
             if (Todos.Checked == true)
             {
                 txtPesquisarAluno.Enabled = false;
             }
             else
             {
                 txtPesquisarAluno.Enabled = true;
             }
         }
         */

    }
}
