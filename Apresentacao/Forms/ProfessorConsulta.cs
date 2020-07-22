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
    public partial class ProfessorConsulta : Form
    {
        public ProfessorConsulta()
        {
            InitializeComponent();
        }
        
        Professor professorOriginal = new Professor();
        public ProfessorConsulta( Professor professor)
        {
            InitializeComponent();
            professorOriginal = professor;
            label6.Text    = professor.IdProfessor.ToString();
            txtNome.Text   = professor.Nome.ToString();
            txtBairro.Text = professor.Bairro.ToString();
            txtCep.Text    = professor.Cep.ToString();
            txtCidade.Text = professor.Cidade.ToString();
            txtCodi.Text   = professor.CodigoProfessor.ToString();
            txtCpf.Text    = professor.Cpf.ToString();
            txtEnde.Text   = professor.Endereco.ToString();
            txtEstado.Text = professor.Estado.ToString();
            txtNasc.Text   = professor.DataNascimento.ToString();
            txtNum.Text    = professor.NumeroEndereco.ToString();
            mtxtTel.Text   = professor.Telefone.ToString();
            if (professor.Sexo)
                radioBtnSexoM.Checked = true;
            else
                radioBtnSexoF.Checked = true;
           // return professorOriginal.ToString();

        }
    }
}
