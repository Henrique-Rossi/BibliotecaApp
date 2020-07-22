using AcessoBancoDados;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class CN_Cidade
    {
        ConexaoBd conexao = new ConexaoBd();

        public DataTable ComboBoxCidade(string estado)
        {
            DataTable table = new DataTable();
            conexao.LimparParametros();
            conexao.AdicionarParametros("@Estado", estado);
            table = conexao.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultarCidade");
            return table;
        }
    }
}
