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
    public partial class EmprestimoDevolucaoProfessor : Form
    {
        public EmprestimoDevolucaoProfessor()
        {
            InitializeComponent();
        }
        int idProfessor;
        int idEmprestimo;
        int idLivro;
        public void ExibirConsultaProfessor()
        {
            CN_EmprestimoProfessor objeto = new CN_EmprestimoProfessor();
            dataGridViewProfessor.DataSource = objeto.MostrarUsuarioPendentesDevolucao();

        }
       /* public void MostrarEmprestimosGeral()
        {
            CN_EmprestimoProfessor objeto = new CN_EmprestimoProfessor();
            dataGridViewLista.DataSource = objeto.MostrarEmprestimos();
        }*/

        public void MostrarEmprestimoUnico()
        {
            CN_EmprestimoProfessor objeto = new CN_EmprestimoProfessor();
            dataGridViewLista.DataSource = objeto.MostrarEmprestimoUnico(idProfessor);
        }
       
        private void EmprestimoDevolucaoProfessor_Load(object sender, EventArgs e)
        {        
            ExibirConsultaProfessor();
        }

        private void dataGridViewProfessor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var Row = dataGridViewProfessor.CurrentRow;

            idProfessor = Convert.ToInt32(Row.Cells["IdProfesso"].Value);//pega o valor do id 
          
            MostrarEmprestimoUnico();
        }


        public void ExecutarDevolucao()
        {
            CN_EmprestimoProfessor objeto = new CN_EmprestimoProfessor();
           // dataGridViewLista.DataSource = objeto.ExecutarDevolucao(idEmprestimo, idLivro ,idProfessor);
        }
        private void dataGridViewLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
            idEmprestimo= Convert.ToInt32(dataGridViewLista.CurrentRow.Cells["IdEmprestimo"].Value);//pega o valor do id emp
            idLivro = Convert.ToInt32(dataGridViewLista.CurrentRow.Cells["IdLivrod"].Value);//pega o valor do id livro
            ExecutarDevolucao();
        }

        private void buttonDevolver_Click(object sender, EventArgs e)
        {
            string messagem = "Tem Certeza que deseja Executar essa Devolução ?" + dataGridViewLista.CurrentRow.Cells["NomeLivro"].Value.ToString(); ;
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
                        EmprestimoProfessor objetoCT = new EmprestimoProfessor
                        {
                            IdEmprestimo = Convert.ToInt32(dataGridViewLista.Rows[i].Cells["IdEmprestimo"].Value),//pega o valor do id emp
                            IdLivro = Convert.ToInt32(dataGridViewLista.Rows[i].Cells["IdLivrod"].Value),//pega o valor do id livro
                            IdProfessor = Convert.ToInt32(dataGridViewLista.Rows[i].Cells["IdProfessor"].Value),

                        };

                        CN_EmprestimoProfessor objetoCN = new CN_EmprestimoProfessor();
                        objetoCN.Devolucao(objetoCT);


                    }
                }
                ExibirConsultaProfessor();
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
    }
}
