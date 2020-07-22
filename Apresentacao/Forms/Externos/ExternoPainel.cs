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

namespace SqlMs
{
    public partial class ExternoPainel : Form
    {
        public ExternoPainel()
        {
            InitializeComponent();
        }
        public void Exibir()
        {        
            ExternoColecao externoColecao = new ExternoColecao();//Instancio uma coleção de clientes para armazenar os clientes cadastrados no banco
            CN_Externos externoRegraNegocio = new CN_Externos();//Instancio a regra de negócio para utilizar seus métodos no formulário
            externoColecao = externoRegraNegocio.ConsultarExterno();//Armazeno o método selecionado dentro da minha coleção, passando como parâmetro a pesquisa digitada pelo usuário
            dataGridView1.DataSource = null;//Seta o datagrid com null para não correr risco de armazenar lixo
            dataGridView1.DataSource = externoColecao;//Seta a minha coleção de clientes dentro do dataSource
            dataGridView1.Update();
            dataGridView1.Refresh();
        }
        public void Atualiza()
        {
            CN_Externos externoRegraNegocio = new CN_Externos();
            dataGridView1.DataSource = externoRegraNegocio.ConsultarExterno();
            lblQuantidadeRegistros.Text = "Resultado da Pesquisa: " + dataGridView1.RowCount + " Registro(s)";
        }

        private void ExternoPainel_Load(object sender, EventArgs e)
        {
            Exibir();
            lblQuantidadeRegistros.Text = "Resultado da Pesquisa: " + dataGridView1.RowCount + " Registro(s)";
        }


        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            new ExternoAdd().ShowDialog();
            Atualiza();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {           
            try
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Nenhum externo selecionado.", "Consultar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                Externo ExternoSelecionado = new Externo();
                ExternoSelecionado = (dataGridView1.SelectedRows[0].DataBoundItem as Externo);

                //String NomeFunc = dataGridView1.CurrentRow.Cells["Nome1"].Value.ToString();
                ExternoConsulta externo = new ExternoConsulta(ExternoSelecionado);
                externo.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível consultar o externo selecionado. Detalhes: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
        
            try
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Nenhum externo selecionado.", "Consultar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                Externo ExternoSelecionado = new Externo();
                ExternoSelecionado = (dataGridView1.SelectedRows[0].DataBoundItem as Externo);

                
                ExternoEditar externo = new ExternoEditar(ExternoSelecionado);
               
                DialogResult dialogResult = externo.ShowDialog();
                if (dialogResult == DialogResult.Yes)
                    Atualiza();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível consultar o externo selecionado. Detalhes: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            try
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Nenhum Registro selecionado.", "Consultar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (MessageBox.Show("Deseja excluir o Registro  selecionado?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Externo Selecionado = new Externo();
                    Selecionado = (dataGridView1.SelectedRows[0].DataBoundItem as Externo);

                    CN_Externos RegraNegocio = new CN_Externos();
                    string retorno = RegraNegocio.ExcluirExterno(Selecionado);
                    int codigo = Convert.ToInt32(retorno);
                    Atualiza();
                    MessageBox.Show("Registro excluído com sucesso.", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("O Registro selecionado não pode ser excluído, pois está sendo usado em outros processos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtConsulta_TextChanged(object sender, EventArgs e)
        {
            if (txtConsulta.Text == "")
            {
                Atualiza();

            }

        }
//                                  todos

        private void radioSituaTodos_CheckedChanged(object sender, EventArgs e)
        {
            Atualiza();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Atualiza();
        }

        private void radioPendTodos_CheckedChanged(object sender, EventArgs e)
        {
            Atualiza();
        }

        private void radioSituaDes_CheckedChanged(object sender, EventArgs e)
        {
            CN_Externos externos = new CN_Externos();
            dataGridView1.DataSource = externos.ConsultarExternoAtivo(false);
            lblQuantidadeRegistros.Text = "Resultado da Pesquisa: " + dataGridView1.RowCount + " Registro(s)";
        }

        private void radioSituaAtivo_CheckedChanged(object sender, EventArgs e)
        {
            CN_Externos externos = new CN_Externos();
            dataGridView1.DataSource = externos.ConsultarExternoAtivo(true);
            lblQuantidadeRegistros.Text = "Resultado da Pesquisa: " + dataGridView1.RowCount + " Registro(s)";
        }
        private void AtualizarGrid()
        {
            try
            {
                lblQuantidadeRegistros.Text = "Resultado da Pesquisa: " + dataGridView1.RowCount + " Cliente(s)";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível realizar a consulta. Detalhes: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
