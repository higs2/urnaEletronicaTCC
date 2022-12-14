using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using urnaEletronicaTCC.Models;

namespace urnaEletronicaTCC.Controllers
{
    internal class GestaoController
    {
        MySqlConnection conexao = new MySqlConnection();


        public DataTable GestaoClass(Gestao dados)
        {
            DataTable dt = new DataTable();

            try
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM cadastro WHERE numero=@numero", conexao);
                cmd.Parameters.AddWithValue("@numero", dados.numero);

                MySqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
                return dt;

            }
            catch (Exception)
            {

                return dt;
            }
            finally
            {
                conexao.Close();
            }

        }
    }
}
