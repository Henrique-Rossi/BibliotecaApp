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
    public partial class ProfessorEditar : Form 
    {
       public ProfessorEditar()
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

        //Professor original = new Professor();
        public ProfessorEditar(Professor professor)  
        {
            InitializeComponent();
           
           // original = professor;

            label6.Text = Convert.ToString(professor.Idprofessor);
            txtNome.Text=    professor.Nome;
            txtEnde.Text=    professor.Endereco;
            numericUpDown2.Text=     professor.NumeroEndereco;
            comboBoxCidade.Text = professor.Cidade;
            ComboBoxEstado.Text = professor.Estado;
            comboBoxBairro.Text=  professor.Bairro;
            
            comboBoxCep.Text=     professor.Cep;
           
            mtxtTel.Text=    professor.Telefone;
            numericUpDown1.Text=    professor.Codigoprofessor;
            SexoCheck=professor.Sexo;
            if (SexoCheck == true)
            {

                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }
            situacao = professor.Situacao;
            if (situacao == true)
            {

                radiosituaAtivo.Checked = true;
            }
            else
            {
                radioSituaDesativado.Checked = true;
            }
            disponibilidade = professor.Disponibilidade;
            if (disponibilidade == true)
            {

                radioButton3.Checked = true;
            }
            else
            {
                radioButton4.Checked = true;
            }

            maskedTextBoxCpf.Text=     professor.Cpf;
            dateTimePicker1.Text= Convert.ToString(professor.DataNascimento);
            
        }

       
       

       
        


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //aqui exibe as menssagens de dialogo 
            string message = "Tem Certeza que deseja Alterar o Resgistro ?";
            string caption = "Alerta";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {

              //cpf ou codigo altera  se estiver ativo
                    CN_Professor objetoCN = new CN_Professor();
                    Professor objetoCT = new Professor();

                    objetoCT.Idprofessor = Convert.ToInt32(label6.Text);
                    objetoCT.Nome = txtNome.Text;
                    objetoCT.Endereco = txtEnde.Text;
                    objetoCT.NumeroEndereco = numericUpDown2.Text;
                    objetoCT.Bairro = comboBoxBairro.Text;
                    objetoCT.Cidade = comboBoxCidade.Text;
                    objetoCT.Cep = comboBoxCep.Text;
                    objetoCT.Estado = ComboBoxEstado.Text;
                    objetoCT.Telefone = mtxtTel.Text;
                    objetoCT.Codigoprofessor = numericUpDown1.Text;
                    objetoCT.Disponibilidade = true;
                    objetoCT.Id_FuncionarioCada = UserLoginCache.Id_Funcionario;
                    objetoCT.Sexo = radioButton1.Checked;
                    objetoCT.Disponibilidade = radioButton3.Checked;
                    objetoCT.Situacao = radiosituaAtivo.Checked;

                    objetoCT.Cpf = maskedTextBoxCpf.Text;
                    objetoCT.DataNascimento = Convert.ToDateTime(dateTimePicker1.Text);
                    string retorno =objetoCN.Alterarprofessor(objetoCT);

                try
                {
                    int Codigo = Convert.ToInt32(retorno);
                    MessageBox.Show("Registro alterado com sucesso.\n Código: " + Codigo, "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.Yes;
                }
                catch (FormatException)
                {
                    MessageBox.Show("Não foi possível alterar o cliente selecionado. Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
