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
    public partial class EmprestimoRenovacao : Form
    {
        public EmprestimoRenovacao()
        {
            InitializeComponent();
        }
        int idProfessor;
        int idEmprestimo;
       // int idLivro;
        public void ExibirConsultaProfessor()
        {
            CN_EmprestimoProfessor objeto = new CN_EmprestimoProfessor();
            dataGridViewProfessor.DataSource = objeto.MostrarUsuarioPendentesDevolucao();

        }
       /* public void MostrarEmprestimosGeral()
        {
            CN_EmprestimoProfessor objeto = new CN_EmprestimoProfessor();
            dataGridViewLista.DataSource = objeto.MostrarEmprestimos();
        }
        */
        public void MostrarEmprestimoUnico()
        {
            CN_EmprestimoProfessor objeto = new CN_EmprestimoProfessor();
            dataGridViewLista.DataSource = objeto.MostrarEmprestimoUnico(idProfessor);
        }

        private void EmprestimoRenovacao_Load(object sender, EventArgs e)
        {
            ExibirConsultaProfessor();
        }

        private void dataGridViewProfessor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var Row = dataGridViewProfessor.CurrentRow;

            idProfessor = Convert.ToInt32(Row.Cells[0].Value);//pega o valor do id 

            MostrarEmprestimoUnico();
        }
        public void ExecutarRenovacao()
        {
            CN_EmprestimoProfessor objeto = new CN_EmprestimoProfessor();
            dataGridViewLista.DataSource = objeto.ExecutarRenovacao(idEmprestimo);
        }

        private void dataGridViewLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idEmprestimo = Convert.ToInt32(dataGridViewLista.CurrentRow.Cells["IdEmprestimo"].Value);//pega o valor do id emp

            ExecutarRenovacao();
        }

        private void buttonRenovar_Click(object sender, EventArgs e)
        {
            string messagem = $"Tem Certeza que deseja Executar a Renovação ,do livro {dataGridViewLista.CurrentRow.Cells["NomeLivro"].Value.ToString()} ?";
            string captionn = "Alerta";
            MessageBoxButtons buttonss = MessageBoxButtons.YesNo;
            DialogResult resultt;

            resultt = MessageBox.Show(messagem, captionn, buttonss);
            if (resultt == System.Windows.Forms.DialogResult.Yes)
            {

                idEmprestimo = Convert.ToInt32(dataGridViewLista.CurrentRow.Cells["IdEmprestimo"].Value);//pega o valor do id emp               
                ExecutarRenovacao();
                MessageBox.Show(" Renovação efetuada com sucesso");
            }
        }
    }
}
