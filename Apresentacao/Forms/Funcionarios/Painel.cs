using CamadaTransferencia;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewUser.Cache;

namespace SqlMs
{
    public partial class Painel : Form
    {
        public Painel()
        {
            InitializeComponent();
            if (UserLoginCache.CadastroFunc== false)
            {
                btnAdicionar.Visible = false;
                btnDesativar.Visible = false;
            }
        }
        public void  MostrarFunc()
        {
            FuncionarioColecao Colecao = new FuncionarioColecao();//Instancio uma coleção de clientes para armazenar os clientes cadastrados no banco
            CN_Funcionario RegraNegocio = new CN_Funcionario();//Instancio a regra de negócio para utilizar seus métodos no formulário
            Colecao = RegraNegocio.ConsultaFuncionario();//Armazeno o método selecionado dentro da minha coleção, passando como parâmetro a pesquisa digitada pelo usuário
            dataGridView1.DataSource = null;//Seta o datagrid com null para não correr risco de armazenar lixo
            dataGridView1.DataSource = Colecao;//Seta a minha coleção de clientes dentro do dataSource
            dataGridView1.Update();
            dataGridView1.Refresh();
        }



        public void Exibir()
        {
            CN_Funcionario objeto = new CN_Funcionario();
            dataGridView1.DataSource = objeto.ConsultaFuncionario();
        }
        private void Painel_Load(object sender, EventArgs e)
        {
            MostrarFunc();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new FuncionarioAdd().ShowDialog();
            Exibir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Nenhum Registro Selecionado.", "Consultar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    Funcionarios Selecionado = new Funcionarios();
                    Selecionado = (dataGridView1.SelectedRows[0].DataBoundItem as Funcionarios);



                    FuncionarioEditar funcionario = new FuncionarioEditar(Selecionado);
                    DialogResult dialogResult = funcionario.ShowDialog();
                    if (dialogResult == DialogResult.Yes)
                        Exibir();
                }
                Exibir();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não Foi Possível Consultar o Registro selecionado. Detalhes: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Nenhum Registro Selecionado.", "Consultar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (dataGridView1.SelectedRows.Count > 0)
                {

                    Funcionarios funcionario = new Funcionarios();
                    funcionario = (dataGridView1.SelectedRows[0].DataBoundItem as Funcionarios);

                    FuncionarioRestricoes restricoes = new FuncionarioRestricoes(funcionario);
                    DialogResult dialogResult = restricoes.ShowDialog();
                    if (dialogResult == DialogResult.Yes)
                        Exibir();
                }
                Exibir();
            }           
            catch (Exception ex)
            {
                MessageBox.Show("Não Foi Possível Consultar o Registro selecionado. Detalhes: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
      
    }
}
