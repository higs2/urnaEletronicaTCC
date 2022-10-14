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

    //update cadastro set votos=votos+1 where numero="4";

    //select nome, numero, votos from cadastro where votos is not null order by votos desc;


    public partial class frmUrna : Form
    {
        public frmUrna()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }
        MySqlConnection conexao = new MySqlConnection();
        public string digitoConcatenadao;
        public string numeros;

        private void frmUrna_Load(object sender, EventArgs e)
        {

        }


        private void btn1_Click(object sender, EventArgs e)
        {
            registrarDigito("1");



        }

        private void btn2_Click(object sender, EventArgs e)
        {
            registrarDigito("2");
        }


        private void btn3_Click(object sender, EventArgs e)
        {

            registrarDigito("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            registrarDigito("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            registrarDigito("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            registrarDigito("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            registrarDigito("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            registrarDigito("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            registrarDigito("9");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            registrarDigito("0");
        }


        private void registrarDigito(string digito)
        {

            if (string.IsNullOrEmpty(txt1.Text))
            {
                txt1.Text = digito;
              


            } else if (!string.IsNullOrEmpty(txt1.Text)) {
                txt2.Text = digito;
               
            }


        }



        private void txt2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Cadastro dados = new Cadastro(txtNome.Text, txt1.Text + txt2.Text, txtCurso.Text, txtFoto.Text);
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
            numeros = null;

            

        }

        private void btnBranco_Click(object sender, EventArgs e)
        {

        }

        private void txt1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void frmUrna_KeyPress(object sender, KeyPressEventArgs e)
        {
         

            switch (e.KeyChar)
            {
                case (char)48: 
                    txt1.Text = txt1.Text + "0";
                    
                    break;

                case (char)49:
                    txt1.Text = txt1.Text + "1";
                    break;
                case (char)50:
                    txt1.Text = txt1.Text + "2";
                    break;
                case (char)51:
                    txt1.Text = txt1.Text + "3";
                    break;

                case (char)52:
                    txt1.Text = txt1.Text + "4";
                    break;
                case (char)53:
                    txt1.Text = txt1.Text + "5";
                    break;
                case (char)54:
                    txt1.Text = txt1.Text + "6";
                    break;

                case (char)55:
                    txt1.Text = txt1.Text + "7";
                    break;
                case (char)56:
                    txt1.Text = txt1.Text + "8";
                    break;
                case (char)57:
                    txt1.Text = txt1.Text + "9";
                    break;

                default:

                    break;
            }
        }

        private void frmUrna_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txt2_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.NumPad0)
            {
                e.Handled = true;
                txt1.Clear();
                txt2.Clear();

                txtNome.Clear();
                txtCurso.Clear();
                pbFoto.Image = null;
                numeros = null;
                txt1.Focus();
                
            }
        }
    }
}
