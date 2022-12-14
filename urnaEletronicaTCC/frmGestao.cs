using MySql.Data.MySqlClient;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace urnaEletronicaTCC
{
    public partial class frmGestao : Form
    {
        public frmGestao()
        {
            InitializeComponent();
        }
        MySqlConnection conexao = new MySqlConnection();

        public string destino;
        private void txt2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void frmPesquisar_Click(object sender, EventArgs e)
        {

            try
            {


                Cadastro dados = new Cadastro(txtNome.Text, txtPesquisar.Text, txtCurso.Text, txtFoto.Text);
                conexao = Conexao.Conectar();

                CadastroController gestao1 = new CadastroController();
                DataTable dt = new DataTable();
                DataRow dataRow;
                int cont = 0;
                dt = gestao1.exibirDados(dados);


                while (cont <= dt.Rows.Count)
                {

                    dataRow = dt.Rows[cont];
                    txtNome.Text = dataRow["nome"].ToString();
                    txtNumero.Text = dataRow["numero"].ToString();
                    txtCurso.Text = dataRow["curso"].ToString();
                    destino = dataRow["foto"].ToString();
                    cont++;

                    btnEditar.Enabled = true;
                    if (destino != null)
                    {
                        pbFoto.Image = new System.Drawing.Bitmap(Directory.GetCurrentDirectory() + destino);
                    }
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

        private void frmGestao_Load(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            btnSalvar.Enabled = true;

            btnEditar.Enabled = false;


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja cancelar o cadastro?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Dispose();

            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE cadastro SET nome=@nome,curso=@curso,foto=@foto", conexao);
                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
             
                cmd.Parameters.AddWithValue("@curso", txtCurso.Text);
                cmd.Parameters.AddWithValue("@foto", destino);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Alterações salvas com sucesso");

                groupBox1.Enabled=false;
                btnEditar.Enabled=true;
                btnSalvar.Enabled=false;
            }
            catch (MySqlException)
            {
                MessageBox.Show("Erro");
            }
        }

        private OpenFileDialog dialog = new OpenFileDialog();
        private void btnEscolherFoto_Click(object sender, EventArgs e)
        {

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\image");
                pbFoto.Image = new System.Drawing.Bitmap(dialog.FileName);
                destino = "\\image\\" + dialog.SafeFileName;
                File.Copy(dialog.FileName, Directory.GetCurrentDirectory() + destino);
                btnEscolherFoto.Enabled = false;
                btnLimpar.Enabled = true;


            
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            pbFoto.Image.Dispose();
            string foto = Directory.GetCurrentDirectory() + destino;
            File.Delete(foto);
            pbFoto.Image = null;
            dialog.FileName = null;
            destino = null;
        }
    }
}
