using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoFinal.Services;
using MySql.Data.MySqlClient;
using ProjetoFinal.Models;
using System.Data;

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

                Int32 resposta = query.ExecuteNonQuery();

                if (resposta > 0)
                {
                    query.CommandText = "SELECT * FROM usuario u WHERE u.login = '@login' AND u.senha = '@senha'";
                    MySqlDataReader reader = query.ExecuteReader();
                    usuario.idUsuario = (long)reader["id_usuario"];
                    usuario.nome = (String)reader["nome"];
                    usuario.login = (String)reader["login"];
                    usuario.senha = (String)reader["senha"];
                    usuario.telefone = (String)reader["telefone"];
                    usuario.email = (String)reader["email"];
                    usuario.cpf = (String)reader["cpf"];
                    usuario.idEndereco = (long)reader["id_endereco"];
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
