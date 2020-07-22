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
    public partial class ExternoEditar : Form
    {
        public ExternoEditar()
        {
            InitializeComponent();

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

       Externo original = new Externo();
        public ExternoEditar(Externo externo)
        {
            InitializeComponent();
            AtualizaComboBoxEstado("11");
            original = externo;


            labelId.Text = Convert.ToString(externo.IdExterno);
            TextBoxNome.Text = externo.Nome.ToString();
            maskedTextBoxCpf.Text = externo.Cpf;
            textBoxDesc.Text = externo.Descricao;
            comboBoxCidade.Text = externo.Cidade;
            ComboBoxEstado.Text = externo.Estado;
            txtEnde.Text = externo.Endereco;
            numericUpDown1.Value = Convert.ToInt32(externo.Numero);
            comboBoxBairro.Text = externo.Bairro;
            txtComp.Text = externo.Complemento;
            dateTimePicker1.Value = externo.DataNascimento;
            mtxtTel.Text = externo.Telefone;
            textBoxEmail.Text = externo.Email;
            comboBoxPAis.Text = externo.Pais;
            //textBox2.Text = Convert.ToString(externo.Id_FuncionarioCadastro);
           
            comboBoxCep.Text = externo.Cep;

            SexoCheck = externo.Sexo;
            if (SexoCheck == true)           
                radioButton1.Checked = true;           
            else
                radioButton2.Checked = true;



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


        /* public void ExibirDados(Externo externo)
         {
             labelId.Text = Convert.ToString(externo.IdExterno);
             TextBoxNome.Text = externo.Nome;         
             maskedTextBoxCpf.Text = externo.Cpf;
             textBoxDesc.Text = externo.Descricao;
             comboBoxCidade.Text = externo.Cidade;
             comboBoxEstado.Text = externo.Estado;
             txtEnde.Text = externo.Endereco;
             numericUpDown1.Value = Convert.ToInt32(externo.Numero);
             comboBoxBairro.Text = externo.Bairro;
             txtComp.Text = externo.Complemento;
             dateTimePicker1.Value = externo.DataNascimento;
             mtxtTel.Text = externo.Telefone;
             textBoxEmail.Text = externo.Email;
             UserLoginCache.Id_Funcionario = externo.Id_FuncionarioCadastro;
             comboBoxPAis.Text = externo.Pais;
             comboBoxCep.Text = externo.Cep;
             SexoCheck = externo.Sexo;
             if (SexoCheck == true)
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
             //passar disponibilidde por aqi para nao afetar depois na hora de alterar

             disponibilidade = externo.Disponibilidade;
             if (disponibilidade == true)
             {
                 radioButton6.Checked = true;
             }
             else
             {
                 radioButton5.Checked = true;
             }

         }*/

         private void pictureBox1_Click(object sender, EventArgs e)
         {
             string messagem = "Tem Certeza que deseja Executar essas Alterações ?";
             string captionn = "Alerta";
             MessageBoxButtons buttonss = MessageBoxButtons.YesNo;
             DialogResult resultt;

             resultt = MessageBox.Show(messagem, captionn, buttonss);
             if (resultt == System.Windows.Forms.DialogResult.Yes)
             {

                 Externo objetoCT = new Externo();

                 objetoCT.IdExterno = Convert.ToInt32(labelId.Text);
                 objetoCT.Nome = TextBoxNome.Text;

                 objetoCT.Sexo = radioButton1.Checked;

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

                 
                 objetoCT.DataNascimento = Convert.ToDateTime(dateTimePicker1.Text);

                 objetoCT.Situacao = radioButton3.Checked;
                 objetoCT.Disponibilidade = radioButton6.Checked;
                 CN_Externos objetoCN = new CN_Externos();

                 string retorno = objetoCN.EditarExterno(objetoCT);
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
