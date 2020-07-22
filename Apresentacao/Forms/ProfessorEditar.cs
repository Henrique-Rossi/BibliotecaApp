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
       }
        bool SexoCheck;
        bool situacao;
        
        public void ExibirConsultaNoForm(Professor professor)
        {
            
            label6.Text = Convert.ToString(professor.IdProfessor);
            txtNome.Text=    professor.Nome;
            txtEnde.Text=    professor.Endereco;
            txtNum.Text=     professor.NumeroEndereco;
            txtBairro.Text=  professor.Bairro;
            txtCidade.Text=  professor.Cidade;
            txtCep.Text=     professor.Cep;
            txtEstado.Text=  professor.Estado;
            mtxtTel.Text=    professor.Telefone;
            txtCodi.Text=    professor.CodigoProfessor;
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
            txtCpf.Text=     professor.Cpf;
            txtNasc.Text= Convert.ToString(professor.DataNascimento);
            
        }

       
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            
            //aqui exibe as menssagens de dialogo 
            string message = "Tem Certeza que deseja Alterar o Resgistro ?";
            string caption = "Alerta";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {

                try
                {

                    CN_Professor objetoCN = new CN_Professor();
                    Professor objetoCT = new Professor();

                    objetoCT.IdProfessor = Convert.ToInt32(label6.Text);
                    objetoCT.Nome = txtNome.Text;
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

                    objetoCT.Cpf = txtCpf.Text;
                    objetoCT.DataNascimento =Convert.ToDateTime( txtNasc.Text);
                    objetoCN.AlterarProfessor(objetoCT);
                   
                }
                catch (Exception)
                {

                    throw;
                }
                MessageBox.Show("Alterado");
            }
        }
    }
}
