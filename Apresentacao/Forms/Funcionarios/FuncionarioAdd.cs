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
    public partial class FuncionarioAdd : Form
    {
        public FuncionarioAdd()
        {
            InitializeComponent();
        }
        Utilidades utilidades = new Utilidades();
        private void pictureBox1_Click(object sender, EventArgs e)
        {

            try
            {

                Funcionarios objetoCT = new Funcionarios();
                Restricoes restricoes = new Restricoes();

                //objetoCT.IdFuncionario= null;
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
                objetoCT.Sexo1     = SexoCheck;               
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

                objetoCT.LoginUsuario = textBoxUser.Text;
                objetoCT.SenhaUsuario = textBoxSenha.Text;

                restricoes.BackupEx = Exportar.Checked;
                restricoes.BackupIm = importar.Checked;
                restricoes.Cadastro = cbCadsatros.Checked;
                restricoes.CadastroFunc = cBCadastroFunc.Checked;
                restricoes.Devolucao = cBDevolu.Checked;
                restricoes.Emprestimos = cBCadastrosEmp.Enabled;
                restricoes.Relatorios = rbRelatorioAtivo.Checked;
                restricoes.Renovacao = cBRenova.Checked;
                restricoes.Consulta = consulta.Checked;
                

               
                




                CN_Funcionario objetoCN = new CN_Funcionario();

                string retorno = objetoCN.CadastrarFuncionario(objetoCT,restricoes);
                try
                {
                    int IdFuncionario = Convert.ToInt32(retorno);
                    MessageBox.Show($"Cadastrado com sucesso  {TextBoxNome.Text} ");
                    utilidades.LimpaCampos(this.panel1.Controls);

                    //this.Close();

                }
                catch (FormatException)
                {
                    MessageBox.Show($"Não foi possivel cadastrar por {retorno}{MessageBoxButtons.OK}");
                    throw;
                }
            }
            catch (Exception ex )
            {
                 MessageBox.Show("Não foi possivel inserir  " +  ex);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
