using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaTransferencia
{
    public class EmprestimoProfessor : Emprestimo
    {
        
       
        private int idProfessor;

        public int IdProfessor { get => idProfessor; set => idProfessor = value; }
    }
}
