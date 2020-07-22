using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaTransferencia
{
    public class EmprestimoExternos: Emprestimo
    {
        private int  idExterno;

        public int IdExterno { get => idExterno; set => idExterno = value; }
    }
}
