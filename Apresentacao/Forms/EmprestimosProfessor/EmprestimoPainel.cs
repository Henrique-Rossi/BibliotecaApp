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

namespace SqlMs.Forms
{
    public partial class EmprestimoPainel : Form
    {
        public EmprestimoPainel()
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
                btnReno.Visible = false;
            }
        }
        public void MostrarEmprestimos()
        {
            CN_EmprestimoProfessor objeto = new CN_EmprestimoProfessor();
            dataGridView1.DataSource = objeto.MostrarEmprestimos();
        }
     


        private void EmprestimoPainel_Load(object sender, EventArgs e)
        {
            MostrarEmprestimos();
            labelQuantidade.Text = "Resultado da Pesquisa: " + dataGridView1.RowCount + " Registro(s)";
        }




 //----------------------------------------------------DEFINIR AS CORES DAS SITUAÇÕES-----------------------------
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //CellFormatting click na função

            if (e.Value != null && e.Value.Equals("Vencido"))
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.FromArgb(170, 42, 42);
            }
            if (e.Value != null && e.Value.Equals("Finalizado"))
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.FromArgb(68, 141, 52);
            }

        }


 //----------------------------------------------------BOTÕES DE CHAMADA -----------------------------
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            new EmprestimoAdd().ShowDialog();
            MostrarEmprestimos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new EmprestimoDevolucaoProfessor().ShowDialog();
            MostrarEmprestimos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new EmprestimoRenovacao().ShowDialog();
        }
    }
}
