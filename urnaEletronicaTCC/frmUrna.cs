using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Media;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using urnaEletronicaTCC.Controllers;
using urnaEletronicaTCC.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace urnaEletronicaTCC
{
    public partial class frmUrna : Form
    {
        public frmUrna()
        {
            InitializeComponent();
        }
        MySqlConnection conexao = new MySqlConnection();
        public string digitoConcatenadao;
        public string numeros;
        
        private void frmUrna_Load(object sender, EventArgs e)
        {
            
        }


        private void btn1_Click(object sender, EventArgs e)
        {
            RegistrarDigito("1");
          

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            RegistrarDigito("2");
        }


        private void btn3_Click(object sender, EventArgs e)
        {

            RegistrarDigito("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            RegistrarDigito("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            RegistrarDigito("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            RegistrarDigito("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            RegistrarDigito("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            RegistrarDigito("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            RegistrarDigito("9");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            RegistrarDigito("0");
        }


        private void RegistrarDigito(string digito)
        {
            
            if (string.IsNullOrEmpty(txt1.Text))
            {
                txt1.Text = digito;

            }
               
            else
            {
                txt2.Text =  digito;
                
            }

            
        }

      

        private void txt2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Cadastro dados = new Cadastro( txtNome.Text,txt2.Text,txtCurso.Text,txtFoto.Text);
                conexao = Conexao.Conectar();
                
                CadastroController cadastro = new CadastroController();
                DataTable dt = new DataTable();
                DataRow dataRow;
                int cont = 0;
                dt = cadastro.exibirDados(dados);

                // dt.Rows[0]["curso"].ToString();             
                             
                while (cont <= dt.Rows.Count)
                {
                    
                    dataRow = dt.Rows[cont];
                    txtNome.Text = dataRow["nome"].ToString();
                    txtCurso.Text = dataRow["curso"].ToString();
                    pbFoto.Image = Image.FromFile(dataRow["foto"].ToString());
                    
                    cont++;
                }



            }
            catch (Exception)
            {
                return;

            }
            finally
            {
                conexao.Close();


            }
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {

           
        }

        private void btnCorrigir_Click(object sender, EventArgs e)
        {
            txt1.Clear();
            txt2.Clear();
          
            txtNome.Clear();
            txtCurso.Clear();
            pbFoto.Image = null;

        }


    }
}
