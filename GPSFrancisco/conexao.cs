using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;
using MySql.Data.MySqlClient;

namespace GPSFrancisco
{
    public class conexao
    {
        private static string Conexao = "Server=localhost; Port=3306; DataBase=dbfrancisco; Uid=root; Pwd=''";
        private static MySqlConnection conn = null;

        public static MySqlConnection ObterConexao()
        {
            conn = new MySqlConnection(Conexao);
            try
            {
                conn.Open();
            }
            catch (MySqlException) 
            {
                return conn = null;
            }
             return conn;
       }

        public static void FecharConexao() 
        {
            if (conn != null) 
            {
                conn.Close();   
            }
        }
    }
}
