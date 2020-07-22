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

namespace SqlMs.Forms
{
    public partial class ProfessorPainel : Form
    {
        CN_Professor objetoCN = new CN_Professor();
       
        int idProfessor ;
        string nomeProfessor =null;

        public ProfessorPainel()
        {
            InitializeComponent();
        }
       public void ExibirConsulta()
        {
            CN_Professor objeto = new CN_Professor();
            dataGridView1.DataSource = objeto.ConsultarProfessor();
        }
        
        private void ProfessorConsulta_Load(object sender, EventArgs e)
        {
            ExibirConsulta();

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
                    idProfessor = Convert.ToInt32( dataGridView1.CurrentRow.Cells["idProfessor"].Value.ToString());
                    nomeProfessor = dataGridView1.CurrentRow.Cells["Nome"].Value.ToString();

            if (dataGridView1.SelectedCells.Count > 0)
            {//se der um erro ao apagar p selecione é porque alterou indice ,entao vai ter que alterar todos index abaixo ja que ele é considerado o index 0


                Professor objetoCT = new Professor();


                MessageBox.Show("Você Selecionou o Usuario " + nomeProfessor);
                    objetoCT.IdProfessor = Convert.ToInt32(dataGridView1.CurrentRow.Cells["idProfessor"].Value.ToString());
                    objetoCT.Nome = dataGridView1.CurrentRow.Cells["Nome"].Value.ToString();
                    objetoCT.Endereco = dataGridView1.CurrentRow.Cells["Endereco"].Value.ToString();
                    objetoCT.NumeroEndereco = dataGridView1.CurrentRow.Cells["NumeroEndereco"].Value.ToString();
                    objetoCT.Bairro = dataGridView1.CurrentRow.Cells["Bairro"].Value.ToString();
                    objetoCT.Cidade = dataGridView1.CurrentRow.Cells["Cidade"].Value.ToString();
                    objetoCT.Cep = dataGridView1.CurrentRow.Cells["Cep"].Value.ToString();
                    objetoCT.Estado = dataGridView1.CurrentRow.Cells["Estado"].Value.ToString();
                    objetoCT.Telefone = dataGridView1.CurrentRow.Cells["Telefone"].Value.ToString();
                    objetoCT.CodigoProfessor = dataGridView1.CurrentRow.Cells["CodigoProfessor"].Value.ToString();
                    objetoCT.Disponibilidade = Convert.ToBoolean(dataGridView1.CurrentRow.Cells["Disponibilidade"].Value.ToString());
                    objetoCT.Sexo = Convert.ToBoolean(dataGridView1.CurrentRow.Cells["Sexo"].Value.ToString());
                    objetoCT.Situacao = Convert.ToBoolean(dataGridView1.CurrentRow.Cells["Situacao"].Value.ToString());
                    objetoCT.Cpf = dataGridView1.CurrentRow.Cells["Cpf"].Value.ToString();
                    objetoCT.DataNascimento = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["DataNascimento"].Value.ToString());


                ProfessorEditar editar = new ProfessorEditar();
                    editar.ExibirConsultaNoForm(objetoCT);
                    editar.ShowDialog();
                    ExibirConsulta();

            }
            else
            {
                MessageBox.Show("Selecione um Usuario");
            }
            
        }
    
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            nomeProfessor = dataGridView1.CurrentRow.Cells["Nome"].Value.ToString();
            idProfessor = Convert.ToInt32(dataGridView1.CurrentRow.Cells["idProfessor"].Value.ToString());
          

            if (dataGridView1.SelectedRows.Count > 0)
            {
                
                        MessageBox.Show("Você Selecionou o Usuario " + nomeProfessor + idProfessor);
                        string message = "Tem Certeza que deseja Excluir o Resgistro ?";
                        string caption = "Alerta";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result;
                        result = MessageBox.Show(message, caption, buttons);


                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                        Professor objetoCT = new Professor();
                        objetoCT.IdProfessor = Convert.ToInt32(dataGridView1.CurrentRow.Cells["idProfessor"].Value.ToString());
                        objetoCT.Nome = dataGridView1.CurrentRow.Cells["Nome"].Value.ToString();
                        objetoCT.Endereco = dataGridView1.CurrentRow.Cells["Endereco"].Value.ToString();
                        objetoCT.NumeroEndereco = dataGridView1.CurrentRow.Cells["NumeroEndereco"].Value.ToString();
                        objetoCT.Bairro = dataGridView1.CurrentRow.Cells["Bairro"].Value.ToString();
                        objetoCT.Cidade = dataGridView1.CurrentRow.Cells["Cidade"].Value.ToString();
                        objetoCT.Cep = dataGridView1.CurrentRow.Cells["Cep"].Value.ToString();
                        objetoCT.Estado = dataGridView1.CurrentRow.Cells["Estado"].Value.ToString();
                        objetoCT.Telefone = dataGridView1.CurrentRow.Cells["Telefone"].Value.ToString();
                        objetoCT.CodigoProfessor = dataGridView1.CurrentRow.Cells["CodigoProfessor"].Value.ToString();
                        objetoCT.Disponibilidade = Convert.ToBoolean(dataGridView1.CurrentRow.Cells["Disponibilidade"].Value.ToString());
                        objetoCT.Sexo = Convert.ToBoolean(dataGridView1.CurrentRow.Cells["Sexo"].Value.ToString());
                        objetoCT.Situacao = Convert.ToBoolean(dataGridView1.CurrentRow.Cells["Situacao"].Value.ToString());
                        objetoCT.Cpf = dataGridView1.CurrentRow.Cells["Cpf"].Value.ToString();
                        objetoCT.DataNascimento = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["DataNascimento"].Value.ToString());
                        CN_Professor objetoCN = new CN_Professor();
                        string retorno = objetoCN.Excluir(objetoCT);
                        ExibirConsulta();

