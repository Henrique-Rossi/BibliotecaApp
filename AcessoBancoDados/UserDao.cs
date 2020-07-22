using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ViewUser.Cache;

namespace AcessoBancoDados
{
    
    public class UserDao : ConexaoBd
    { 
        
        public bool Login(string user, string pass)
        {
            using (var connection = AbrirConexao())
            {
                
                using (var comand = new SqlCommand()) {
                    comand.Connection = connection;
                    comand.CommandText = "USP_FuncionariosRestricoes";
                    //comand.CommandText = "select * from tbUser Where LoginName=@user and Passoword=@pass";
                    comand.Parameters.AddWithValue("@user", user);
                    comand.Parameters.AddWithValue("@pass", pass);
                    comand.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = comand.ExecuteReader();

                    if (reader.HasRows)
                    {                   
                        while (reader.Read())
                        {   
                              UserLoginCache.Id_Funcionario = reader.GetInt32(0);
                              UserLoginCache.Email          = reader.GetString(1);
                              UserLoginCache.Nome           = reader.GetString(2);
                              UserLoginCache.SEXO           = reader.GetString(3);
                              UserLoginCache.DataCadastro   = reader.GetDateTime(6);
                              UserLoginCache.DataAlteracao  = reader.GetDateTime(7);
                              UserLoginCache.CPF            = reader.GetString(8);
                              UserLoginCache.Descricao      = reader.GetString(9);
                              UserLoginCache.Endereco       = reader.GetString(10);
                              UserLoginCache.Numero         = reader.GetString(11);
                              UserLoginCache.Bairro         = reader.GetString(12);
                              UserLoginCache.Complemento    = reader.GetString(13);
                              UserLoginCache.DataNascimento = reader.GetDateTime(14);
                              UserLoginCache.Telefone       = reader.GetString(15);                          
                              UserLoginCache.Situacao       = reader.GetBoolean(16);
                             //cidade 17 
                             //estado 18
                             //Disponibilidade 19
                             //Cep 20                       
                              UserLoginCache.BackupExp      = reader.GetBoolean(21);
                              UserLoginCache.BackupImp      = reader.GetBoolean(22);
                              UserLoginCache.Cadastro       = reader.GetBoolean(23);
                              UserLoginCache.CadastroFunc   = reader.GetBoolean(24);
                              UserLoginCache.Consultas      = reader.GetBoolean(25);
                              UserLoginCache.Emprestimos    = reader.GetBoolean(26);
                              UserLoginCache.Relatorios     = reader.GetBoolean(27);
                              UserLoginCache.Devolucao      = reader.GetBoolean(28);//vai dar erro se  alguns desses campos estiverem nulls
                              UserLoginCache.Renovacao      = reader.GetBoolean(29);

                        }
                        return true;
                    }                               
                    else
                    {
                        return false;
                    }
                }
            }
        }
       
       
    }
   
}