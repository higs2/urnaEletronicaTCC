using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using urnaEletronicaTCC.Controllers;
using urnaEletronicaTCC.Models;

namespace urnaEletronicaTCC
{
    public partial class frmPrincipal : Form
    {
        CadastroController cadastroController = new CadastroController();
        
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnVotacao_Click(object sender, EventArgs e)
        {
            frmUrna urna = new frmUrna();
            urna.ShowDialog();
            
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadastro cadastro = new frmCadastro();
            cadastro.ShowDialog();
           
        }
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
           

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnTeste_Click(object sender, EventArgs e)
        {
            
        }

        private void btnApuracao_Click(object sender, EventArgs e)
        {
            frmApuracao apuracao = new frmApuracao();
            apuracao.ShowDialog();
        }

        private void btnZerarCandidatos_Click(object sender, EventArgs e)
        {

        }
    }
}
