﻿using System;
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
        public string destino;
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            //dialog.Filter = "JPG Files(*.jpg)| *.jpg | PNG Files(*.png)| *.png | AllFiles(*.*)| *.*";
            dialog.Filter = "(*.jpg;*.bmp;*.jpeg;*png;*.*)|*.jpg;*.bmp;*.jpeg;*png;*.*";
            dialog.Title = "Selecione uma Imagem";
            if (dialog.ShowDialog() == DialogResult.OK) 
            {
                /*
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\image");
                pbFoto.Text = Convert.ToString(new System.Drawing.Bitmap(dialog.FileName));
                destino = "\\image\\" + dialog.SafeFileName;
                File.Copy(dialog.FileName, Directory.GetCurrentDirectory() + destino);
                */

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
                txtCurso.Text,
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
                this.Dispose();
            
            }
        }

    

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("este campo aceita somente numeros positivos");
            }
        }
    }
}
