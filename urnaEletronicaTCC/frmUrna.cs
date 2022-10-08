using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using urnaEletronicaTCC.Controllers;
using urnaEletronicaTCC.Models;

namespace urnaEletronicaTCC
{
    public partial class frmUrna : Form
    {
        public frmUrna()
        {
            InitializeComponent();
        }
        MySqlConnection conexao = new MySqlConnection();


        private void frmUrna_Load(object sender, EventArgs e)
        {

        }
        
       
    

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "")
            {
                txt1.Text = "1";
                
            }
            else
            {
                txt2.Text = "1";
                
               
    
            }
            string num = lblNumero.Text;
            if (num.Length >= 0)
            {
                lblNumero.Text = lblNumero.Text +  "1";
                
           
            }

            /*
            try
            {

                conexao = Conexao.Conectar();
                MySqlCommand cmd = new MySqlCommand("SELECT nome,curso,foto FROM cadastro WHERE numero=1", conexao);
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@id_user", MySqlDbType.Int32).Value = lblNumero.Text;

                cmd.CommandType = CommandType.Text;

                MySqlDataReader dr;
                dr = cmd.ExecuteReader();
                dr.Read();

                lblNome.Text = dr.GetString(0);
                lblCurso.Text = dr.GetString(1);
                pbFoto.Text = dr.GetString(2);
            }
            catch (Exception)
            {

                return;
            }
            finally
            {
                conexao.Close();
            }
            */
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "")
            {
                txt1.Text = "2";
               
            }
            else
            {
                txt2.Text = "2";          

            }

            string num = lblNumero.Text;
            if (num.Length >= 0)
            {
                lblNumero.Text = lblNumero.Text + "2";

            }
        }

        private void btnCorrigir_Click(object sender, EventArgs e)
        {
            txt1.Clear();
            txt2.Clear();
            lblNumero.Text = "";
            txtNome.Clear();
            txtCurso.Clear();

        }

        private void btn3_Click(object sender, EventArgs e)
        {
          
            if (txt1.Text == "")
            {
                txt1.Text = "3";
               
            }
            else
            {
                txt2.Text = "3";
              
            }

            string num = lblNumero.Text;
            if (num.Length >= 0)
            {
                lblNumero.Text = lblNumero.Text + "3";

            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "")
            {
                txt1.Text = "4";
            }
            else
            {
                txt2.Text = "4";
            }

            string num = lblNumero.Text;
            if (num.Length >= 0)
            {
                lblNumero.Text = lblNumero.Text + "4";

            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "")
            {
                txt1.Text = "5";
            }
            else
            {
                txt2.Text = "5";
            }

            string num = lblNumero.Text;
            if (num.Length >= 0)
            {
                lblNumero.Text = lblNumero.Text + "5";

            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "")
            {
                txt1.Text = "6";
            }
            else
            {
                txt2.Text = "6";
            }

            string num = lblNumero.Text;
            if (num.Length >= 0)
            {
                lblNumero.Text = lblNumero.Text + "6";

            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "")
            {
                txt1.Text = "7";
            }
            else
            {
                txt2.Text = "7";
            }

            string num = lblNumero.Text;
            if (num.Length >= 0)
            {
                lblNumero.Text = lblNumero.Text + "7";

            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "")
            {
                txt1.Text = "8";
            }
            else
            {
                txt2.Text = "8";
            }

            string num = lblNumero.Text;
            if (num.Length >= 0)
            {
                lblNumero.Text = lblNumero.Text + "8";

            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "")
            {
                txt1.Text = "9";
            }
            else
            {
                txt2.Text = "9";
            }

            string num = lblNumero.Text;
            if (num.Length >= 0)
            {
                lblNumero.Text = lblNumero.Text + "9";

            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "")
            {
                txt1.Text = "0";
            }
            else
            {
                txt2.Text = "0";
            }

            string num = lblNumero.Text;
            if (num.Length >= 0)
            {
                lblNumero.Text = lblNumero.Text + "0";

            }
        }


        private void txt2_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conexao = Conexao.Conectar();

                CadastroController cadastro = new CadastroController();
                DataTable dt = new DataTable();
                DataRow dataRow;
                int cont = 0;
                dt = cadastro.exibirCandidatos();
                // dt.Rows[0]["curso"].ToString();
                while (cont <= dt.Rows.Count)
                {
                    dataRow = dt.Rows[cont];
                    txtNome.Text = Convert.ToString(dataRow["nome"]);
                    txtCurso.Text = Convert.ToString(dataRow["curso"]);
                    pbFoto.Image = Properties.Resources.VOTACAO;
                    cont++;
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conexao.Close();


            }
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {

           
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
