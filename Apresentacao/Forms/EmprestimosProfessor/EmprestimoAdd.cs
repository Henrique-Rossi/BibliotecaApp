using AcessoBancoDados;
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
    public partial class EmprestimoAdd : Form
    {
        public EmprestimoAdd()
        {
            InitializeComponent();
        }
    

        private ConexaoBd Conexao = new ConexaoBd();
        SqlCommand c = new SqlCommand();


 //====================================================== QTD EMPRESTIMO(subistituir por procedures) ============================================================//
        //atualiza o label pra poder pegar o valor
        public void AtualizaQtdMaxima()
        {
            numericUpDown1.Maximum = Convert.ToInt32(label5.Text);
                
        }
        //joga a condição acima pra limitar a quantidade de numeros que podem ser selecionados
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            AtualizaQtdMaxima();
           
        }
        //função para nao cadastrar um livro que esteja com quantidade abaixo de 0 ou igual
        public void InserirItemNalista()
        {
           
            if (Convert.ToInt32(label5.Text) <= 0)//label que exibe  a quantidade em stoque
            {
                MessageBox.Show("A quantidade Disponível do item,chegou a 0");
            }
            else 
            {
                var dataRowViewLivros = comboBox2.SelectedItem as DataRowView;
                dataGridView1.Rows.Add(dataRowViewLivros.Row.ItemArray[0],
                                       dataRowViewLivros.Row.ItemArray[1],
                                       dataRowViewLivros.Row.ItemArray[2],
                                       dataRowViewLivros.Row.ItemArray[3],
                                       dataRowViewLivros.Row.ItemArray[16],
                                       dataRowViewLivros.Row.ItemArray[4]);
                //atualiza o valor da lebel inserir nos outros metodos de isnerir ,o valor retorna se mudar de livro
                 int o = Convert.ToInt32(label5.Text) - 1;
                 label5.Text = Convert.ToString(o);
                //Att(Convert.ToInt32( dataRowViewLivros.Row.ItemArray[0]));

            }
           /* else
            {
                MessageBox.Show("Apenas dois empréstimos por usuario");
            }*/
        }
      

        //botao para adicionar livro na lista iamgem livro
        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

            InserirItemNalista();

          
        }
        //remover livro lista
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                int o = Convert.ToInt32(label5.Text) + 1;
                label5.Text = Convert.ToString(o);
            }
          
        }
        //inserir quantidade de itens pela imagem +
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            AtualizaQtdMaxima();
            if (Convert.ToInt32(label5.Text) <= 0 )//label que exibe  a quantidade em stoque
            {
                MessageBox.Show("O livro em questão,encontra-se indiponivel no momento,verifique os emprestimos pendentes");
            }
            else
            {
                
                for (int i = 0; i < numericUpDown1.Value; i++)
                {
                    var dataRowViewLivros = comboBox2.SelectedItem as DataRowView;
                    dataGridView1.Rows.Add(dataRowViewLivros.Row.ItemArray[0],
                                          dataRowViewLivros.Row.ItemArray[1],
                                          dataRowViewLivros.Row.ItemArray[2],
                                          dataRowViewLivros.Row.ItemArray[3],
                                          dataRowViewLivros.Row.ItemArray[16],
                                          dataRowViewLivros.Row.ItemArray[4]);

                    //atualiza o valor da lebel inserir nos outros metodos de isnerir ,o valor retorna se mudar de livro
                    int o= Convert.ToInt32(label5.Text) - 1;
                    label5.Text =Convert.ToString(o);
                }
            }
           
            
        }
  //============================================================================================================================================================//
  
    
        public void ComboLivro()
        {
            
            c.Connection = Conexao.AbrirConexao();
            c.CommandText = "select * from tblLivro";
            c.CommandType = CommandType.Text;

            SqlDataReader ler = c.ExecuteReader();

            DataTable tabela = new DataTable();//cria uma tabela virtual
            tabela.Load(ler);

          
            comboBox2.DisplayMember = "Nome_Livro";//aqui define o campo que quer exibir
            comboBoxCodigoLivro.DisplayMember = "Id_Livro";

            comboBox2.DataSource = tabela;
            comboBoxCodigoLivro.DataSource= tabela;

            //Mascara para os combobox
            comboBox2.Text = "[Selecione]";
            comboBoxCodigoLivro.Text = "[Selecione]";
            // comboBoxCodigoLivro.SelectedIndex = -1;
            // comboBox2.SelectedIndex = -1;

            label5.Text = "";
        }
        public void ComboProfessor()
        {
            c.Connection = Conexao.AbrirConexao();
            c.CommandText = "USP_ListaEmprestimoDisponivel";
            c.CommandType = CommandType.StoredProcedure;

            SqlDataReader ler = c.ExecuteReader();

            DataTable tabela = new DataTable();//cria uma tabela virtual
            tabela.Load(ler);

            //aqui define o campo que quer exibir
            comboBox1.SelectedIndex = -1;
            comboBoxCodigoUsuario.SelectedIndex = -1;
            comboBox1.DisplayMember = "Nome";
            comboBoxCodigoUsuario.DisplayMember = "IdProfessor";

            //aqui instacia o objeto no campo
            comboBox1.DataSource = tabela;
            comboBoxCodigoUsuario.DataSource = tabela;

            //Mascara para os combobox         
            
            comboBox1.Text = "[Selecione]";
            
            comboBoxCodigoUsuario.Text = "[Selecione]";
            label13.Text = "";

        }


        private void EmprestimoAdd_Load(object sender, EventArgs e)
        {
            
            ComboLivro();
            ComboProfessor();
            DateTime today = DateTime.Now;
            DateTime answer = today.AddDays(7);
            dateTimePicker2.Value = answer;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new ProfessorAdd().ShowDialog();
        }

        private void btnEmprestar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                string retorno = null;
                var dataRowView = this.comboBox1.SelectedItem as DataRowView;//combobox usuario
                var dataRowViewLivros = this.comboBox2.SelectedItem as DataRowView;//combo box livros

                string messagem = "Tem Certeza que deseja Executar esse empréstimo?" + dataRowViewLivros.Row.ItemArray[1];
                string captionn = "Alerta";
                MessageBoxButtons buttonss = MessageBoxButtons.YesNo;
                DialogResult resultt;

                resultt = MessageBox.Show(messagem, captionn, buttonss);
                if (resultt == System.Windows.Forms.DialogResult.Yes)
                {
               
                    for (int i = 0; i < dataGridView1.Rows.Count - 0; i++)
                    {
                        Conexao.LimparParametros();
                        try
                        {

                            EmprestimoProfessor objetoCT = new EmprestimoProfessor
                            {
                                IdProfessor = Convert.ToInt32(dataRowView.Row.ItemArray[0]),//pegar id do usuario
                                IdOperacao = 1,
                                IdSituacao = 1,
                                IdEmprestimo = 0,
                                IdLivro = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value.ToString()),
                                Id_FuncionarioCadastro = UserLoginCache.Id_Funcionario,
                                // DataAtual = DateTime.ParseExact(dateTimePicker1.Text, "dd/MM/yyyy", null),
                                DataAtual = Convert.ToDateTime(dateTimePicker1.Text),
                                DataEntregou = Convert.ToDateTime(dateTimePicker2.Text),

                            };

                            CN_EmprestimoProfessor objetoCN = new CN_EmprestimoProfessor();
                            retorno = objetoCN.InserirEmprestimoprofessor(objetoCT);


                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Não foi possivel inserir  por: " + ex);
                        }

                    }

                        try
                        {
                            int IdProfessor = Convert.ToInt32(retorno);
                            MessageBox.Show($"Empréstimo efetuado com sucesso");

                            //atualiza os forms    
                            dataGridView1.Rows.Clear();
                            //dando erro aqui
                            // ComboLivro();
                            // ComboProfessor();
                            this.Close();

                        }
                        catch (FormatException)
                        {
                            //condição para verificar os emprestimos pendentes

                            string message = retorno + "  Livro  " + dataRowViewLivros.Row.ItemArray[1];
                            string caption = "Alerta";
                            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                            DialogResult result;

                            result = MessageBox.Show(message, caption, buttons);
                            if (result == System.Windows.Forms.DialogResult.Yes)
                            {
                                new EmprestimosPendentes().ShowDialog();
                            }
                            //MessageBox.Show(retorno);
                            //throw;

                        }
                }
            }
            else
            {
                MessageBox.Show("Selecione no minimo um item para inserir o empréstimo");
            }
        }




 //--------------------------------------------------COMBOBOX SELECTED-------------------------------------------------

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {                 
            var dataRowView = this.comboBox1.SelectedItem as DataRowView;
            label13.Text = Convert.ToString(dataRowView.Row.ItemArray[1]);
            //---id usuario
            comboBoxCodigoUsuario.Text = Convert.ToString(dataRowView.Row.ItemArray[0]);                  
        }
        private void comboBoxCodigoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > -1)
            {
                var dataRowView = this.comboBoxCodigoUsuario.SelectedItem as DataRowView;
                label13.Text = Convert.ToString(dataRowView.Row.ItemArray[1]);
                comboBox1.Text = Convert.ToString(dataRowView.Row.ItemArray[1]);
            }

        }


