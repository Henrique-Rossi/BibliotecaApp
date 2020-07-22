using CamadaTransferencia;
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
    public partial class ExternoConsulta : Form
    {
        public ExternoConsulta()
        {
            InitializeComponent();
        }

        string SexoCheck;
        bool situacao;
        bool disponibilidade;

        Externo original = new Externo();
        public ExternoConsulta(Externo externo)
        {
            InitializeComponent();

            original = externo;


            labelId.Text = Convert.ToString(externo.IdExterno);
            TextBoxNome.Text = externo.Nome.ToString();          
            maskedTextBoxCpf.Text = externo.Cpf;
            textBoxDesc.Text = externo.Descricao;
            comboBoxCidade.Text = externo.Cidade;
            comboBoxEstado.Text = externo.Estado;
            txtEnde.Text = externo.Endereco;
            numericUpDown1.Value =Convert.ToInt32( externo.Numero);
            comboBoxBairro.Text = externo.Bairro;
            txtComp.Text = externo.Complemento;
            dateTimePicker1.Value = externo.DataNascimento;
            mtxtTel.Text = externo.Telefone;
            textBoxEmail.Text = externo.Email;
            comboBoxPAis.Text = externo.Pais;
            //textBox2.Text = Convert.ToString(externo.Id_FuncionarioCadastro);
            textBox2.Text = externo.Funcionarios.IdFuncionario.ToString();
            textBox1.Text =externo.Funcionarios.Nome.ToString();
            comboBoxCep.Text = externo.Cep;
            labelCadastro.Text =Convert.ToString(externo.DataCadastro);
            labelAlteracao.Text= Convert.ToString(externo.DataAlteracao);

            if (SexoCheck == "M")
            {

                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }



            situacao = externo.Situacao;
            if (situacao == true)
            {
                radioButton3.Checked = true;
            }
            else
            {
                radioButton4.Checked = true;
            }
           

            disponibilidade = externo.Disponibilidade;
            if (disponibilidade == true)
            {
                radioButton6.Checked = true;
            }
            else
            {
                radioButton5.Checked = true;
            }
            
        }

        private void labelId_Click(object sender, EventArgs e)
        {

        }
    }
}