                    try
                    {
                       
                        int IdProfessor = Convert.ToInt32(retorno);
                        MessageBox.Show($"Excluido com sucesso  {nomeProfessor} com id {IdProfessor} ");
                       

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
        //botao de consultar a fixa de cadastro
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Professor foi selecionado.", "Consultar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            nomeProfessor = dataGridView1.CurrentRow.Cells["Nome"].Value.ToString();
            MessageBox.Show("Você Selecionou o Usuario " + nomeProfessor);


            Professor professorSelecionado = new Professor();                       
                      professorSelecionado.IdProfessor = Convert.ToInt32(dataGridView1.CurrentRow.Cells["idProfessor"].Value.ToString());
                      professorSelecionado.Nome = dataGridView1.CurrentRow.Cells["Nome"].Value.ToString();
                      professorSelecionado.Endereco = dataGridView1.CurrentRow.Cells["Endereco"].Value.ToString();
                      professorSelecionado.NumeroEndereco = dataGridView1.CurrentRow.Cells["NumeroEndereco"].Value.ToString();
                      professorSelecionado.Bairro = dataGridView1.CurrentRow.Cells["Bairro"].Value.ToString();
                      professorSelecionado.Cidade = dataGridView1.CurrentRow.Cells["Cidade"].Value.ToString();
                      professorSelecionado.Cep = dataGridView1.CurrentRow.Cells["Cep"].Value.ToString();
                      professorSelecionado.Estado = dataGridView1.CurrentRow.Cells["Estado"].Value.ToString();
                      professorSelecionado.Telefone = dataGridView1.CurrentRow.Cells["Telefone"].Value.ToString();
                      professorSelecionado.CodigoProfessor = dataGridView1.CurrentRow.Cells["CodigoProfessor"].Value.ToString();
                      professorSelecionado.Disponibilidade = Convert.ToBoolean(dataGridView1.CurrentRow.Cells["Disponibilidade"].Value.ToString());
                      professorSelecionado.Sexo = Convert.ToBoolean(dataGridView1.CurrentRow.Cells["Sexo"].Value.ToString());
                      professorSelecionado.Situacao = Convert.ToBoolean(dataGridView1.CurrentRow.Cells["Situacao"].Value.ToString());
                      professorSelecionado.Cpf = dataGridView1.CurrentRow.Cells["Cpf"].Value.ToString();
                      professorSelecionado.DataNascimento = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["DataNascimento"].Value.ToString());
                     // professorSelecionado.DataCadastro = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["DataCadastro"].Value.ToString());
                      //professorSelecionado.DataAlteracao = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["DataAlteracao"].Value.ToString());
            /*
           foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
           {                 
               professorSelecionado = (dataGridView1.SelectedRows[0].DataBoundItem as Professor);
           }*/

            ProfessorConsulta frmprofessorConsulta = new ProfessorConsulta(professorSelecionado);
          
            DialogResult dialog = frmprofessorConsulta.ShowDialog();
            if (dialog == DialogResult.Yes)
            {
                ExibirConsulta();
            }

        }
        //filtro de pesqusia da barra
        private void btnFiltroConsulta_Click(object sender, EventArgs e)
        {
            CN_Professor consultar = new CN_Professor();

            if (radioSituaAtivo.Checked == true && radioConsulId.Checked == true)
            {
                dataGridView1.DataSource = consultar.ConsultarPorIdStiuacao(txtConsulta.Text, Convert.ToString(1));
            }

            if (radioConsultNome.Checked == true)
            {
                dataGridView1.DataSource = consultar.ConsultarPorNome(txtConsulta.Text);
            }
            else if (radioConsulId.Checked == true)
            {
                dataGridView1.DataSource = consultar.ConsultarPorId(txtConsulta.Text);
            }
            else if (radioConsulCodi.Checked == true)
            {
                dataGridView1.DataSource = consultar.ConsultarPorCodigo(txtConsulta.Text);
            }
            else if (radioSituaTodos.Checked == true)
            {
                dataGridView1.DataSource = consultar.ConsultarProfessor();
            }
            else if (radioSituaAtivo.Checked == true)
            {
                dataGridView1.DataSource = consultar.ConsultarPorSituacao(Convert.ToString(1));
            }
            else if (radioSituaDes.Checked == true)
            {
                dataGridView1.DataSource = consultar.ConsultarPorSituacao(Convert.ToString(0));
            }

          /*  Professor professorSelecionado = new Professor();
            professorSelecionado.IdProfessor = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IdProfessor"].Value.ToString());
            professorSelecionado.Nome = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            professorSelecionado.Endereco = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            professorSelecionado.Numero = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            professorSelecionado.Bairro = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            professorSelecionado.Cidade = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            professorSelecionado.Cep = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            professorSelecionado.Estado = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            professorSelecionado.Telefone = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            professorSelecionado.CodigoProfessor = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            professorSelecionado.Disponibilidade = Convert.ToBoolean(dataGridView1.CurrentRow.Cells[11].Value.ToString());
            professorSelecionado.Sexo = Convert.ToBoolean(dataGridView1.CurrentRow.Cells[13].Value.ToString());
            professorSelecionado.Situacao = Convert.ToBoolean(dataGridView1.CurrentRow.Cells[14].Value.ToString());
            professorSelecionado.Cpf = dataGridView1.CurrentRow.Cells[15].Value.ToString();
            professorSelecionado.DataNascimento = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[16].Value.ToString());
            */
        }

       
    }
}
