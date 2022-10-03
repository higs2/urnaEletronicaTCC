using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace urnaEletronicaTCC
{
    public partial class frmUrna : Form
    {
        public frmUrna()
        {
            InitializeComponent();
        }
        private string numeroCandidato;
        
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
    }
}
