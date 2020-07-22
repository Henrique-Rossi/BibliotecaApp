using CamadaTransferencia;
using Domain;
using SqlMs.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewUser.Cache;

namespace SqlMs
{
    public partial class EmprestimoAlunoPainel : Form
    {
        
        
        public EmprestimoAlunoPainel()
        {
            InitializeComponent();
            if (UserLoginCache.Emprestimos == false)
            {
                btnAdicionar.Visible = false;              
            }
            if (UserLoginCache.Devolucao == false)
            {
                btnDevolu.Visible = false;
            }
            if (UserLoginCache.Renovacao==false)
            {
                btnReno.Visible = false;
            }
        }
        public void MostrarEmprestimos()
        {
            CN_EmprestimoAluno objeto = new CN_EmprestimoAluno();
            dataGridView1.DataSource = objeto.MostrarEmprestimosOrdem(0);        
        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            new EmprestimoAlunoAdd().ShowDialog();
            MostrarEmprestimos();
        }

        private void EmprestimoAlunoPainel_Load(object sender, EventArgs e)
        {
          
            MostrarEmprestimos();
            labelQuantidade.Text= "Resultado da Pesquisa: " + dataGridView1.RowCount + " Registro(s)";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new EmprestimoAlunoDevo().ShowDialog();
            MostrarEmprestimos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new EmprestimoAlunoRenova().ShowDialog();
            MostrarEmprestimos();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            

            if (e.Value != null && e.Value.Equals("Vencido"))
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.FromArgb(170, 42, 42);
            }
            if (e.Value != null && e.Value.Equals("Finalizado"))
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.FromArgb(68, 89, 61);
            }
            
        }

       /* private void timer1_Tick(object sender, EventArgs e)
        {
            
           for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (Convert.ToString( dataGridView1.Rows[i].Cells["Descricao"].Value) == "Em Andamento"  && (Convert.ToDateTime(dataGridView1.Rows[i].Cells["Column4"].Value) < Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"))))
                {


                    EmprestimoAluno objetoCT = new EmprestimoAluno
                    {
                        IdEmprestimo = Convert.ToInt32(dataGridView1.Rows[i].Cells["IdEmprestimo"].Value),//pega o valor do id emp
                      
                    };

                    CN_EmprestimoAluno objetoCN = new CN_EmprestimoAluno();
                    objetoCN.AtualizaDataVencimento(objetoCT);


                }            
            }
            //timer1.Enabled = false;
            //MostrarEmprestimos();
          }*/
        public void Atualizatudo()
        {
            MostrarEmprestimos();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (Convert.ToString(dataGridView1.Rows[i].Cells["Descricao"].Value) == "Em Andamento" && (Convert.ToDateTime(dataGridView1.Rows[i].Cells["DataSaida"].Value) < Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"))))
                {                  
                    EmprestimoAluno objetoCT = new EmprestimoAluno
                    {
                        IdEmprestimo = Convert.ToInt32(dataGridView1.Rows[i].Cells["idEmprestimo"].Value),//pega o valor do id emp

                    };

                    CN_EmprestimoAluno objetoCN = new CN_EmprestimoAluno();
                    objetoCN.AtualizaDataVencimento(objetoCT);
                }
            }
           
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum usuario foi selecionado.", "Consultar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
          
           
            
            EmprestimoAluno objetoCT = new EmprestimoAluno();
            Aluno aluno = new Aluno();
            Livro livro = new Livro();
                objetoCT.IdEmprestimo = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IdEmprestimo"].Value.ToString());
                aluno.Nome= dataGridView1.CurrentRow.Cells["Nome"].Value.ToString();
              
                livro.Nome_Livro = dataGridView1.CurrentRow.Cells["Nome_livro"].Value.ToString();
                objetoCT.IdSituacao = Convert.ToInt32(dataGridView1.CurrentRow.Cells["idSituacao"].Value.ToString());
                objetoCT.DataAtual = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["DataAtual"].Value.ToString());
                objetoCT.DataEntregou = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["DataEntregou"].Value.ToString());
                objetoCT.DataProcesso = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["DataProcesso"].Value.ToString());
                objetoCT.DataSaida = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["DataSaida"].Value.ToString());
                //objetoCT.Id_FuncionarioCadastro= Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id_FuncionarioCadastro"].Value.ToString());
            aluno.IdAluno= Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id_Aluno"].Value.ToString());
            string func= dataGridView1.CurrentRow.Cells["NomeF"].Value.ToString();

            EmprestimoAlunoConsu frmprofessorConsulta = new EmprestimoAlunoConsu(objetoCT,aluno,livro,func);

            DialogResult dialog = frmprofessorConsulta.ShowDialog();
            
              
        }

      

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            MostrarEmprestimos();
        }
        CN_EmprestimoAluno emprestimo = new CN_EmprestimoAluno();
        private void EmAndamento_CheckedChanged(object sender, EventArgs e)
        {
           
            dataGridView1.DataSource = emprestimo.MostrarEmprestimosOrdem(1);
            labelQuantidade.Text = "Resultado da Pesquisa: " + dataGridView1.RowCount + " Registro(s)";
        }

        private void Vencidos_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = emprestimo.MostrarEmprestimosOrdem(2);
            labelQuantidade.Text = "Resultado da Pesquisa: " + dataGridView1.RowCount + " Registro(s)";
        }

        private void Finalizados_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = emprestimo.MostrarEmprestimosOrdem(3);
            labelQuantidade.Text = "Resultado da Pesquisa: " + dataGridView1.RowCount + " Registro(s)";
        }

        

        private void btnFiltroConsulta_Click(object sender, EventArgs e)
        {//--Nomes      
            if (radioConsultNome.Checked == true && Vencidos.Checked==true)
            {
                dataGridView1.DataSource = emprestimo.MostrarEmprestimosOrdemNome(5,txtConsulta.Text);
            }
            if (radioConsultNome.Checked == true && Finalizados.Checked == true)
            {
                dataGridView1.DataSource = emprestimo.MostrarEmprestimosOrdemNome(6,txtConsulta.Text);
            }
            if (radioConsultNome.Checked == true && EmAndamento.Checked == true)
            {
                dataGridView1.DataSource = emprestimo.MostrarEmprestimosOrdemNome(4,txtConsulta.Text);
            }


        //--Matricula
            if (radioConsulCodi.Checked==true && EmAndamento.Checked==true)
            {
                dataGridView1.DataSource = emprestimo.MostrarEmprestimosOrdemNome(7, txtConsulta.Text);
            }
            if (radioConsulCodi.Checked == true && Vencidos.Checked == true)
            {
                dataGridView1.DataSource = emprestimo.MostrarEmprestimosOrdemNome(8, txtConsulta.Text);
            }
            if (radioConsulCodi.Checked == true && Finalizados.Checked == true)
            {
                dataGridView1.DataSource = emprestimo.MostrarEmprestimosOrdemNome(9, txtConsulta.Text);
            }


         //--Livro
            if (rbLivro.Checked == true && EmAndamento.Checked == true)
            {
                dataGridView1.DataSource = emprestimo.MostrarEmprestimosOrdemNome(12, txtConsulta.Text);
            }
            if (rbLivro.Checked == true && Vencidos.Checked == true)
            {
                dataGridView1.DataSource = emprestimo.MostrarEmprestimosOrdemNome(13, txtConsulta.Text);
            }
            if (rbLivro.Checked == true && Finalizados.Checked == true)
            {
                dataGridView1.DataSource = emprestimo.MostrarEmprestimosOrdemNome(14, txtConsulta.Text);
            }


        //--CodigoLivro
            if (rbCodLivro.Checked == true && EmAndamento.Checked == true)
            {
                dataGridView1.DataSource = emprestimo.MostrarEmprestimosOrdemNome(15, txtConsulta.Text);
            }
            if (rbCodLivro.Checked == true && Vencidos.Checked == true)
            {
                dataGridView1.DataSource = emprestimo.MostrarEmprestimosOrdemNome(16, txtConsulta.Text);
            }
            if (rbCodLivro.Checked == true &&  Finalizados.Checked == true)
            {
                dataGridView1.DataSource = emprestimo.MostrarEmprestimosOrdemNome(17, txtConsulta.Text);
            }

        

            //--Apenas nome
            if (radioConsultNome.Checked == true && radioButton1.Checked==true)
            {
                dataGridView1.DataSource = emprestimo.MostrarEmprestimosOrdemNome(10, txtConsulta.Text);
            }
        //--Apenas matricula
            if (radioConsulCodi.Checked == true && radioButton1.Checked == true)
            {
                dataGridView1.DataSource = emprestimo.MostrarEmprestimosOrdemNome(11, txtConsulta.Text);
            }
            //apenas livro
            if(rbLivro.Checked == true && radioButton1.Checked == true)
            {
                dataGridView1.DataSource = emprestimo.MostrarEmprestimosOrdemNome(19, txtConsulta.Text);
            }
            //codigo lvro
            if (rbCodLivro.Checked == true && radioButton1.Checked == true)
            {
                dataGridView1.DataSource = emprestimo.MostrarEmprestimosOrdemNome(18, txtConsulta.Text);
            }
            //emp
            if (radioEmp.Checked == true && radioButton1.Checked == true)
            {
                dataGridView1.DataSource = emprestimo.MostrarEmprestimosOrdemNome(20, txtConsulta.Text);
            }

            labelQuantidade.Text = "Resultado da Pesquisa: " + dataGridView1.RowCount + " Registro(s)";
        }


    }
}
