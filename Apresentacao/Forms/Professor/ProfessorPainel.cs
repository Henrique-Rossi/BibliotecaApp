using CamadaTransferencia;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlMs.Forms
{
    public partial class ProfessorPainel : Form
    {
        CN_Professor objetoCN = new CN_Professor();
       

        public ProfessorPainel()
        {
            InitializeComponent();
        }
       
      

        public void Exibir()
        {
            ProfessorColecao Colecao = new ProfessorColecao();//Instancio uma coleção de clientes para armazenar os clientes cadastrados no banco
            CN_Professor RegraNegocio = new CN_Professor();//Instancio a regra de negócio para utilizar seus métodos no formulário
            Colecao = RegraNegocio.ConsultaProfessor();//Armazeno o método selecionado dentro da minha coleção, passando como parâmetro a pesquisa digitada pelo usuário
            dataGridView1.DataSource = null;//Seta o datagrid com null para não correr risco de armazenar lixo
            dataGridView1.DataSource = Colecao;//Seta a minha coleção de clientes dentro do dataSource
            dataGridView1.Update();
            dataGridView1.Refresh();
        }

        public void ExibirConsulta()
        {
            CN_Professor RegraNegocio = new CN_Professor();
            dataGridView1.DataSource = RegraNegocio.ConsultaProfessor();
            lblQuantidadeRegistros.Text = "Resultado da Pesquisa: " + dataGridView1.RowCount + " Registro(s)";
        }
        private void professorConsulta_Load(object sender, EventArgs e)
        {
            Exibir();
            lblQuantidadeRegistros.Text = "Resultado da Pesquisa: " + dataGridView1.RowCount + " Registro(s)";
        }


        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------//
        //                                                                      BOTÃO CHAMAR FORMS
        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------//

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            new ProfessorAdd().ShowDialog();
            ExibirConsulta();
            
        }
      
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Nenhum Registro selecionado.", "Consultar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                Professor Selecionado = new Professor();
                Selecionado = (dataGridView1.SelectedRows[0].DataBoundItem as Professor);


                ProfessorEditar professor = new ProfessorEditar(Selecionado);
                DialogResult dialogResult = professor.ShowDialog();
                if (dialogResult == DialogResult.Yes)
                    ExibirConsulta();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível consultar o  Professor selecionado. Detalhes: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    Professor Selecionado = new Professor();
                    Selecionado = (dataGridView1.SelectedRows[0].DataBoundItem as Professor);

                    CN_Professor RegraNegocio = new CN_Professor();
                    string retorno = RegraNegocio.Excluir(Selecionado);
                    int codigo = Convert.ToInt32(retorno);
                    ExibirConsulta();
                    MessageBox.Show("Registro  excluído com sucesso.", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("O Registro  selecionado não pode ser excluído, pois está sendo usado em outros processos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //botao de consultar a fixa de cadastro
        private void btnConsultar_Click(object sender, EventArgs e)
        {
          
            try
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Nenhum Registro selecionado.", "Consultar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                Professor Selecionado = new Professor();
                Selecionado = (dataGridView1.SelectedRows[0].DataBoundItem as Professor);

                
                ProfessorConsulta professor = new ProfessorConsulta(Selecionado);
                professor.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível consultar o  Professor selecionado. Detalhes: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }




        //===========================================================filtro de pesqusia da barra==================================================================================
        //-----------------------AO PRESSIONAR O BOTAO DE PESQUISA=============================///
        private void btnFiltroConsulta_Click(object sender, EventArgs e)
        {
            CN_Professor consultar = new CN_Professor();

            if (radioPenNao.Checked == true && radioSituaAtivo.Checked == true)
            {
                dataGridView1.DataSource = consultar.ConsultarPorPendenciaseSituacaoDisp(Convert.ToString(0), Convert.ToString(1));
            }
            else if (radioConsultNome.Checked == true)
            {
                dataGridView1.DataSource = consultar.ConsultarPorNome(txtConsulta.Text);

            }

            else if (radioConsulCodi.Checked == true)
            {
                dataGridView1.DataSource = consultar.ConsultarPorCodigo(txtConsulta.Text);
            }
            else if (radioSituaTodos.Checked == true)
            {
                dataGridView1.DataSource = consultar.ConsultaProfessor();
            }
            else if (radioSituaAtivo.Checked == true)
            {
                dataGridView1.DataSource = consultar.ConsultarPorSituacao(Convert.ToString(1));
            }
            else if (radioSituaDes.Checked == true)
            {
                dataGridView1.DataSource = consultar.ConsultarPorSituacao(Convert.ToString(0));
            }
            else if (radioPendTodos.Checked == true)
            {
                //dataGridView1.DataSource = consultar.ConsultaProfessor);
            }
            else if (radioPenSim.Checked == true)
            {
                dataGridView1.DataSource = consultar.ConsultarPorPendencias(Convert.ToString(0));
            }
            else if (radioPenNao.Checked == true)
            {
                dataGridView1.DataSource = consultar.ConsultarPorPendencias(Convert.ToString(1));
            }
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------



        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------//
        //                                                                      Desmarcar radio button
        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------//


        bool isChecked = false;
        private void radioConsultNome_CheckedChanged(object sender, EventArgs e)
        {
            isChecked = radioConsultNome.Checked;
            
        }

        private void radioConsultNome_Click(object sender, EventArgs e)
        {
            if (radioConsultNome.Checked && !isChecked)
                radioConsultNome.Checked = false;
            else
            {
                radioConsultNome.Checked = true;
                isChecked = false;
            }
        }

        private void radioConsulCodi_CheckedChanged(object sender, EventArgs e)
        {
            isChecked = radioConsulCodi.Checked;
        }

        private void radioConsulCodi_Click(object sender, EventArgs e)
        {
            if (radioConsulCodi.Checked && !isChecked)
                radioConsulCodi.Checked = false;
            else
            {
                radioConsulCodi.Checked = true;
                isChecked = false;
            }
        }


        //=================================Ao Selecionar radio ==============================
       //---------------------------------TODOS---------------------------------------------

        private void radioSituaTodos_CheckedChanged(object sender, EventArgs e)
        {
            ExibirConsulta();
        }
        private void radioPendTodos_CheckedChanged(object sender, EventArgs e)
        {
            ExibirConsulta();
        }


        //===========================================SEM PENDENCIAS E ATIVOS=======================================================================================
        private void radioSituaAtivo_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = objetoCN.ConsultarPorSituacao(Convert.ToString(1));

            if (radioPenNao.Checked)
            {
                dataGridView1.DataSource = objetoCN.ConsultarPorPendenciaseSituacaoDisp(Convert.ToString(1), Convert.ToString(1));
            }
            //  ATIVOS COM PENDENCIAS 
            if (radioPenSim.Checked)
            {
                dataGridView1.DataSource = objetoCN.ConsultarPorPendenciaseSituacaoDisp(Convert.ToString(0), Convert.ToString(1));
            }
        }
        private void radioPenNao_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = objetoCN.ConsultarPorPendencias(Convert.ToString(1));
            if (radioSituaAtivo.Checked)
            {
                dataGridView1.DataSource = objetoCN.ConsultarPorPendenciaseSituacaoDisp(Convert.ToString(1), Convert.ToString(1));
            }
            //  ATIVOS COM PENDENCIAS 
            if (radioSituaAtivo.Checked)
            {
                dataGridView1.DataSource = objetoCN.ConsultarPorPendenciaseSituacaoDisp(Convert.ToString(0), Convert.ToString(1));
            }

             else if (radioSituaDes.Checked)
            {
                dataGridView1.DataSource = objetoCN.ConsultarPorPendenciaseSituacaoInDispSem(Convert.ToString(1), Convert.ToString(0));
            }
        }
 //========================================================================================================================================================


 //========================================================================================================================================================    
                                    //DESATIVADOS E COM PENDENCIAS 
        private void radioSituaDes_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = objetoCN.ConsultarPorSituacao(Convert.ToString(0));
            if (radioPenSim.Checked)
            {
                dataGridView1.DataSource = objetoCN.ConsultarPorPendenciaseSituacaoInDisp(Convert.ToString(0), Convert.ToString(0));
            }
           
            if (radioPenNao.Checked)
            {
                dataGridView1.DataSource = objetoCN.ConsultarPorPendenciaseSituacaoInDispSem(Convert.ToString(1), Convert.ToString(0));
            }
        }

       
        private void radioPenSim_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = objetoCN.ConsultarPorPendencias(Convert.ToString(0));

            if (radioSituaDes.Checked)
            {
                dataGridView1.DataSource = objetoCN.ConsultarPorPendenciaseSituacaoInDisp(Convert.ToString(0), Convert.ToString(0));
            }

        }

        private void lblQuantidadeRegistros_Click(object sender, EventArgs e)
        {

        }








        //========================================================================================================================================================

    }
}
