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
    public partial class EmprestimosExternosRenova : Form
    {
        public EmprestimosExternosRenova()
        {
            InitializeComponent();
        }
        int idExternos;
        int idEmprestimo;

        //exibir nomes que estao com emprestimos pendentes 
        public void ExibirConsultaExternos()
        {
            CN_EmprestimoExternos objeto = new CN_EmprestimoExternos();
            dataGridViewExternos.DataSource = objeto.ConsultarexternosDevolu();

        }


        //exibe os dados   dos emprestimos do usuario selecionado 
        public void MostrarEmprestimoUnico()
        {
            CN_EmprestimoExternos objeto = new CN_EmprestimoExternos();
            dataGridViewLista.DataSource = objeto.MostrarEmprestimoUnicoRenovacao(idExternos);
        }


        private void EmprestimosExternosRenova_Load(object sender, EventArgs e)
        {
            ExibirConsultaExternos();

        }

        private void dataGridViewExternos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var Row = dataGridViewExternos.CurrentRow;

            idExternos = Convert.ToInt32(Row.Cells[0].Value);//pega o valor do id 

            MostrarEmprestimoUnico();
        }
        public void ExecutarRenovacao()
        {

            CN_EmprestimoExternos objeto = new CN_EmprestimoExternos();
            dataGridViewLista.DataSource = objeto.ExecutarRenovacao(idEmprestimo);
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

                     MostrarEmprestimoUnico();
                }
            
           
        }
    }
}
