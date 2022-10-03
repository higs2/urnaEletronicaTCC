using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using urnaEletronicaTCC.Controllers;
using urnaEletronicaTCC.Models;

namespace urnaEletronicaTCC

{
    public partial class frmCadastro : Form
    {
        private string destino;
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            
            dialog.Filter = "JPG Files(*.jpg)| *.jpg | PNG Files(*.png)| *.png | AllFiles(*.*)| *.*";
            if (dialog.ShowDialog() == DialogResult.OK) 
            {
                string foto = dialog.FileName.ToString();
                txtImage.Text = foto;
                pbFoto.ImageLocation = foto;

            }
          
        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {

        }

        public void limparCampos()
        {
            
            txtNumero.Clear();
            
            txtCurso.Clear();
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cadastro save = new Cadastro
            (
                txtNome.Text,
                txtNumero.Text,
                Convert.ToInt32 (txtCurso.Text),
                txtImage.Text
                
                
            );
            

            CadastroController cadastroController = new CadastroController();
            bool verifica  = cadastroController.salvarCadastro(save);

            if (verifica)
            {
                MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (MessageBox.Show("Deseja Continuar cadastrando", "Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    limparCampos();
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Falha ao fazer o cadastro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja cancelar o cadastro?","Cancelar",MessageBoxButtons.YesNo,MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
