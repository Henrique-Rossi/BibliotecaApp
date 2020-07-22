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
    public partial class EmprestimoAlunoRenova : Form
    {
        public EmprestimoAlunoRenova()
        {
            InitializeComponent();
        }
        int idAlunos;
        int idEmprestimo;
       
        //exibir nomes que estao com emprestimos pendentes 
        public void ExibirConsultaAluno()
        {
            CN_EmprestimoAluno objeto = new CN_EmprestimoAluno();
            dataGridViewAluno.DataSource = objeto.ConsultaralunosDevolu();

        }


        //exibe os dados   dos emprestimos do usuario selecionado 
        public void MostrarEmprestimoUnico()
        {
            CN_EmprestimoAluno objeto = new CN_EmprestimoAluno();
            dataGridViewLista.DataSource = objeto.MostrarEmprestimoUnicoRenovacao(idAlunos);
        }

        private void EmprestimoAlunoRenova_Load(object sender, EventArgs e)
        {
            ExibirConsultaAluno();
        }

        private void dataGridViewAluno_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var Row = dataGridViewAluno.CurrentRow;

            idAlunos = Convert.ToInt32(Row.Cells["idAluno"].Value);//pega o valor do id 

            MostrarEmprestimoUnico();
        }


      

        private void buttonDevolver_Click(object sender, EventArgs e)
        {
            string messagem = $"Tem Certeza que deseja Executar a Renovação ,do livro {dataGridViewLista.CurrentRow.Cells["Nome_Livro"].Value.ToString()} ?";
            string captionn = "Alerta";
            MessageBoxButtons buttonss = MessageBoxButtons.YesNo;
            DialogResult resultt;

            resultt = MessageBox.Show(messagem, captionn, buttonss);
            if (resultt == System.Windows.Forms.DialogResult.Yes)
            {

                idEmprestimo = Convert.ToInt32(dataGridViewLista.CurrentRow.Cells["IdEmprestimo"].Value);//pega o valor do id emp               
                ExecutarRenovacao();
                MessageBox.Show(" Renovação efetuada com sucesso");
              /*  if (dataGridViewLista.RowCount < 1)
                {
                    ExibirConsultaAluno();//erro por causa da manipulação do datatable
                }
                */
                MostrarEmprestimoUnico();
            }
        }
        public void ExecutarRenovacao()
        {
            CN_EmprestimoAluno objeto = new CN_EmprestimoAluno();
            dataGridViewLista.DataSource = objeto.ExecutarRenovacao(idEmprestimo);
            MostrarEmprestimoUnico();
        }

       
    }
}
