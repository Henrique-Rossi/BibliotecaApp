using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaTransferencia
{
    public class EmprestimoAluno : Emprestimo
    {
        private int id_Aluno;
        private Aluno aluno;
        private Livro livro;
        public int Id_Aluno { get => id_Aluno; set => id_Aluno = value; }
        public Aluno Aluno { get => aluno; set => aluno = value; }
        public Livro Livro { get => livro; set => livro = value; }
    }
}
