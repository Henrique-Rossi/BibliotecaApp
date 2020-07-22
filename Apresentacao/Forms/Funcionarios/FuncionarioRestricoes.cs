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
    public partial class FuncionarioRestricoes : Form
    {
        public FuncionarioRestricoes()
        {
            InitializeComponent();
        }
        public FuncionarioRestricoes(Funcionarios funcionarios)
        {
            InitializeComponent();
            cbCadsatros.Checked = funcionarios.Restricoes.Cadastro;
           // cBAlteraFunc.Checked = funcionarios.Restricoes.a;
            cBCadastroFunc.Checked = funcionarios.Restricoes.CadastroFunc;
            cBCadastrosEmp.Checked = funcionarios.Restricoes.Emprestimos;
            Exportar.Checked= funcionarios.Restricoes.BackupEx;
            importar.Checked = funcionarios.Restricoes.BackupIm;
            consulta.Checked = funcionarios.Restricoes.Consulta;
            cBDevolu.Checked = funcionarios.Restricoes.Devolucao;
            cBRenova.Checked = funcionarios.Restricoes.Renovacao;
            labelID.Text = Convert.ToString(funcionarios.IdFuncionario);
           
            if (funcionarios.Restricoes.Relatorios== true)
            {
                rbRelatorioAtivo.Checked = true;
            }
            else
            {
                rbRelatorioDes.Checked = true;
            }
        }

        private void Executar_Click(object sender, EventArgs e)
        {
            Restricoes restricoes = new Restricoes();
            restricoes.IdFuncionario =Convert.ToInt32(labelID.Text);
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

            string retorno = objetoCN.AtualizaRestricoes(restricoes);
            try
            {
                int IdFuncionario = Convert.ToInt32(retorno);
                MessageBox.Show($"Atualizado com sucesso");


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
