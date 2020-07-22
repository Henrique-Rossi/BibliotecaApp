using AcessoBancoDados;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class CN_Estado
    {
        ConexaoBd conexao = new ConexaoBd();

        public DataTable ComboBoxEstado()
        {
            try
            {
                DataTable table = new DataTable();
                conexao.LimparParametros();
                table= conexao.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultarEstado");
                return table;
            }
            catch (Exception ex)
            {
                throw new Exception("Sem dados." + ex.Message);
            }
        }
    }
}
