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

        public void limparCampos()
        {
            txtfoto.Clear();
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
                txtfoto.Text                
                
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
    }
}
