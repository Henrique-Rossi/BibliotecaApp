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
    public partial class ExternoAdd : Form
    {
        public ExternoAdd()
        {
            InitializeComponent();
            AtualizaComboBoxEstado("11");
        }
        Utilidades utilidades = new Utilidades();
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {

                Externo objetoCT = new Externo();

                objetoCT.IdExterno = 0;
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
                objetoCT.Sexo = SexoCheck;            
                objetoCT.Cpf = maskedTextBoxCpf.Text;
                objetoCT.Descricao = textBoxDesc.Text;
                objetoCT.Cidade = comboBoxCidade.Text;
                objetoCT.Estado = ComboBoxEstado.Text;
                objetoCT.Endereco = txtEnde.Text;
                objetoCT.Numero = Convert.ToString(numericUpDown1.Value);
                objetoCT.Bairro = comboBoxBairro.Text;
                objetoCT.Complemento = txtComp.Text;
                objetoCT.DataNascimento = dateTimePicker1.Value;
                objetoCT.Telefone = mtxtTel.Text;
                objetoCT.Email = textBoxEmail.Text;
                objetoCT.Id_FuncionarioCadastro = UserLoginCache.Id_Funcionario;
                objetoCT.Pais = comboBoxPAis.Text;
                objetoCT.Cep = comboBoxCep.Text;


              



                CN_Externos objetoCN = new CN_Externos();

                string retorno = objetoCN.CadastrarExterno(objetoCT);
                try
                {
                    int Idexterno = Convert.ToInt32(retorno);
                    MessageBox.Show($"Cadastrado com sucesso  {TextBoxNome.Text} com id {Idexterno} ");
                    utilidades.LimpaCampos(this.panel1.Controls);

                    //this.Close();

                }
                catch (FormatException)
                {
                    MessageBox.Show($"Não foi possivel cadastrar por {retorno}{MessageBoxButtons.OK}");
                    throw;
                }
            }
            catch (Exception ex)
            {
               // MessageBox.Show("Não foi possivel inserir  por: " + ex);
            }
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    
}
