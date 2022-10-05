using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        }

        private void btnCorrigir_Click(object sender, EventArgs e)
        {
            txt1.Clear();
            txt2.Clear();
            

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
        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
