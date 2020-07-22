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

namespace SqlMs.Forms
{
    public partial class ProfessorAdd : Form 
    {
        public ProfessorAdd()
        {
            InitializeComponent();
        }
       
        Utilidades utilidades = new Utilidades();
      

        private void btnCadastrar_Click(object sender, EventArgs e)
        {                         
                try
                {
                    bool SexoCheck;
                    if (radioButton1.Checked)
                    {
                        SexoCheck = true;
                    }
                    else
                    {
                        SexoCheck = false;
                    }
                    Professor objetoCT= new Professor();               
                             // objetoCT.Opcao = 1;
                              objetoCT.IdProfessor = 0;
                              objetoCT.Nome = TextBoxNome.Text;
                              objetoCT.Endereco = txtEnde.Text;
                              objetoCT.NumeroEndereco = txtNum.Text;
                              objetoCT.Bairro = txtBairro.Text;
                              objetoCT.Cidade = txtCidade.Text;
                              objetoCT.Cep = txtCep.Text;
                              objetoCT.Estado = txtEstado.Text;
                              objetoCT.Telefone = mtxtTel.Text;
                              objetoCT.CodigoProfessor = txtCodi.Text;
                              objetoCT.Disponibilidade = true;
                              objetoCT.Id_FuncionarioCada = UserLoginCache.Id_Funcionario;
                              objetoCT.Sexo =SexoCheck;
                              objetoCT.Cpf = txtCpf.Text;
                              objetoCT.DataNascimento =Convert.ToDateTime(txtNasc.Text);

                    CN_Professor objetoCN = new CN_Professor();
                    string retorno = objetoCN.InserirProfessor(objetoCT);
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
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possivel inserir  por: " + ex);
                }                    
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {           
                this.Close();               
        }
    }
}
