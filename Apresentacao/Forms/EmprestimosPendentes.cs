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
    public partial class EmprestimosPendentes : Form
    {
        public EmprestimosPendentes()
        {
            InitializeComponent();
        }
        public void MostrarEmprestimos()
        {
            CN_EmprestimoProfessor objeto = new CN_EmprestimoProfessor();
            dataGridView1.DataSource = objeto.MostrarEmprestimos();
        }
        private void EmprestimosPendentes_Load(object sender, EventArgs e)
        {
            MostrarEmprestimos();
        }
    }
}
