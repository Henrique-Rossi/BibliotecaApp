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
    public partial class AlunoAdd : Form
    {
        public AlunoAdd()
        {
            InitializeComponent();
            AtualizaComboBoxEstado("11");
                             
        }
        Utilidades utilidades = new Utilidades();
      
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {

                Aluno objetoCT = new Aluno();
               
                objetoCT.IdAluno = 0;
                objetoCT.Nome = TextBoxNome.Text;
                bool SexoCheck;
                if (radioButton1.Checked)
                {
                    SexoCheck = true;
                }
                else
                {
                    SexoCheck = false;
                }
                objetoCT.Sexo= SexoCheck;
                objetoCT.Matricula =Convert.ToString(numericMatricula.Value);
                objetoCT.Turma = textBoxTurma.Text;
                objetoCT.Turno = comboBox1.Text;
                objetoCT.Grau = textBoxGrau.Text;
                objetoCT.Cpf = maskedTextBoxCpf.Text;
                objetoCT.Descricao = textBoxDesc.Text;
                objetoCT.Cidade = comboBoxCidade.Text;
                objetoCT.Estado = ComboBoxEstado.Text;
                objetoCT.Endereco = txtEnde.Text;
                objetoCT.Numeroend= Convert.ToInt32(numericUpDown1.Value);
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




                CN_Alunos objetoCN = new CN_Alunos();

                string retorno = objetoCN.CadastrarAluno(objetoCT);
                try
                {
                    int IdAluno = Convert.ToInt32(retorno);
                    MessageBox.Show($"Cadastrado com sucesso  {TextBoxNome.Text} com id {IdAluno} ");
                    utilidades.LimpaCampos(this.panel1.Controls);

                    //this.Close();

                }
                catch (FormatException)
                {
                    MessageBox.Show($"Não foi possivel cadastrar por {retorno}{MessageBoxButtons.OK}");
                    throw;
                }
            }
            catch (Exception )
            {
              //  MessageBox.Show("Não foi possivel inserir  ");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
//COMBOBOX CIDADDE;ESTADO
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

        private void ComboBoxEstado_Leave(object sender, EventArgs e)
        {
            try
            {
                string txt = ComboBoxEstado.Text;
                if (String.IsNullOrWhiteSpace(txt) || ComboBoxEstado.FindStringExact(txt) < 0)
                {
                    this.ComboBoxEstado.SelectedIndex = -1;
                    if (ComboBoxEstado.Items.Count > 0)
                        this.ComboBoxEstado.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro. " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void comboBoxCidade_Leave(object sender, EventArgs e)
        {
            try
            {
                string txt = comboBoxCidade.Text;
                if (String.IsNullOrWhiteSpace(txt) || comboBoxCidade.FindStringExact(txt) < 0)
                {
                    this.comboBoxCidade.SelectedIndex = -1;
                    if (comboBoxCidade.Items.Count > 0)
                        this.comboBoxCidade.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro. " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
