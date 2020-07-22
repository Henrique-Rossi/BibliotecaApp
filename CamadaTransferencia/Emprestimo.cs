using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaTransferencia
{
    public class Emprestimo
    {
        private int idEmprestimo;
        private int idOperacao;
        private int idSituacao;
        private int id_FuncionarioCadastro;
        private int idLivro;
        private DateTime dataSaida;
        private DateTime dataAtual;
        private DateTime dataEntregou;
        private DateTime dataProcesso;

        public int IdEmprestimo { get => idEmprestimo; set => idEmprestimo = value; }
        public int IdOperacao { get => idOperacao; set => idOperacao = value; }
        public int IdSituacao { get => idSituacao; set => idSituacao = value; }
        public int Id_FuncionarioCadastro { get => id_FuncionarioCadastro; set => id_FuncionarioCadastro = value; }
        public int IdLivro { get => idLivro; set => idLivro = value; }
        public DateTime DataSaida { get => dataSaida; set => dataSaida = value; }
        public DateTime DataEntregou { get => dataEntregou; set => dataEntregou = value; }
        public DateTime DataProcesso { get => dataProcesso; set => dataProcesso = value; }
        public DateTime DataAtual { get => dataAtual; set => dataAtual = value; }
    }
}
