﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                MySqlCommand cmd = new MySqlCommand("INSERT INTO cadastro (nome,numero,curso,foto) " +
                                                        "VALUES (@nome,@numero,@curso,@foto)", conexao);

                cmd.Parameters.AddWithValue("@nome", save.nome);
                cmd.Parameters.AddWithValue("@numero", save.numero);
                cmd.Parameters.AddWithValue("@curso", save.curso);
                cmd.Parameters.AddWithValue("@foto", save.foto);
                cmd.ExecuteNonQuery();

                return true;

            }
            catch (Exception)
            {
                return false;
             
            }
            finally
            {
                conexao.Close();
            }

        }
    }
}