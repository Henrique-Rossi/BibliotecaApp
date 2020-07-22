using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaTransferencia
{
    public  class Funcionarios:Pessoa
    {
        private int idFuncionario;
        private string sexo;
        private string loginUsuario;
        private string senhaUsuario;
        private DateTime dataCadastro;
        private DateTime dataAlteracao;
        private DateTime dataNascimento;
        private string descricao;
       // private string email;
        private string numero;
        private Restricoes restricoes;
        public int IdFuncionario { get => idFuncionario; set => idFuncionario = value; }
        public string Sexo1 { get => sexo; set => sexo = value; }
        public string LoginUsuario { get => loginUsuario; set => loginUsuario = value; }
        public string SenhaUsuario { get => senhaUsuario; set => senhaUsuario = value; }
        public DateTime DataCadastro { get => dataCadastro; set => dataCadastro = value; }
        public DateTime DataAlteracao { get => dataAlteracao; set => dataAlteracao = value; }
        public DateTime DataNascimento { get => dataNascimento; set => dataNascimento = value; }
        public string Descricao { get => descricao; set => descricao = value; }
       // public string Email1 { get => email; set => email = value; }
        public string Numero { get => numero; set => numero = value; }
        public Restricoes Restricoes { get => restricoes; set => restricoes = value; }
    }
}
