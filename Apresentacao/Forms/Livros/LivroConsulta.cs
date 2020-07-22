using CamadaTransferencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlMs.Forms
{
    public partial class LivroConsulta : Form
    {
        public LivroConsulta()
        {
            InitializeComponent();
        }
        bool situacao;
        bool disponibilidade;
        public LivroConsulta(Livro livro)
        {
            InitializeComponent();

            //desabilitar os forms
            Utilidades funcao = new Utilidades();
            funcao.EnableForms(this.panel1.Controls);
            funcao.EnableForms(this.groupBox1.Controls);
            funcao.EnableForms(this.groupBox2.Controls);

            label10.Text = Convert.ToString(livro.Id_Livro);
            textNomeLivro.Text = livro.Nome_Livro;
            textClassifica.Text = livro.Classificacao_Livro;
            textAutor.Text = livro.Autor_Livro;
            textAno.Text = livro.Ano_Livro;
            textGenero.Text = livro.Genero_Livro;
            textEditora.Text = livro.Editora_Livro;
            textPag.Text = Convert.ToString(livro.Paginas_Livro);
            TextQuantidade.Text = Convert.ToString(livro.Quantidade_Livro);
            textForm.Text = livro.FormaRecebimento;
            textCod.Text = Convert.ToString(livro.Codigo_Livro);
            textVolume.Text = livro.Volume;
            textLocal.Text = livro.LocalizacaoEstante;
            situacao = livro.Status_Livro;
            if (situacao == true)
            {

                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }

            disponibilidade = livro.Disponibilidade;
            if (disponibilidade == true)
            {
                radioButton4.Checked = true;
            }
            else
            {
                radioButton3.Checked = true;
            }

        }
    }
}
