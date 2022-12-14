using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using urnaEletronicaTCC.Models;

namespace urnaEletronicaTCC.Controllers
{
    internal class CadastroController
    {
        MySqlConnection conexao = new MySqlConnection();

        public CadastroController()
        {
            conexao = Conexao.Conectar();
        }

        public bool salvarCadastro(Cadastro save)
        {   

            try
            {
                conexao.Open();
               /*MySqlCommand x = new MySqlCommand("SELECT id_user,nome,numero,curso,foto FROM cadastro WHERE numero=@numero", conexao);
               x.Parameters.AddWithValue("@numero", save.numero);
                if(!x.row)
                {
                    return false;
                } */
                MySqlCommand cmd = new MySqlCommand("INSERT INTO cadastro (nome,numero,curso,foto) " +
                                                        "VALUES (@nome,@numero,@curso,@foto)", conexao);

                cmd.Parameters.AddWithValue("@nome", save.nome);
                cmd.Parameters.AddWithValue("@numero", save.numero);
                cmd.Parameters.AddWithValue("@curso", save.curso);
                cmd.Parameters.AddWithValue("@foto", save.foto);
                cmd.ExecuteNonQuery();

                return true;

            }
            catch (MySqlException)
            {
                MessageBox.Show("Número já existe");
                return false;

             
            }
            finally
            {
                conexao.Close();
            }

        }
        public DataTable exibirCandidatos()
        {
            DataTable dt = new DataTable();

            try
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT nome,numero,curso,votos FROM cadastro ORDER BY votos desc", conexao);
             
                
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


        public DataTable exibirDados(Cadastro dados)
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


        public DataTable confirmarVoto(Cadastro voto)
        {
            DataTable dt = new DataTable();

            try
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE cadastro SET votos=votos+1 WHERE numero=@numero", conexao);
                cmd.Parameters.AddWithValue("@numero", voto.numero);

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
