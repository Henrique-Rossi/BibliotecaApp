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


namespace SqlMs.Forms
{
    public partial class ProfessorConsulta : Form
    {
        public ProfessorConsulta()
        {
            InitializeComponent();
        }
        bool situacao;
        bool disponibilidade;
        public ProfessorConsulta( Professor professor)
        {
            InitializeComponent();
    

            label6.Text    = professor.Idprofessor.ToString();
            txtNome.Text   = professor.Nome.ToString();
            txtBairro.Text = professor.Bairro.ToString();
            txtCep.Text    = professor.Cep.ToString();
            txtCidade.Text = professor.Cidade.ToString();
            txtCodi.Text   = professor.Codigoprofessor.ToString();
            maskedTextBoxCpf.Text    = professor.Cpf.ToString();
            txtEnde.Text   = professor.Endereco.ToString();
            txtEstado.Text = professor.Estado.ToString();
            dateTimePicker1.Text   = professor.DataNascimento.ToString();
            txtNum.Text    = professor.NumeroEndereco.ToString();
            mtxtTel.Text   = professor.Telefone.ToString();
            labelDataCadastro.Text = professor.DataCadastro.ToString();
            labelDataAlteracao.Text = professor.DataAlteracao.ToString();
            //labelNomeFuncionario.Text = precisa da tranferencia de funcionario
            if (professor.Sexo)
                radioBtnSexoM.Checked = true;
            else
                radioBtnSexoF.Checked = true;
            // return professorOriginal.ToString();
            situacao = professor.Situacao;
            if (situacao == true)
            {
               //radioButton3.Checked = true;
            }
            else
            {
                //radioButton4.Checked = true;
            }


            disponibilidade = professor.Disponibilidade;
            if (disponibilidade == true)
            {
               // radioButton6.Checked = true;
            }
            else
            {
                //radioButton5.Checked = true;
            }
        }

        private void ProfessorConsulta_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
