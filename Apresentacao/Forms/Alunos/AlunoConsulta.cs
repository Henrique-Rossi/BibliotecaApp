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
using ViewUser.Cache;

namespace SqlMs.Forms
{
    public partial class AlunoConsulta : Form
    {
        public AlunoConsulta()
        {
            InitializeComponent();
        }
        bool SexoCheck;
        bool situacao;
        bool disponibilidade;
       

            

        public AlunoConsulta(Aluno aluno,string nomef)
        {
            InitializeComponent();
           

            labelMatricula.Text = Convert.ToString(aluno.Matricula);
            TextBoxNome.Text = aluno.Nome;
            numericMatricula.Value = Convert.ToInt32(aluno.Matricula);
            textBoxTurma.Text = aluno.Turma;
            comboBox1.Text = aluno.Turno;
            textBoxGrau.Text = aluno.Grau;
            maskedTextBoxCpf.Text = aluno.Cpf;
            textBoxDesc.Text = aluno.Descricao;
            comboBoxCidade.Text = aluno.Cidade;
            comboBoxEstado.Text = aluno.Estado;
            txtEnde.Text = aluno.Endereco;
            numericUpDown1.Value = aluno.Numeroend;
            comboBoxBairro.Text = aluno.Bairro;
            txtComp.Text = aluno.Complemento;
            dateTimePicker1.Value = aluno.DataNascimento;
            mtxtTel.Text = aluno.Telefone;
            textBoxEmail.Text = aluno.Email;
            labelCadastro.Text =Convert.ToString(aluno.DataCadastro);
            labelAlteracao.Text = Convert.ToString(aluno.DataAlteracao);
            maskedTextBoxresposavel.Text = aluno.TelefoneResponsavel;
            comboBoxCep.Text = aluno.Cep;
            SexoCheck = aluno.Sexo;
            if (SexoCheck == true)
            {

                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }
            textBox2.Text = Convert.ToString(aluno.Id_FuncionarioCadastro);
            textBox1.Text = nomef;

            situacao = aluno.Situacao;
            if (situacao == true)
            {
                radioButton3.Checked = true;
            }
            else
            {
                radioButton4.Checked = true;
            }
            //passar disponibilidde por aqi para nao afetar depois na hora de alterar

            disponibilidade = aluno.Disponibilidade;
            if (disponibilidade == true)
            {
                radioButton6.Checked = true;
            }
            else
            {
                radioButton5.Checked = true;
            }
          

        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
