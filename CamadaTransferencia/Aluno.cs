using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaTransferencia
{
    public class Aluno : Pessoa
    {
        private int idAluno;
        private string matricula;
        private string turma;
        private string turno;
        private string grau;
        private string descricao;
        private string telefoneResponsavel;
        private int numeroend;
        private DateTime dataNascimento;
        private int id_FuncionarioCadastro;
        private DateTime dataCadastro;
        private DateTime dataAlteracao;
        private Funcionarios funcionarios;
        public string Matricula { get => matricula; set => matricula = value; }
        public string Turma { get => turma; set => turma = value; }
        public string Turno { get => turno; set => turno = value; }
        public string Grau { get => grau; set => grau = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string TelefoneResponsavel { get => telefoneResponsavel; set => telefoneResponsavel = value; }
        public int IdAluno { get => idAluno; set => idAluno = value; }
        public int Numeroend { get => numeroend; set => numeroend = value; }
        public DateTime DataNascimento { get => dataNascimento; set => dataNascimento = value; }
        public int Id_FuncionarioCadastro { get => id_FuncionarioCadastro; set => id_FuncionarioCadastro = value; }
        public DateTime DataCadastro { get => dataCadastro; set => dataCadastro = value; }
        public DateTime DataAlteracao { get => dataAlteracao; set => dataAlteracao = value; }
        public Funcionarios Funcionarios { get => funcionarios; set => funcionarios = value; }
    }
}
