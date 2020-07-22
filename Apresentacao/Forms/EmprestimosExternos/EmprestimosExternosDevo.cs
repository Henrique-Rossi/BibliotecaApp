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
    public partial class EmprestimoExternosDevo : Form
    {
        public EmprestimoExternosDevo()
        {
            InitializeComponent();
        }
        int idExterno;
        int idEmprestimo;
        int idLivro;
        //exibir nomes que estao com emprestimos pendentes 
        private void EmprestimoExternosDevo_Load(object sender, EventArgs e)
        {
            ExibirConsultaExterno();
        }
            public void ExibirConsultaExterno()
            {
                CN_EmprestimoExternos objeto = new CN_EmprestimoExternos();
                dataGridViewExterno.DataSource = objeto.ConsultarexternosDevolu();

            }
                private void dataGridViewExterno_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
                {
                    var Row = dataGridViewExterno.CurrentRow;

                    idExterno = Convert.ToInt32(Row.Cells[0].Value);//pega o valor do id 

                    MostrarEmprestimoUnico();
                }

                    public void MostrarEmprestimoUnico()
                    {
                        CN_EmprestimoExternos objeto = new CN_EmprestimoExternos();
                        dataGridViewLista.DataSource = objeto.MostrarEmprestimoUnico(idExterno);
                    }

       
            private void dataGridViewLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
            {
                idEmprestimo = Convert.ToInt32(dataGridViewLista.CurrentRow.Cells["IdEmprestimo"].Value);//pega o valor do id emp
                idLivro = Convert.ToInt32(dataGridViewLista.CurrentRow.Cells["IdLivro"].Value);//pega o valor do id livro
                
            }

                private void buttonDevolver_Click(object sender, EventArgs e)
                {

                    //criar menssagem de confirmação 
                  
                    string messagem = "Tem Certeza que deseja Executar essa Devolução ?" + dataGridViewLista.CurrentRow.Cells["Nome_Livro"].Value.ToString(); ;
                    string captionn = "Alerta";
                    MessageBoxButtons buttonss = MessageBoxButtons.YesNo;
                    DialogResult resultt;

                    resultt = MessageBox.Show(messagem, captionn, buttonss);
                    if (resultt == System.Windows.Forms.DialogResult.Yes)
                    {
                        int contagem = dataGridViewLista.Rows.Count;

                        for (int i = 0; i < contagem; i++)
                        {
                            if (Convert.ToBoolean(dataGridViewLista.Rows[i].Cells["Column1"].Value) == true)
                            {
                                EmprestimoExternos objetoCT = new EmprestimoExternos
                                {
                                    IdEmprestimo = Convert.ToInt32(dataGridViewLista.Rows[i].Cells["IdEmprestimo"].Value),//pega o valor do id emp
                                    IdLivro = Convert.ToInt32(dataGridViewLista.Rows[i].Cells["Id_Livro"].Value),//pega o valor do id livro
                                    IdExterno = Convert.ToInt32(dataGridViewLista.Rows[i].Cells["IdExternos"].Value),

                                };

                                CN_EmprestimoExternos objetoCN = new CN_EmprestimoExternos();
                                objetoCN.Devolucao(objetoCT);



                            }
                        }

                        ExibirConsultaExterno();
                        MostrarEmprestimoUnico();
                        checkBox1.Checked = false;

                        MessageBox.Show("Devolução efetuada com sucesso");
                    }
                }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewLista.SelectAll();
            for (int i = 0; i < dataGridViewLista.Rows.Count; i++)
            {
                dataGridViewLista.Rows[i].Cells["Column1"].Value = true;
            }
        }

        private void dataGridViewLista_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataGridViewLista.CurrentRow.Cells["Column1"].Value = true;
        }
    }
}
