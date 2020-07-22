using CamadaTransferencia;
using Domain;
using SqlMs.Forms;
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
    public partial class EmprestimoAlunoConsu : Form
    {
        public EmprestimoAlunoConsu()
        {
            InitializeComponent();
        }
      
        
        
        public EmprestimoAlunoConsu(EmprestimoAluno emprestimo, Aluno aluno,Livro livro,string func )
        {
            InitializeComponent();
           // labelId.Text = aluno.IdEmprestimo.ToString();
            labelNome.Text = aluno.Nome;
                                      
            labelLivro.Text            =livro.Nome_Livro;
         
            labelReno.Text             = emprestimo.DataProcesso.ToString("dd/MM/yyyy");
            labelDEV.Text              = emprestimo.DataSaida.ToString("dd/MM/yyyy");
            labelDataEmpre.Text        = emprestimo.DataAtual.ToString("dd/MM/yyyy");
            textBox2.Text              =Convert.ToString( emprestimo.Id_FuncionarioCadastro);
            textBox1.Text              = func;
            labelidAluno.Text           = Convert.ToString(aluno.IdAluno);


            if ((emprestimo.DataEntregou <= emprestimo.DataSaida) && emprestimo.IdSituacao != 3)
            {
                labelEntre.Text = "Não Devolvido";
            }
            else
            {
                labelEntre.Text = emprestimo.DataEntregou.ToString("dd/MM/yyyy");
            }//criar função apertar lado direito do mause validação pra noa colocar uma data de devolução menor que a tual
        }

        private void btnFiltroConsulta_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();
            CN_Alunos cn_Alunos = new CN_Alunos();
            aluno= cn_Alunos.ConsultarPorId(labelidAluno.Text);
            AlunoConsulta consulta = new AlunoConsulta(aluno,textBox1.Text);
            consulta.ShowDialog();
        }
    }
}
