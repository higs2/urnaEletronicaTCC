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

namespace urnaEletronicaTCC
{
    public partial class frmApuracao : Form
    {
        CadastroController cadastroController = new CadastroController();

        public frmApuracao()
        {
            InitializeComponent();
        }
        private void frmPrincipal_Load(object sender, EventArgs e)
        {

            
        }

        private void dgvCandidato_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmApuracao_Load(object sender, EventArgs e)
        {
            dgvCandidato.DataSource = cadastroController.exibirCandidatos();

            dgvCandidato.Columns[0].Width = 20;
            dgvCandidato.Columns[1].Width = 100;
            dgvCandidato.Columns[2].Width = 40;
            dgvCandidato.Columns[3].Width = 150;
            dgvCandidato.Columns[4].Width = 200;
            dgvCandidato.Columns[5].Width = 40;


            dgvCandidato.Columns[0].HeaderText = "ID";
            dgvCandidato.Columns[1].HeaderText = "Nome";
            dgvCandidato.Columns[2].HeaderText = "Numero";
            dgvCandidato.Columns[3].HeaderText = "Curso";
            dgvCandidato.Columns[4].HeaderText = "Foto";
            dgvCandidato.Columns[5].HeaderText = "Votos";
        }
    }
}
