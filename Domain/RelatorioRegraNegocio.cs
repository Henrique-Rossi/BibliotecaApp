using AcessoBancoDados;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
   public class RelatorioRegraNegocio
    {    ConexaoBd conexao = new ConexaoBd();
        public DataTable ListagemAlunos(int opcao, string nome, int situacao)
        {
            try
            {
                conexao.LimparParametros();
                conexao.AdicionarParametros("@Opcao", opcao);
               // conexao.AdicionarParametros("@Disponibilidade",disponibilidade);
                conexao.AdicionarParametros("@Situacao", situacao);
                conexao.AdicionarParametros("@Texto", nome);
               
                DataTable dataTableAluno = conexao.ExecutarConsulta(CommandType.StoredProcedure, "USP_ViewAlunosRelatorio");
                return dataTableAluno;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar o aluno por  nome.Detalhes: " + ex.Message);
            }
        }
    }
}
