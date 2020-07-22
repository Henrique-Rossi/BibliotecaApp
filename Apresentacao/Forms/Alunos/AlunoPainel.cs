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
    public partial class AlunoPainel : Form
    {
        public AlunoPainel()
        {
            InitializeComponent();

            if (UserLoginCache.Cadastro==false)
            {
                btnAdicionar.Visible= false;
                btnAlterar.Visible  = false;
                btnExcluir.Visible  = false;
            }
            if (UserLoginCache.Consultas == false)
            {
                btnConsultar.Visible = false;
            }
        }

        public void ExibirAlunos()
        {
            CN_Alunos obejetoCN = new CN_Alunos();
            dataGridView1.DataSource = obejetoCN.MostraAlunos();
            labelQuatidade.Text = "Resultado da Pesquisa: " + dataGridView1.RowCount + " Registro(s)";
        }
     

        private void AlunoPainel_Load(object sender, EventArgs e)
        {
            ExibirAlunos();
            radioConsultNome.Checked = true;
            labelQuatidade.Text = "Resultado da Pesquisa: " + dataGridView1.RowCount + " Registro(s)";
        }



        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            new AlunoAdd().ShowDialog();
            ExibirAlunos();
        }
       
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string nomeAluno;
            nomeAluno = dataGridView1.CurrentRow.Cells["Nome"].Value.ToString();
               
            MessageBox.Show("Você Selecionou o Usuario " + nomeAluno);

            Aluno ct = new Aluno();
                    ct.IdAluno=Convert.ToInt32( dataGridView1.CurrentRow.Cells["id_Aluno"].Value.ToString());
                    ct.Nome= dataGridView1.CurrentRow.Cells["Nome"].Value.ToString();
                    ct.Matricula= dataGridView1.CurrentRow.Cells["Matricula"].Value.ToString();
                    ct.Turma = dataGridView1.CurrentRow.Cells["Turma"].Value.ToString();
                    ct.Turno = dataGridView1.CurrentRow.Cells["Turno"].Value.ToString();
                    ct.Grau  = dataGridView1.CurrentRow.Cells["Grau"].Value.ToString();
                    ct.Cpf = dataGridView1.CurrentRow.Cells["Cpf"].Value.ToString();
                    ct.Descricao = dataGridView1.CurrentRow.Cells["Descricao"].Value.ToString();
                    ct.Cidade  = dataGridView1.CurrentRow.Cells["Cidade"].Value.ToString();    
                    ct.Estado  = dataGridView1.CurrentRow.Cells["Estado"].Value.ToString();
                    ct.Endereco  = dataGridView1.CurrentRow.Cells["Endereco"].Value.ToString();
                    ct.Numeroend  = Convert.ToInt32( dataGridView1.CurrentRow.Cells["Numero"].Value.ToString());
                    ct.Bairro = dataGridView1.CurrentRow.Cells["Bairro"].Value.ToString();
                    ct.Complemento = dataGridView1.CurrentRow.Cells["Complemento"].Value.ToString();
                    ct.DataNascimento =Convert.ToDateTime( dataGridView1.CurrentRow.Cells["DataNascimento"].Value.ToString());
                    ct.Telefone  = dataGridView1.CurrentRow.Cells["Telefone"].Value.ToString();
                    ct.Email = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
                    ct.TelefoneResponsavel= dataGridView1.CurrentRow.Cells["TelefoneRespo"].Value.ToString();
                    ct.Cep = dataGridView1.CurrentRow.Cells["cep"].Value.ToString();
                    ct.Id_FuncionarioCadastro = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id_FuncionarioCadastro"].Value.ToString());
                    ct.Sexo = Convert.ToBoolean(dataGridView1. CurrentRow.Cells["Sexo"].Value.ToString());
                    ct.Situacao=Convert.ToBoolean( dataGridView1.CurrentRow.Cells["Situacao"].Value.ToString());
                    ct.Disponibilidade= Convert.ToBoolean(dataGridView1.CurrentRow.Cells["Disponibilidade"].Value.ToString());
            AlunoEditar editar = new AlunoEditar();
            editar.ExibirDados(ct);
            editar.ShowDialog();
            ExibirAlunos();

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Aluno foi selecionado.", "Consultar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Aluno ct = new Aluno();
             
            ct.IdAluno = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id_Aluno"].Value.ToString());
            ct.Nome = dataGridView1.CurrentRow.Cells["Nome"].Value.ToString();
            ct.Matricula = dataGridView1.CurrentRow.Cells["Matricula"].Value.ToString();
            ct.Turma = dataGridView1.CurrentRow.Cells["Turma"].Value.ToString();
            ct.Turno = dataGridView1.CurrentRow.Cells["Turno"].Value.ToString();
            ct.Grau = dataGridView1.CurrentRow.Cells["Grau"].Value.ToString();
            ct.Cpf = dataGridView1.CurrentRow.Cells["Cpf"].Value.ToString();
            ct.Descricao = dataGridView1.CurrentRow.Cells["Descricao"].Value.ToString();
            ct.Cidade = dataGridView1.CurrentRow.Cells["Cidade"].Value.ToString();
            ct.Estado = dataGridView1.CurrentRow.Cells["Estado"].Value.ToString();
            ct.Endereco = dataGridView1.CurrentRow.Cells["Endereco"].Value.ToString();
            ct.Numeroend = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Numero"].Value.ToString());
            ct.Bairro = dataGridView1.CurrentRow.Cells["Bairro"].Value.ToString();
            ct.Complemento = dataGridView1.CurrentRow.Cells["Complemento"].Value.ToString();
            ct.DataNascimento = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["DataNascimento"].Value.ToString());
            ct.Telefone = dataGridView1.CurrentRow.Cells["Telefone"].Value.ToString();
            ct.Email = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
            ct.TelefoneResponsavel = dataGridView1.CurrentRow.Cells["TelefoneRespo"].Value.ToString();
            ct.Cep = dataGridView1.CurrentRow.Cells["cep"].Value.ToString();
            ct.Id_FuncionarioCadastro = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id_FuncionarioCadastro"].Value.ToString());
            ct.DataCadastro = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["DataCadastro"].Value.ToString());
            ct.DataAlteracao = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["DataAlteracao"].Value.ToString());
            ct.Sexo =Convert.ToBoolean( dataGridView1.CurrentRow.Cells["Sexo"].Value.ToString());
            ct.Situacao = Convert.ToBoolean(dataGridView1.CurrentRow.Cells["Situacao"].Value.ToString());
            ct.Disponibilidade = Convert.ToBoolean(dataGridView1.CurrentRow.Cells["Disponibilidade"].Value.ToString());

            String NomeFunc = dataGridView1.CurrentRow.Cells["Nome1"].Value.ToString();

            AlunoConsulta consultar = new AlunoConsulta(ct,NomeFunc);
            DialogResult dialog = consultar.ShowDialog();
            if (dialog == DialogResult.Yes)
            {
                ExibirAlunos();
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
           string nomealuno= dataGridView1.CurrentRow.Cells["Nome"].Value.ToString();
         


            if (dataGridView1.SelectedRows.Count > 0)
            {

                MessageBox.Show("Você Selecionou o Usuario " + nomealuno);
                string message = "Tem Certeza que deseja Excluir o Resgistro ?";
                string caption = "Alerta";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);


                if (result == DialogResult.Yes)
                {
                    Aluno ct = new Aluno();                  
                          ct.IdAluno = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id_Aluno"].Value.ToString());
                          ct.Nome = dataGridView1.CurrentRow.Cells["Nome"].Value.ToString();
                          ct.Matricula = dataGridView1.CurrentRow.Cells["Matricula"].Value.ToString();
                          ct.Turma = dataGridView1.CurrentRow.Cells["Turma"].Value.ToString();
                          ct.Turno = dataGridView1.CurrentRow.Cells["Turno"].Value.ToString();
                          ct.Grau = dataGridView1.CurrentRow.Cells["Grau"].Value.ToString();
                          ct.Cpf = dataGridView1.CurrentRow.Cells["Cpf"].Value.ToString();
                          ct.Descricao = dataGridView1.CurrentRow.Cells["Descricao"].Value.ToString();
                          ct.Cidade = dataGridView1.CurrentRow.Cells["Cidade"].Value.ToString();
                          ct.Estado = dataGridView1.CurrentRow.Cells["Estado"].Value.ToString();
                          ct.Endereco = dataGridView1.CurrentRow.Cells["Endereco"].Value.ToString();
                          ct.Numeroend = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Numero"].Value.ToString());
                          ct.Bairro = dataGridView1.CurrentRow.Cells["Bairro"].Value.ToString();
                          ct.Complemento = dataGridView1.CurrentRow.Cells["Complemento"].Value.ToString();
                          ct.DataNascimento = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["DataNascimento"].Value.ToString());
                          ct.Telefone = dataGridView1.CurrentRow.Cells["Telefone"].Value.ToString();
                          ct.Email = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
                          ct.TelefoneResponsavel = dataGridView1.CurrentRow.Cells["TelefoneRespo"].Value.ToString();
                          ct.Cep = dataGridView1.CurrentRow.Cells["cep"].Value.ToString();
                          ct.Id_FuncionarioCadastro = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id_FuncionarioCadastro"].Value.ToString());
                          ct.Sexo = Convert.ToBoolean(dataGridView1.CurrentRow.Cells["Sexo"].Value.ToString());
                          ct.Situacao = Convert.ToBoolean(dataGridView1.CurrentRow.Cells["Situacao"].Value.ToString());
                          ct.Disponibilidade = Convert.ToBoolean(dataGridView1.CurrentRow.Cells["Disponibilidade"].Value.ToString());

                    CN_Alunos objetoCN = new CN_Alunos();
                    string retorno = objetoCN.ExcluirAluno(ct);
                    ExibirAlunos();

                    try
                    {

                        int Idprofessor = Convert.ToInt32(retorno);
                        MessageBox.Show($"Excluido com sucesso  { nomealuno}  ");


                        //this.Close();

                    }
                    catch (FormatException)
                    {
                        MessageBox.Show($"Não é possivel Excluir um usuario que tenha registros no sistema {retorno}");
                        throw;
                    }
                }
            }
        }

     

        //------------------------------------------------------------------------------------------------------------------------------------------
        //ATUALIZAÇÃO AUTOMATICA
        private void txtConsulta_TextChanged(object sender, EventArgs e)
        {
            
            if (txtConsulta.Text=="")
            {
                ExibirAlunos();
                labelQuatidade.Text = "Resultado da Pesquisa: " + dataGridView1.RowCount + " Registro(s)";
            }         
            //NOME-ATIVO
            else if (radioConsultNome.Checked == true && radioSituaAtivo.Checked == true)
            {
                Aluno a = new Aluno();
                AtualizaNomeAtivocaoAutomatico(a, 1);
            }
            //NOME-Desativo
            else if (radioConsultNome.Checked == true && radioSituaDes.Checked == true)
            {
                Aluno a = new Aluno();
                AtualizaNomeAtivocaoAutomatico(a, 0);
            }
            //NOME-PENDENTE
            else if (radioConsultNome.Checked == true && radioPenSim.Checked == true)
            {
                Aluno a = new Aluno();
                AtualizaDadosNomePendenteInsta(a, 0);
            }
            //NOME-SEMPENDENCIA
            else if (radioConsultNome.Checked == true && radioPenNao.Checked == true)
            {
                Aluno a = new Aluno();
                AtualizaDadosNomePendenteInsta(a, 1);
            }
 //----------------------------------------------------------MATRICULA-----------------------------------------------------------
            //matricula-ATIVO
            else if (radioConsulCodi.Checked == true && radioSituaAtivo.Checked == true)
            {
                Aluno a = new Aluno();
                AtualizaMatriculaAtivocaoAutomatico(a, 1);
            }
            //matricula-Desativo
            else if (radioConsulCodi.Checked == true && radioSituaDes.Checked == true)
            {
                Aluno a = new Aluno();
                AtualizaMatriculaAtivocaoAutomatico(a, 0);
            }
            //matriculaP-PENDENTE
            else if (radioConsulCodi.Checked == true && radioPenSim.Checked == true)
            {
                Aluno a = new Aluno();
                AtualizaDadosMatriculaPendenteInsta(a, 0);
            }
            //Matricula-SEMPENDENCIA
            else if (radioConsulCodi.Checked == true && radioPenNao.Checked == true)
            {
                Aluno a = new Aluno();
                AtualizaDadosMatriculaPendenteInsta(a, 1);
            }
            else if (radioConsulTurno.Checked==true)
            {
                Aluno aluno = new Aluno();
                aluno.Turno = txtConsulta.Text.Trim();
                CN_Alunos o = new CN_Alunos();
                dataGridView1.DataSource = o.MostraTurnos(aluno);
            }
            else if (radioButtonconsulTurma.Checked == true)
            {
                Aluno aluno = new Aluno();
                aluno.Turma = txtConsulta.Text.Trim();
                CN_Alunos o = new CN_Alunos();
                dataGridView1.DataSource = o.MostraTurma(aluno);
            }
            //matricula
            else if (radioConsulCodi.Checked == true)
            {
                Aluno aluno = new Aluno();
                aluno.Matricula =txtConsulta.Text.Trim();
                CN_Alunos o = new CN_Alunos();
                dataGridView1.DataSource = o.AtualizaDadosporMatricula(aluno);

            }
            //NOME
            else if (radioConsultNome.Checked==true)
            {
                Aluno aluno = new Aluno();
                aluno.Nome = txtConsulta.Text.Trim();
                CN_Alunos o = new CN_Alunos();
                dataGridView1.DataSource = o.AtualizaDataInsta(aluno);
            }

            labelQuatidade.Text = "Resultado da Pesquisa: " + dataGridView1.RowCount + " Registro(s)";


        }
