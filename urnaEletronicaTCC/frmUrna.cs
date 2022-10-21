using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Media;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using urnaEletronicaTCC.Controllers;
using urnaEletronicaTCC.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace urnaEletronicaTCC
{

    //update cadastro set votos=votos+1 where numero="4";

    //select nome, numero, votos from cadastro where votos is not null order by votos desc;


    public partial class frmUrna : Form
    {
        Boolean keyCancel = false;

        

       
        public frmUrna()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }
        MySqlConnection conexao = new MySqlConnection();
        public string digitoConcatenadao;
        public string numeros;

        private void frmUrna_Load(object sender, EventArgs e)
        {
            txt1.Focus();
        }


        private void txt2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Cadastro dados = new Cadastro(lblNome.Text, txt1.Text + txt2.Text, lblCurso.Text, txtFoto.Text);
                conexao = Conexao.Conectar();

                CadastroController cadastro = new CadastroController();
                DataTable dt = new DataTable();
                DataRow dataRow;
                int cont = 0;
                dt = cadastro.exibirDados(dados);

                // dt.Rows[0]["curso"].ToString();             

                lblNome2.Visible = true;
                lblCurso2.Visible = true;
                lblNome.Visible = true;
                lblCurso.Visible = true;
                while (cont <= dt.Rows.Count)
                {

                    dataRow = dt.Rows[cont];
                    lblNome.Text = dataRow["nome"].ToString();
                    lblCurso.Text = dataRow["curso"].ToString();
                    pbFoto.Image = Image.FromFile(dataRow["foto"].ToString());

                    cont++;
                            
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

        public void limpar()
        {
            txt1.Clear();
            txt2.Clear();

            lblNome.Text = "";
            lblCurso.Text = "";
            lblCurso2.Visible = false;
            lblNome2.Visible = false;
            pbFoto.Image = null;
            numeros = null;


        }

        private void AcaoFinal(Object myObject, EventArgs myEventArgs)
        {
                
            timer1.Stop();
            timer1.Enabled = false;
            panel1.Visible = false;
        }


        private void btnConfirma_Click(object sender, EventArgs e)
        {
            try
            {
                Cadastro voto = new Cadastro(lblNome.Text, txt1.Text + txt2.Text, lblCurso.Text, txtFoto.Text);
                conexao = Conexao.Conectar();

                CadastroController cadastro = new CadastroController();
                DataTable dt = new DataTable();
               
                if (!string.IsNullOrEmpty(txt1.Text) || !string.IsNullOrEmpty(txt2.Text))
                {
                    dt = cadastro.confirmarVoto(voto);

                    //frmFim fim = new frmFim();
                    //fim.ShowDialog();
                    panel1.Visible = true;
                    //timer1.Interval = 2000;
                    

                }
            }
            catch (Exception)
            {

                return;
            }
            finally
            {
                conexao.Clone();
            }
           
        }

        private void btnCorrigir_Click(object sender, EventArgs e)
        {
            limpar();

            timer1.Stop();
            timer1.Enabled = false;
        }

        private void btnBranco_Click(object sender, EventArgs e)
        {

        }

        private void txt1_KeyDown(object sender, KeyEventArgs e)
        {
                       
        }

        private void frmUrna_KeyPress(object sender, KeyPressEventArgs e)
        {
         

            
        }

        private void frmUrna_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txt2_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void lblNome2_Click(object sender, EventArgs e)
        {

        }

        private void lblCurso2_Click(object sender, EventArgs e)
        {

        }

        private void txt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                e.Handled = true;
                txt1.Clear();
                txt2.Clear();
                txt1.Focus();
                limpar();
            }
            else
            {
                e.Handled = false;
                txt2.Focus();
            }
        }

        private void txt1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.OemPeriod)
            {
                txt1.Clear();
                txt2.Clear();
                txt1.Focus();
            }
        }

        private void txt2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.OemPeriod)
            {
                txt1.Clear();
                txt2.Clear();
                txt1.Focus();
                
            }

            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    Cadastro voto = new Cadastro(lblNome.Text, txt1.Text + txt2.Text, lblCurso.Text, txtFoto.Text);
                    conexao = Conexao.Conectar();

                    CadastroController cadastro = new CadastroController();
                    DataTable dt = new DataTable();

                    if (!string.IsNullOrEmpty(txt1.Text) || !string.IsNullOrEmpty(txt2.Text))
                    {
                        dt = cadastro.confirmarVoto(voto);

                        //  frmFim fim = new frmFim();
                        // fim.ShowDialog();
                        panel1.Visible = true;
                        SoundPlayer s = new SoundPlayer(Properties.Resources.urna);
                        s.Play();
                    }
                    
                }
                catch (Exception)
                {

                    return;
                }
                finally
                {
                    conexao.Clone();
                }
            }
        }

        private void txt2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                e.Handled = true;
                txt1.Clear();
                txt2.Clear();
                txt1.Focus();
                limpar();
            }
            else
            {
                e.Handled = false;

                txt2.Focus();
            }


        }
    }
}
