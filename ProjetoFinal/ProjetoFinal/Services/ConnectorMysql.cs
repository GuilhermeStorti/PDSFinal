using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProjetoFinal.Services
{
    public static class ConnectorMysql
    {
        

        public static MySqlConnection Open()
        {
            try
            {
                MySqlConnection Con = new MySqlConnection();
                String sCon = "Server=localhost;Database=banco_pds;Uid=root;";                
                Con.ConnectionString = sCon;
                Con.Open();
                return Con;
            }
            catch
            {
                return null;
            }
        }

        public static Boolean Close(MySqlConnection Con)
        {
            try
            {
                Con.Close();
                return true;
            }
            catch 
            {
                return false;
            }
            
        }
    }
}
