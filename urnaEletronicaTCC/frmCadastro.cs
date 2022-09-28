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
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) 
            {
                pbFoto.ImageLocation = openFileDialog1.FileName;
                pbFoto.Load();
            }
        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
