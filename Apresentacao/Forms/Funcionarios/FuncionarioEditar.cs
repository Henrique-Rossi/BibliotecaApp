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

namespace SqlMs
{
    public partial class FuncionarioEditar : Form
    {
        public FuncionarioEditar()
        {
            InitializeComponent();

        }
     
        public FuncionarioEditar(Funcionarios funcionario)
        {
            InitializeComponent();
            TextBoxNome.Text = funcionario.Nome;
            
            if (funcionario.Sexo1 =="M")
            {
                
                radioButton1.Checked = true;
            }
            else
            {
               
                radioButton2.Checked = true;
            }
            label8.Text =Convert.ToString(funcionario.IdFuncionario);
            maskedTextBoxCpf.Text=funcionario.Cpf;
            textBoxDesc.Text= funcionario.Descricao;
            comboBoxCidade.Text= funcionario.Cidade;
            comboBoxEstado.Text= funcionario.Estado;
            txtEnde.Text = funcionario.Endereco;
            numericUpDown1.Value =Convert.ToInt32(funcionario.Numero);
            comboBoxBairro.Text = funcionario.Bairro;
            txtComp.Text = funcionario.Complemento;
            dateTimePicker1.Text =Convert.ToString(funcionario.DataNascimento);
            mtxtTel.Text = funcionario.Telefone;
            textBoxEmail.Text = funcionario.Email;
            comboBoxCep.Text = funcionario.Cep;

            textBoxUser.Text = funcionario.LoginUsuario;
            textBoxSenha.Text = funcionario.SenhaUsuario;


           bool situacao = funcionario.Situacao;
            if (situacao == true)
            {

                radiosituaAtivo.Checked = true;
            }
            else
            {
                radioSituaDesativado.Checked = true;
            }
          bool  disponibilidade = funcionario.Disponibilidade;
            if (disponibilidade == true)
            {

                radioButton3.Checked = true;
            }
            else
            {
                radioButton4.Checked = true;
            }
        }

        private void Executar_Click(object sender, EventArgs e)
        {
            Funcionarios objetoCT = new Funcionarios();
           

            objetoCT.IdFuncionario=Convert.ToInt32(label8.Text);
            objetoCT.Nome = TextBoxNome.Text;
            string SexoCheck;
            if (radioButton1.Checked)
            {
                SexoCheck = "M";
            }
            else
            {
                SexoCheck = "F";
            }
            objetoCT.Sexo1 = SexoCheck;
            objetoCT.Cpf = maskedTextBoxCpf.Text;
            objetoCT.Descricao = textBoxDesc.Text;
            objetoCT.Cidade = comboBoxCidade.Text;
            objetoCT.Estado = comboBoxEstado.Text;
            objetoCT.Endereco = txtEnde.Text;
            objetoCT.Numero = Convert.ToString(numericUpDown1.Value);
            objetoCT.Bairro = comboBoxBairro.Text;
            objetoCT.Complemento = txtComp.Text;
            objetoCT.DataNascimento = Convert.ToDateTime(dateTimePicker1.Text);
            objetoCT.Telefone = mtxtTel.Text;
            objetoCT.Email = textBoxEmail.Text;
            objetoCT.Cep = comboBoxCep.Text;
            objetoCT.Disponibilidade = radioButton3.Checked;
            objetoCT.Situacao = radiosituaAtivo.Checked;
            objetoCT.LoginUsuario = textBoxUser.Text;
            objetoCT.SenhaUsuario = textBoxSenha.Text;



            CN_Funcionario objetoCN = new CN_Funcionario();
            
            string retorno = objetoCN.AlterarFuncionario(objetoCT);
            try
            {
                int IdFuncionario = Convert.ToInt32(retorno);
                MessageBox.Show($"Atualizado com sucesso  {TextBoxNome.Text} ");
                

                //this.Close();

            }
            catch (FormatException)
            {
                MessageBox.Show($"Não foi possivel cadastrar por {retorno}{MessageBoxButtons.OK}");
                throw;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel inserir  " + ex);
            }

        }

      
    }
}
