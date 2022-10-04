﻿using System;
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
        private Cadastro exibirVotos()
        {
            Cadastro votos= new Cadastro();
            votos.id_user= Convert.ToInt32(dgvCandidato.SelectedRows[0].Cells[0].Value);
            votos.nome = dgvCandidato.SelectedRows[0].Cells[1].Value.ToString();
            votos.numero = Convert.ToInt32(dgvCandidato.SelectedRows[0].Cells[2].Value);
            votos.curso = dgvCandidato.SelectedRows[0].Cells[3].Value.ToString();
            
            return votos;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            dgvCandidato.DataSource = cadastroController.exibirCandidatos();
            dgvCandidato.Columns[0].Width = 50;
            dgvCandidato.Columns[1].Width = 100;
            dgvCandidato.Columns[2].Width = 200;
            dgvCandidato.Columns[3].Width = 120;
            


            dgvCandidato.Columns[0].HeaderText = "ID";
            dgvCandidato.Columns[1].HeaderText = "Nome";
            dgvCandidato.Columns[2].HeaderText = "Numero";
            dgvCandidato.Columns[3].HeaderText = "Curso";
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
