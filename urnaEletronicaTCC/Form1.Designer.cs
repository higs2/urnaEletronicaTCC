namespace urnaEletronicaTCC
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgvCandidato = new System.Windows.Forms.DataGridView();
            this.btnZerarCandidatos = new System.Windows.Forms.Button();
            this.btnZerarVotacao = new System.Windows.Forms.Button();
            this.btnApuracao = new System.Windows.Forms.Button();
            this.btnVotacao = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidato)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 492);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(43, 17);
            this.toolStripStatusLabel1.Text = "Admin";
            // 
            // dgvCandidato
            // 
            this.dgvCandidato.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(82)))));
            this.dgvCandidato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCandidato.Location = new System.Drawing.Point(32, 215);
            this.dgvCandidato.Name = "dgvCandidato";
            this.dgvCandidato.Size = new System.Drawing.Size(595, 255);
            this.dgvCandidato.TabIndex = 14;
            this.dgvCandidato.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnZerarCandidatos
            // 
            this.btnZerarCandidatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZerarCandidatos.ForeColor = System.Drawing.Color.Transparent;
            this.btnZerarCandidatos.Location = new System.Drawing.Point(649, 423);
            this.btnZerarCandidatos.Name = "btnZerarCandidatos";
            this.btnZerarCandidatos.Size = new System.Drawing.Size(106, 47);
            this.btnZerarCandidatos.TabIndex = 13;
            this.btnZerarCandidatos.Text = "Zerar Candidatos";
            this.btnZerarCandidatos.UseVisualStyleBackColor = true;
            this.btnZerarCandidatos.Click += new System.EventHandler(this.btnZerarCandidatos_Click);
            // 
            // btnZerarVotacao
            // 
            this.btnZerarVotacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZerarVotacao.ForeColor = System.Drawing.Color.Transparent;
            this.btnZerarVotacao.Location = new System.Drawing.Point(649, 370);
            this.btnZerarVotacao.Name = "btnZerarVotacao";
            this.btnZerarVotacao.Size = new System.Drawing.Size(106, 47);
            this.btnZerarVotacao.TabIndex = 12;
            this.btnZerarVotacao.Text = "Zerar Votação";
            this.btnZerarVotacao.UseVisualStyleBackColor = true;
            // 
            // btnApuracao
            // 
            this.btnApuracao.BackgroundImage = global::urnaEletronicaTCC.Properties.Resources.APURACAO;
            this.btnApuracao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApuracao.ForeColor = System.Drawing.Color.Transparent;
            this.btnApuracao.Location = new System.Drawing.Point(649, 317);
            this.btnApuracao.Name = "btnApuracao";
            this.btnApuracao.Size = new System.Drawing.Size(106, 47);
            this.btnApuracao.TabIndex = 11;
            this.btnApuracao.UseVisualStyleBackColor = true;
            this.btnApuracao.Click += new System.EventHandler(this.btnApuracao_Click);
            // 
            // btnVotacao
            // 
            this.btnVotacao.BackgroundImage = global::urnaEletronicaTCC.Properties.Resources.VOTACAO;
            this.btnVotacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVotacao.ForeColor = System.Drawing.Color.Transparent;
            this.btnVotacao.Location = new System.Drawing.Point(649, 264);
            this.btnVotacao.Name = "btnVotacao";
            this.btnVotacao.Size = new System.Drawing.Size(106, 47);
            this.btnVotacao.TabIndex = 10;
            this.btnVotacao.UseVisualStyleBackColor = true;
            this.btnVotacao.Click += new System.EventHandler(this.btnVotacao_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackgroundImage = global::urnaEletronicaTCC.Properties.Resources.CADASTRO_CAND;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.ForeColor = System.Drawing.Color.Transparent;
            this.btnCadastrar.Location = new System.Drawing.Point(649, 211);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(106, 47);
            this.btnCadastrar.TabIndex = 9;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::urnaEletronicaTCC.Properties.Resources.tela3;
            this.ClientSize = new System.Drawing.Size(784, 514);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgvCandidato);
            this.Controls.Add(this.btnZerarCandidatos);
            this.Controls.Add(this.btnZerarVotacao);
            this.Controls.Add(this.btnApuracao);
            this.Controls.Add(this.btnVotacao);
            this.Controls.Add(this.btnCadastrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu - Urna Eletrônica";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.DataGridView dgvCandidato;
        private System.Windows.Forms.Button btnZerarCandidatos;
        private System.Windows.Forms.Button btnZerarVotacao;
        private System.Windows.Forms.Button btnApuracao;
        private System.Windows.Forms.Button btnVotacao;
        private System.Windows.Forms.Button btnCadastrar;
    }
}

