using AcessoBancoDados;
using CamadaTransferencia;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewUser.Cache;

namespace SqlMs
{
    public partial class AlunoEditar : Form
    {
        public  AlunoEditar()
        {
            InitializeComponent();
            AtualizaComboBoxEstado("11");
        }

        public void AtualizaComboBoxEstado(string estado)
        {
            try
            {
                CN_Estado estadoRegraNegocio = new CN_Estado();
                DataTable dataTable = estadoRegraNegocio.ComboBoxEstado();
                ComboBoxEstado.DropDownStyle = ComboBoxStyle.DropDown;
                ComboBoxEstado.DataSource = dataTable;
                ComboBoxEstado.ValueMember = "Codigo";
                ComboBoxEstado.DisplayMember = "Sigla";
                if (estado != null)
                {
                    ComboBoxEstado.SelectedValue = Convert.ToInt32(estado);
                    ComboBoxEstado.Update();
                    AtualizarComboCidade(Convert.ToString(ComboBoxEstado.SelectedValue));
                }
                else
                {
                    comboBoxCidade.Update();
                    AtualizarComboCidade(Convert.ToString(ComboBoxEstado.SelectedValue));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro. Detalhes: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void AtualizarComboCidade(string cidade)
        {
            try
            {
                CN_Cidade cidadeRegraNegocio = new CN_Cidade();
                DataTable dataTable = cidadeRegraNegocio.ComboBoxCidade(cidade);
                comboBoxCidade.DropDownStyle = ComboBoxStyle.DropDown;
                comboBoxCidade.DataSource = dataTable;
                comboBoxCidade.ValueMember = "Codigo";
                comboBoxCidade.DisplayMember = "Nome";
                comboBoxCidade.Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro. Detalhes: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        bool SexoCheck;
        bool situacao;
        bool disponibilidade;
        public void ExibirDados(Aluno aluno)
        {
            labelId.Text                        = Convert.ToString(aluno.IdAluno);
            TextBoxNome.Text                    = aluno.Nome;
            numericMatricula.Value              = Convert.ToInt32(aluno.Matricula);
            textBoxTurma.Text                   = aluno.Turma;
            comboBox1.Text                      = aluno.Turno;
            textBoxGrau.Text                    = aluno.Grau;
            maskedTextBoxCpf.Text               = aluno.Cpf ;
            textBoxDesc.Text                    = aluno.Descricao ;
            comboBoxCidade.Text                 = aluno.Cidade  ;
            ComboBoxEstado.Text                 = aluno.Estado  ;
            //ComboBoxEstado.SelectedValue = Convert.ToInt32(aluno.Cidade.Estado.Codigo);
           // comboBoxCidade.SelectedValue = Convert.ToInt32(aluno.Cidade.Codigo);
            txtEnde.Text                        = aluno.Endereco ;
            numericUpDown1.Value                = aluno.Numeroend;
            comboBoxBairro.Text                 = aluno.Bairro;
            txtComp.Text                        = aluno.Complemento ;
            dateTimePicker1.Value               = aluno.DataNascimento ;
            mtxtTel.Text                        = aluno.Telefone ;
            textBoxEmail.Text                   = aluno.Email ;
            UserLoginCache.Id_Funcionario       = aluno.Id_FuncionarioCadastro;
            maskedTextBoxresposavel.Text        = aluno.TelefoneResponsavel ;
            comboBoxCep.Text                    = aluno.Cep;
            SexoCheck = aluno.Sexo;
            if (SexoCheck == true)
            {

                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }



           situacao = aluno.Situacao;
           if (situacao== true)
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


      

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

            string messagem = "Tem Certeza que deseja Executar essas Alterações ?";
            string captionn = "Alerta";
            MessageBoxButtons buttonss = MessageBoxButtons.YesNo;
            DialogResult resultt;

            resultt = MessageBox.Show(messagem, captionn, buttonss);
            if (resultt == System.Windows.Forms.DialogResult.Yes)
            {

                Aluno objetoCT = new Aluno();

                objetoCT.IdAluno = Convert.ToInt32(labelId.Text);
                objetoCT.Nome = TextBoxNome.Text;

                objetoCT.Sexo = radioButton1.Checked;
                objetoCT.Matricula = Convert.ToString(numericMatricula.Value);
                objetoCT.Turma = textBoxTurma.Text;
                objetoCT.Turno = comboBox1.Text;
                objetoCT.Grau = textBoxGrau.Text;
                objetoCT.Cpf = maskedTextBoxCpf.Text;
                objetoCT.Descricao = textBoxDesc.Text;
                objetoCT.Cidade = comboBoxCidade.Text;
                objetoCT.Estado = ComboBoxEstado.Text;
                objetoCT.Endereco = txtEnde.Text;
                objetoCT.Numeroend = Convert.ToInt32(numericUpDown1.Value);
                objetoCT.Bairro = comboBoxBairro.Text;
                objetoCT.Complemento = txtComp.Text;
                objetoCT.DataNascimento = dateTimePicker1.Value;
                objetoCT.Telefone = mtxtTel.Text;
                objetoCT.Email = textBoxEmail.Text;
                objetoCT.Id_FuncionarioCadastro = UserLoginCache.Id_Funcionario;
                objetoCT.TelefoneResponsavel = maskedTextBoxresposavel.Text;
                objetoCT.Cep = comboBoxCep.Text;

                //objetoCT.DataNascimento = DateTime.ParseExact(txtNasc.Text, "dd/MM/yyyy", null);
                objetoCT.DataNascimento = Convert.ToDateTime(dateTimePicker1.Text);

                objetoCT.Situacao = radioButton3.Checked;
                objetoCT.Disponibilidade = radioButton6.Checked;
                CN_Alunos objetoCN = new CN_Alunos();

                string retorno = objetoCN.Alterar(objetoCT);
                try
                {
                    int IdAluno = Convert.ToInt32(retorno);
                    MessageBox.Show($"Alterado  com sucesso  {TextBoxNome.Text} com id {IdAluno} ");


                    //this.Close();

                }
                catch (FormatException)
                {
                    MessageBox.Show($"Não foi possivel cadastrar por {retorno}{MessageBoxButtons.OK}");

                }


            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ComboBoxEstado_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (ComboBoxEstado.SelectedValue != null && ComboBoxEstado.ValueMember != "")
                    AtualizarComboCidade(Convert.ToString(ComboBoxEstado.SelectedValue));
                else
                    return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro. " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
