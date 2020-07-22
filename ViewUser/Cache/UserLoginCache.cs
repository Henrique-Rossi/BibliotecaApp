using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewUser.Cache
{//aqui salva os dados em cache na area de view
    public static class UserLoginCache
    {
       
        
         public static int Id_Funcionario { get; set; }
         public static string Email { get; set; }
         public static string Nome { get; set; }
         public static string SEXO { get; set; }
         public static DateTime DataCadastro { get; set; }
         public static DateTime DataAlteracao { get; set; }
         public static string CPF { get; set; }
         public static string Descricao { get; set; }
         public static string Endereco { get; set; }
         public static string Numero { get; set; }
         public static string Bairro { get; set; }
         public static string Complemento { get; set; }
         public static DateTime DataNascimento { get; set; }
         public static string Telefone { get; set; }
         public static bool Situacao { get; set; }       
         public static bool BackupExp { get; set; }
         public static bool BackupImp { get; set; }
         public static bool Cadastro { get; set; }    
         public static bool CadastroFunc { get; set; }
         public static bool Consultas { get; set; }
         public static bool Emprestimos { get; set; }
         public static bool Relatorios { get; set; }
         public static bool Devolucao { get; set; }
         public static bool Renovacao { get; set; }












    }
}
