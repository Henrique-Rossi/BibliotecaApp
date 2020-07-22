using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SqlMs.Forms.professorDid;

using SqlMs.Forms;
using ViewUser.Cache;


namespace SqlMs
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
            if (UserLoginCache.Relatorios == false)
            {
                btnRelatorio.Visible = false;
            }
           
        }
      

        private void TelaInicial_Load(object sender, EventArgs e)
        {
            
            toolStripStatusLabel2.Text =$"Usuario: { UserLoginCache.Nome}   Biblioteca - Escola Estadual Casimiro Silva ";
            //otimizar ,executar a varredura apenas  quando abrir o painel determiando para nao precisar carregartudo de uma vez
            //atualiza o satus  pendencias para vencido 
            EmprestimoAlunoPainel teste = new EmprestimoAlunoPainel();
            teste.Atualizatudo();
          
          //  EmprestimoPainel att = new EmprestimoPainel();
          //  att.Atualizatudo();
        }
        

//-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
//                                                                                  Botão Livro
//-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void btnlivroAdd_Click(object sender, EventArgs e)
        {
            new LivrosAdd().ShowDialog();
        }
        private void btnLivroexc_Click(object sender, EventArgs e)
        {
            new LivroPainel().ShowDialog();
        }

        private void btnLivroAlt_Click(object sender, EventArgs e)
        {
            new LivroPainel().ShowDialog();
        }



        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //                                                                                  Botão Livro Didático
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void btnprofessorDidAdd_Click(object sender, EventArgs e)
        {
            new professorDidAdd().Show();
        }

        private void btnprofessorDidExc_Click(object sender, EventArgs e)
        {
            new professorDidExc().Show();
        }

     



//-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
//                                                                                  Botão EMPRESTIMO
//-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void btnEmprestimoAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEmprestimoCon_Click(object sender, EventArgs e)
        {
            //  new EmprestimoCon().Show();
        }

        private void btnEmprestimoDev_Click(object sender, EventArgs e)
        {
           // new EmprestimoDev().Show();
        }

     




//-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
//                                                                                  Botão Relatorio
//-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
       



        //Botão Sair

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

       




//---------------------------------------------------------------------CONSULTA--------------------------------------------------------------------------------------------------------------------------------
//-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void alunosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
           // new ConsultarAlunos().Show();
        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EmprestimoAlunoAdd().ShowDialog();
        }

        private void externoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EmprestimosExternosAdd().ShowDialog();
        }

        private void alunoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new EmprestimoAlunoPainel().ShowDialog();
        }

        private void externoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new EmprestimosExternosPainel().ShowDialog();
        }

        private void professorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            new EmprestimoPainel().ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        
        private void externosToolStripMenuItem3_Click(object sender, EventArgs e)
        {//atualziar os emprestimos
            EmprestimosExternosPainel teste2 = new EmprestimosExternosPainel();
            teste2.Atualizatudo();
            new EmprestimosExternosPainel().ShowDialog();
        }

        private void professorToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new EmprestimoPainel().ShowDialog();
        }

        private void alunoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
           
            new EmprestimoAlunoPainel().ShowDialog();
        }

        private void professorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new ProfessorPainel().ShowDialog();
        }

        private void btnprofessor_Click(object sender, EventArgs e)
        {
            new LivroPainel().ShowDialog();
        }

       

        private void aDMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Painel().ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new Backup().ShowDialog();
        }




        //Users
        private void alunoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            new AlunoPainel().ShowDialog();
        }

        private void professoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ProfessorPainel().ShowDialog();
        }

        private void externosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ExternoPainel().ShowDialog();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = $"Bem Vindo Versão - 1.0.0.0   { DateTime.Now.ToShortTimeString()} - {DateTime.Now.ToShortDateString()}";
           
        }

        private void empréstimosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Relatorios().ShowDialog();
           
        }

        private void listasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormRelatorioListaAluno().ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        /* private void btnprofessor_MouseHover(object sender, EventArgs e)
         {

             btnprofessor.Image = Image.FromFile(@"Img\livro(1).png");

         }

         private void btnprofessor_MouseLeave(object sender, EventArgs e)
         {

         }*/
    }
}