//==========================================================================================================================================================================


//==========================================================================================================================================================================
                                                        //FUNÇÕES   

        //NOME-ATIVO-Desativo
        public void AtualizaNomeAtivocaoAutomatico(Aluno aluno,int Situacao)
        {
            aluno.Nome = txtConsulta.Text.Trim();
            CN_Alunos o = new CN_Alunos();
            dataGridView1.DataSource = o.AtualizaDadosNomeAtivoInsta(aluno,Situacao);
        }
                                                    //NOME-Disponibilidades
        public void AtualizaDadosNomePendenteInsta(Aluno aluno, int Disponibilidade)
        {
            aluno.Nome = txtConsulta.Text.Trim();
            CN_Alunos o = new CN_Alunos();
            dataGridView1.DataSource = o.AtualizaDadosNomePendenteInsta(aluno, Disponibilidade);
        }

                                                    //Matricula-ATIVO-Desativo
        public void AtualizaMatriculaAtivocaoAutomatico(Aluno aluno, int Situacao)
        {
            aluno.Matricula = txtConsulta.Text.Trim();
            CN_Alunos o = new CN_Alunos();
            dataGridView1.DataSource = o.AtualizaDadosMatriculaAtivoInsta(aluno, Situacao);
        }
                                                    //MatriculaE-Disponibilidades
        public void AtualizaDadosMatriculaPendenteInsta(Aluno aluno, int Disponibilidade)
        {
            aluno.Matricula = txtConsulta.Text.Trim();
            CN_Alunos o = new CN_Alunos();
            dataGridView1.DataSource = o.AtualizaDadosMatriculaPendenteInsta(aluno, Disponibilidade);
        }


