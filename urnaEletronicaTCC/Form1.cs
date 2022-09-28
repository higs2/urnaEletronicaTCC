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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnVotacao_Click(object sender, EventArgs e)
        {
            frmUrna urna = new frmUrna();
            urna.ShowDialog();
        }
    }
}
