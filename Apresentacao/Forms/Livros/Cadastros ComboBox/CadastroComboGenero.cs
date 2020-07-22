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
    public partial class CadastroComboGenero : Form
    {
        public CadastroComboGenero()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CN_Livros cN_Livros = new CN_Livros();
            cN_Livros.CadatrarGenero(comboBox1.Text);
            this.Close();
        }
    }
}
