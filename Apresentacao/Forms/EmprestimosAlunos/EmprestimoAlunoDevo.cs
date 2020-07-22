using AcessoBancoDados;
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
    public partial class EmprestimoAlunoDevo : Form
    {
        public EmprestimoAlunoDevo()
        {
            InitializeComponent();
        }
        
        int idAlunos;
        int idEmprestimo;
        int idLivro;
        //exibir nomes que estao com emprestimos pendentes 
        public void ExibirConsultaAluno()
        {
            CN_EmprestimoAluno objeto = new CN_EmprestimoAluno();
            dataGridViewAluno.DataSource = objeto.ConsultaralunosDevolu();

        }
        private void dataGridViewAluno_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var Row = dataGridViewAluno.CurrentRow;

            idAlunos = Convert.ToInt32(Row.Cells["idAluno"].Value);//pega o valor do id 

            MostrarEmprestimoUnico();
        }

        //exibe os dados   dos emprestimos do usuario selecionado 
        public void MostrarEmprestimoUnico()
        {
            CN_EmprestimoAluno objeto = new CN_EmprestimoAluno();
            dataGridViewLista.DataSource = objeto.MostrarEmprestimoUnico(idAlunos);
            
        }

        private void EmprestimoAlunoDevo_Load(object sender, EventArgs e)
        {
            ExibirConsultaAluno();
        }
      


        private void dataGridViewLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            dataGridViewLista.CurrentRow.Cells["Column1"].Value = false;
            // ExecutarDevolucao();

        }



        private void buttonDevolver_Click(object sender, EventArgs e)
        {        
           
            string messagem = "Tem Certeza que deseja Executar essa Devolução ?" + dataGridViewLista.CurrentRow.Cells["Nome_Livro"].Value.ToString(); ;
            string captionn = "Alerta";
            MessageBoxButtons buttonss = MessageBoxButtons.YesNo;
            DialogResult resultt;

            resultt = MessageBox.Show(messagem, captionn, buttonss);
            if (resultt == System.Windows.Forms.DialogResult.Yes)
            {
              
                int contagem = dataGridViewLista.Rows.Count;
              
                    for (int i = 0; i < contagem; i++)
                    {
                        if (Convert.ToBoolean(dataGridViewLista.Rows[i].Cells["Column1"].Value) == true)
                        {
                            EmprestimoAluno objetoCT = new EmprestimoAluno
                            {
                                IdEmprestimo = Convert.ToInt32(dataGridViewLista.Rows[i].Cells["IdEmprestimo"].Value),//pega o valor do id emp
                                IdLivro = Convert.ToInt32(dataGridViewLista.Rows[i].Cells["Id_Livro"].Value),//pega o valor do id livro
                                Id_Aluno = Convert.ToInt32(dataGridViewLista.Rows[i].Cells["IdAluno"].Value),

                            };

                            CN_EmprestimoAluno objetoCN = new CN_EmprestimoAluno();
                            objetoCN.Devolucao(objetoCT);


                        }
                    }
                ExibirConsultaAluno();
                MostrarEmprestimoUnico();
                checkBox1.Checked = false;

                MessageBox.Show("Devolução efetuada com sucesso");
               
            }
        }

        public void ExecutarDevolucao()
        {
            string messagem = "Tem Certeza que deseja Executar essa Devolução ?" + dataGridViewLista.CurrentRow.Cells["Nome_Livro"].Value.ToString(); ;
            string captionn = "Alerta";
            MessageBoxButtons buttonss = MessageBoxButtons.YesNo;
            DialogResult resultt;

            resultt = MessageBox.Show(messagem, captionn, buttonss);
            if (resultt == System.Windows.Forms.DialogResult.Yes)
            {
                EmprestimoAluno objetoCT = new EmprestimoAluno
                {
                    IdEmprestimo = Convert.ToInt32(dataGridViewLista.CurrentRow.Cells["IdEmprestimo"].Value),//pega o valor do id emp
                    IdLivro = Convert.ToInt32(dataGridViewLista.CurrentRow.Cells["Id_Livro"].Value),//pega o valor do id livro
                    Id_Aluno = Convert.ToInt32(dataGridViewLista.CurrentRow.Cells["IdAluno"].Value),

                };

                CN_EmprestimoAluno objetoCN = new CN_EmprestimoAluno();
                objetoCN.Devolucao(objetoCT);

                ExibirConsultaAluno();
                MostrarEmprestimoUnico();
                checkBox1.Checked = false;

                MessageBox.Show("Devolução efetuada com sucesso");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewLista.SelectAll();
            for (int i = 0; i < dataGridViewLista.Rows.Count; i++)
            {
                dataGridViewLista.Rows[i].Cells["Column1"].Value = true;
            }
        }

        private void dataGridViewLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewLista.CurrentRow.Cells["Column1"].Value = true;
          
        }

       
    }

}