//==========================================================================================================================================================================

                                                                  // DESMARCAR RADIO BUTONS   

//==========================================================================================================================================================================

        // NOME
        bool isChecked = false;
        private void radioConsultNome_CheckedChanged(object sender, EventArgs e)
        {
            isChecked = radioConsultNome.Checked;
        }
        private void radioConsultNome_Click(object sender, EventArgs e)
        {
            if (radioConsultNome.Checked && !isChecked)
                radioConsultNome.Checked = false;
            else
            {
                radioConsultNome.Checked = true;
                isChecked = false;
            }
        }


        //  MATRICULA
        private void radioConsulCodi_CheckedChanged(object sender, EventArgs e)
        {
            isChecked = radioConsulCodi.Checked;
        }

        private void radioConsulCodi_Click(object sender, EventArgs e)
        {
            if (radioConsulCodi.Checked && !isChecked)
                radioConsulCodi.Checked = false;
            else
            {
                radioConsulCodi.Checked = true;
                isChecked = false;
            }
        }

 //==========================================================================================================================================================================
       
                                                               //ATUALIZAÇÃO AO SELECIONAR RADIO BUTON

 //==========================================================================================================================================================================

        //ativos
        private void radioSituaAtivo_CheckedChanged(object sender, EventArgs e)
        {
            CN_Alunos objetoCN = new CN_Alunos();
            dataGridView1.DataSource = objetoCN.ConsultarPorSituacao(Convert.ToString(1));
            labelQuatidade.Text = "Resultado da Pesquisa: " + dataGridView1.RowCount + " Registro(s)";
        }
        private void radioSituaDes_CheckedChanged(object sender, EventArgs e)
        {
            CN_Alunos objetoCN = new CN_Alunos();
            dataGridView1.DataSource = objetoCN.ConsultarPorSituacao(Convert.ToString(0));
            labelQuatidade.Text = "Resultado da Pesquisa: " + dataGridView1.RowCount + " Registro(s)";
        }
        //indisponiveis
        private void radioPenSim_CheckedChanged(object sender, EventArgs e)
        {
            CN_Alunos objetoCN = new CN_Alunos();
            dataGridView1.DataSource = objetoCN.ConsultarPorDependencia(Convert.ToString(0));
        }
        //disponiveis
        private void radioPenNao_CheckedChanged(object sender, EventArgs e)
        {
            CN_Alunos objetoCN = new CN_Alunos();
            dataGridView1.DataSource = objetoCN.ConsultarPorDependencia(Convert.ToString(1));
        }
       

        //TODOS
        private void radioPendTodos_CheckedChanged(object sender, EventArgs e)
        {
            ExibirAlunos();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ExibirAlunos();
        }

        private void radioSituaTodos_CheckedChanged(object sender, EventArgs e)
        {
            ExibirAlunos();
        }

        private void btnFiltroConsulta_Click(object sender, EventArgs e)
        {
            labelQuatidade.Text = "Resultado da Pesquisa: " + dataGridView1.RowCount + " Registro(s)";
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Aluno ct = new Aluno();

            ct.IdAluno = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id_Aluno"].Value.ToString());
            ct.Nome = dataGridView1.CurrentRow.Cells["Nome"].Value.ToString();
            ct.Matricula = dataGridView1.CurrentRow.Cells["Matricula"].Value.ToString();
            ct.Turma = dataGridView1.CurrentRow.Cells["Turma"].Value.ToString();
            ct.Turno = dataGridView1.CurrentRow.Cells["Turno"].Value.ToString();
            ct.Grau = dataGridView1.CurrentRow.Cells["Grau"].Value.ToString();
            ct.Cpf = dataGridView1.CurrentRow.Cells["Cpf"].Value.ToString();
            ct.Descricao = dataGridView1.CurrentRow.Cells["Descricao"].Value.ToString();
            ct.Cidade = dataGridView1.CurrentRow.Cells["Cidade"].Value.ToString();
            ct.Estado = dataGridView1.CurrentRow.Cells["Estado"].Value.ToString();
            ct.Endereco = dataGridView1.CurrentRow.Cells["Endereco"].Value.ToString();
            ct.Numeroend = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Numero"].Value.ToString());
            ct.Bairro = dataGridView1.CurrentRow.Cells["Bairro"].Value.ToString();
            ct.Complemento = dataGridView1.CurrentRow.Cells["Complemento"].Value.ToString();
            ct.DataNascimento = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["DataNascimento"].Value.ToString());
            ct.Telefone = dataGridView1.CurrentRow.Cells["Telefone"].Value.ToString();
            ct.Email = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
            ct.TelefoneResponsavel = dataGridView1.CurrentRow.Cells["TelefoneRespo"].Value.ToString();
            ct.Cep = dataGridView1.CurrentRow.Cells["cep"].Value.ToString();
            ct.Id_FuncionarioCadastro = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id_FuncionarioCadastro"].Value.ToString());
            ct.DataCadastro = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["DataCadastro"].Value.ToString());
            ct.DataAlteracao = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["DataAlteracao"].Value.ToString());
            ct.Sexo = Convert.ToBoolean(dataGridView1.CurrentRow.Cells["Sexo"].Value.ToString());
            ct.Situacao = Convert.ToBoolean(dataGridView1.CurrentRow.Cells["Situacao"].Value.ToString());
            ct.Disponibilidade = Convert.ToBoolean(dataGridView1.CurrentRow.Cells["Disponibilidade"].Value.ToString());

            String NomeFunc = dataGridView1.CurrentRow.Cells["Nome1"].Value.ToString();

            AlunoConsulta consultar = new AlunoConsulta(ct, NomeFunc);
            DialogResult dialog = consultar.ShowDialog();
            if (dialog == DialogResult.Yes)
            {
                ExibirAlunos();
            }

        }


        //==============================================================================================================================================
    }
}
