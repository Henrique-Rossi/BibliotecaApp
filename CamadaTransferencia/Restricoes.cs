using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaTransferencia
{
    public class Restricoes
    {
        private bool emprestimos;
        private bool backupEx;
        private bool backupIm;
        private bool cadastro;
        private bool cadastroFunc;
        private bool relatorios;
        private bool devolucao;
        private bool renovacao;
        private bool consulta;
        private int idFuncionario;
        public bool Emprestimos { get => emprestimos; set => emprestimos = value; }
        public bool BackupEx { get => backupEx; set => backupEx = value; }
        public bool BackupIm { get => backupIm; set => backupIm = value; }
        public bool Cadastro { get => cadastro; set => cadastro = value; }
        public bool CadastroFunc { get => cadastroFunc; set => cadastroFunc = value; }
        public bool Relatorios { get => relatorios; set => relatorios = value; }
        public bool Devolucao { get => devolucao; set => devolucao = value; }
        public bool Renovacao { get => renovacao; set => renovacao = value; }
        public bool Consulta { get => consulta; set => consulta = value; }
        public int IdFuncionario { get => idFuncionario; set => idFuncionario = value; }
    }
   
}              