//----------------------------LIVRO--------------------------
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var dataRowViewLivros = comboBox2.SelectedItem as DataRowView;//combo box livros                     
                label5.Text = Convert.ToString(dataRowViewLivros.Row.ItemArray[8]);//exibe a quantdade no label
                comboBoxCodigoLivro.Text  = Convert.ToString(dataRowViewLivros.Row.ItemArray[0]);
            AtualizaQtdMaxima();
       
        }

        private void comboBoxCodigoLivro_SelectedIndexChanged(object sender, EventArgs e)
        {
           var dataRowViewLivros = this.comboBox2.SelectedItem as DataRowView;//combo box livros
            label5.Text = Convert.ToString(dataRowViewLivros.Row.ItemArray[8]);//exibe a quantdade no label
            comboBox2.Text = Convert.ToString(dataRowViewLivros.Row.ItemArray[1]);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.SelectAll();
        }
       
        //botao remover itens
        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                while (dataGridView1.RowCount > 0)
                {
                    dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                    int o = Convert.ToInt32(label5.Text) + 1;
                    label5.Text = Convert.ToString(o);
                }
            }
            else
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToDateTime(dateTimePicker1.Value.Date) < DateTime.Now.Date)
            {
                MessageBox.Show("Selecione uma data valida");
                dateTimePicker1.Value = DateTime.Now;
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToDateTime(dateTimePicker2.Value.Date) < DateTime.Now.Date)
            {
                MessageBox.Show("Selecione uma data valida");
                dateTimePicker2.Value = DateTime.Now;
            }
        }



        //inserir ao teclar enter
        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                InserirItemNalista();

        }
        private void comboBoxCodigoLivro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                InserirItemNalista();

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                dateTimePicker2.Enabled = true;
            }
            else
            {
                dateTimePicker2.Enabled = false;
            }
        }
    }
}
