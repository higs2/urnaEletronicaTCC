using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace urnaEletronicaTCC
{
    internal class Conexao
    {

        private static MySqlConnection conexao;
        public static MySqlConnection Conectar()
        {
            string server = "localhost";
            string port = "3306";
            string username = "root";
            string password = "";
            string database = "urnadb";

            try
            {

                conexao = new MySqlConnection($"server={server};port={port};uid={username};password={password};database={database}");
                return conexao;

            }
            catch (MySqlException)
            {
                return null;
            }


        }
    }
}
