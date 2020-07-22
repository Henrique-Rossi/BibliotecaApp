using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaTransferencia
{
    public class Professor : Pessoa 
    {
        
        private int idprofessor;    
        private string codigoprofessor;
        private int id_FuncionarioCada;  
        private DateTime dataCadastro;
        private DateTime dataAlteracao;
        private DateTime dataNascimento;
        private string numeroEndereco;
        private Funcionarios funcionarios;
        //private Cidade cidades;
        public int Idprofessor { get => idprofessor; set => idprofessor = value; }                   
        public string Codigoprofessor { get => codigoprofessor; set => codigoprofessor = value; }    
        public int Id_FuncionarioCada { get => id_FuncionarioCada; set => id_FuncionarioCada = value; }         
        public DateTime DataCadastro { get => dataCadastro; set => dataCadastro = value; }
        public DateTime DataAlteracao { get => dataAlteracao; set => dataAlteracao = value; }
        
        public DateTime DataNascimento { get => dataNascimento; set => dataNascimento = value; }

        public string NumeroEndereco
        {
            get
            {
                return numeroEndereco;
            }

            set
            {
                numeroEndereco = value;
            }
        }

        public Funcionarios Funcionarios { get => funcionarios; set => funcionarios = value; }
        //public Cidade Cidades { get => cidades; set => cidades = value; }
    }
}
