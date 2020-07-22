using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaTransferencia
{
   public class Livro
   {
        private int id_Livro;
        private string nome_Livro;
        private string autor_Livro;
        private string ano_Livro;
        private string genero_Livro;
        private string editora_Livro;
        private Int16  paginas_Livro;
        private bool status_Livro;
        private int  quantidade_Livro;
        private int  codigo_Livro;
        private string classificacao_Livro;
        private int id_FuncionarioCadastro;
        private DateTime datacadastro;
        private DateTime dataAlteracao;
        private string formaRecebimento;
        private string volume;
        private string localizacaoEstante;
        private bool disponibilidade;

        public int Id_Livro { get => id_Livro; set => id_Livro = value; }
        public string Nome_Livro { get => nome_Livro; set => nome_Livro = value; }
        public string Autor_Livro { get => autor_Livro; set => autor_Livro = value; }
       
        public string Genero_Livro { get => genero_Livro; set => genero_Livro = value; }
        public string Editora_Livro { get => editora_Livro; set => editora_Livro = value; }
       
        public bool Status_Livro { get => status_Livro; set => status_Livro = value; }
        public int Quantidade_Livro { get => quantidade_Livro; set => quantidade_Livro = value; }
        public int Codigo_Livro { get => codigo_Livro; set => codigo_Livro = value; }
        public string Classificacao_Livro { get => classificacao_Livro; set => classificacao_Livro = value; }
        public int Id_FuncionarioCadastro { get => id_FuncionarioCadastro; set => id_FuncionarioCadastro = value; }
        public DateTime Datacadastro { get => datacadastro; set => datacadastro = value; }
        public DateTime DataAlteracao { get => dataAlteracao; set => dataAlteracao = value; }
        public string FormaRecebimento { get => formaRecebimento; set => formaRecebimento = value; }
        public string Volume { get => volume; set => volume = value; }
        public string LocalizacaoEstante { get => localizacaoEstante; set => localizacaoEstante = value; }
      
        public string Ano_Livro { get => ano_Livro; set => ano_Livro = value; }
        public bool Disponibilidade { get => disponibilidade; set => disponibilidade = value; }
        public short Paginas_Livro { get => paginas_Livro; set => paginas_Livro = value; }
    }
}
