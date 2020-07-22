using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaTransferencia
{
   public class Externo:Pessoa
    {
        private int idExterno;
        private int id_FuncionarioCadastro;
        private DateTime dataCadastro;
        private DateTime dataAlteracao;
        private DateTime dataNascimento;
        private string descricao;
        private string numero;
        private Funcionarios funcionarios;
        private string pais;
        public int IdExterno { get => idExterno; set => idExterno = value; }
       
        public DateTime DataCadastro { get => dataCadastro; set => dataCadastro = value; }
        public DateTime DataAlteracao { get => dataAlteracao; set => dataAlteracao = value; }
        public DateTime DataNascimento { get => dataNascimento; set => dataNascimento = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public int Id_FuncionarioCadastro { get => id_FuncionarioCadastro; set => id_FuncionarioCadastro = value; }
        public string Numero { get => numero; set => numero = value; }
        public Funcionarios Funcionarios { get => funcionarios; set => funcionarios = value; }
        public string Pais { get => pais; set => pais = value; }
    }
}
 