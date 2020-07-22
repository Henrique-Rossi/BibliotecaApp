using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaTransferencia
{
    public class Pessoa 
    {//so utileze os campos padroes com mesmo nome aqui
            private string nome;
            private string endereco;
             
            private string bairro;          
            private string cep;
            //private Cidade cidade;
            private string cidade;
            private string complemento;
            private string estado;
            private string telefone;
            private bool sexo;
            private string email;
            private string cpf;
            private bool situacao;
            private bool disponibilidade;


            public string Nome
            {
                get
                {
                    return nome;
                }

                set
                {
                    nome = value;
                }
            }

            public string Endereco
            {
                get
                {
                    return endereco;
                }

                set
                {
                    endereco = value;
                }
            }

            

            public string Bairro
            {
                get
                {
                    return bairro;
                }

                set
                {
                    bairro = value;
                }
            }
      

            public string Cep
            {
                get
                {
                    return cep;
                }

                set
                {
                    cep = value;
                }
            }
          

        
        public bool Sexo { get => sexo; set => sexo = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        
        public string Cpf { get => cpf; set => cpf = value; }
        public bool Situacao { get => situacao; set => situacao = value; }
        public bool Disponibilidade { get => disponibilidade; set => disponibilidade = value; }
        public string Email { get => email; set => email = value; }
        public string Complemento { get => complemento; set => complemento = value; }
       // public Cidade Cidade { get => Cidade1; set => Cidade1 = value; }
        public string Cidade { get => cidade; set => cidade = value; }
    }
}

