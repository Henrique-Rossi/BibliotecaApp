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
    public partial class EmprestimosExternosPainel : Form
    {
        public EmprestimosExternosPainel()
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
            if (UserLoginCache.Renovacao == false)
            {
                btnRenova.Visible = false;
            }
        }

        public void Atualizatudo()
        {
            MostrarEmprestimos();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (Convert.ToString(dataGridView1.Rows[i].Cells["Descricao"].Value) == "Em Andamento" && (Convert.ToDateTime(dataGridView1.Rows[i].Cells["DataSaida"].Value) < Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"))))
                {
                    EmprestimoExternos objetoCT = new EmprestimoExternos
                    {
                        IdEmprestimo = Convert.ToInt32(dataGridView1.Rows[i].Cells["IdEmprestimo"].Value),//pega o valor do id emp

                    };

                    CN_EmprestimoExternos objetoCN = new CN_EmprestimoExternos();
                    objetoCN.AtualizaDataVencimento(objetoCT);
                }
            }

        }



        public void MostrarEmprestimos()
        {
            CN_EmprestimoExternos objeto = new CN_EmprestimoExternos();
            dataGridView1.DataSource = objeto.MostrarEmprestimos();
        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            new EmprestimosExternosAdd().ShowDialog();
            MostrarEmprestimos();
        }

        private void btnDevolu_Click(object sender, EventArgs e)
        {
            new EmprestimoExternosDevo().ShowDialog();
            MostrarEmprestimos();
         }

        private void btnRenova_Click(object sender, EventArgs e)
        {
            new EmprestimosExternosRenova().ShowDialog();
            MostrarEmprestimos();
        }
       
        private void EmprestimosExternosPainel_Load(object sender, EventArgs e)
        {
            MostrarEmprestimos();
            labelQuantidade.Text = "Resultado da Pesquisa: " + dataGridView1.RowCount + " Registro(s)";
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {        
            if (e.Value != null && e.Value.Equals("Vencido"))
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.FromArgb(170, 42, 42);
            }
            if (e.Value != null && e.Value.Equals("Finalizado"))
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.FromArgb(68, 141, 52);
            }
        }


    }
}
