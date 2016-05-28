using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoFinal.Services;
using MySql.Data.MySqlClient;
using ProjetoFinal.Models;
using System.Data;
using ProjetoFinal.Utils;

namespace ProjetoFinal.Services
{
    public static class UsuarioDAO
    {
        public static Usuario validaUsuario(String login, String senha)
        {
            MySqlConnection Con = ConnectorMysql.Open();
            if (Con != null)
            {
                Usuario usuario = new Usuario();
                MySqlCommand query = Con.CreateCommand();
                query.CommandText = "SELECT * FROM usuario u WHERE u.login = @login AND u.senha = @senha";
                query.CommandType = CommandType.Text;
                query.Parameters.AddWithValue("@login", login);
                query.Parameters.AddWithValue("@senha", senha);

                MySqlDataReader reader = query.ExecuteReader();

                if (reader.Read())
                {
                    query.CommandText = "SELECT * FROM usuario u WHERE u.login = '@login' AND u.senha = '@senha'";
                    //MySqlDataReader reader = query.ExecuteReader();
                    usuario.idUsuario = reader["id_usuario"] == DBNull.Value ? 0 : (Int64) reader["id_usuario"];
                    usuario.nome = reader["nome"] == DBNull.Value ? null : reader["nome"].ToString();
                    usuario.login = reader["login"] == DBNull.Value ? null : reader["login"].ToString();
                    usuario.senha = reader["senha"] == DBNull.Value ? null : reader["senha"].ToString();
                    usuario.telefone = reader["telefone"] == DBNull.Value ? null : reader["telefone"].ToString();
                    usuario.email = reader["email"] == DBNull.Value ? null : reader["email"].ToString();
                    usuario.cpf = reader["cpf"] == DBNull.Value ? null : reader["cpf"].ToString();
                    usuario.idEndereco = reader["id_endereco"] == DBNull.Value ? 0 : (Int64)reader["id_endereco"];
                    return usuario;
                }
                else
                {
                    return null;
                }
            }
            else 
            {
                return null;
            }            
        }
    }
}
