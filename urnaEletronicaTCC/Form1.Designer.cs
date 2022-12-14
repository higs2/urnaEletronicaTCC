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
            this.btnApuracao = new System.Windows.Forms.Button();
            this.btnVotacao = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.frmPesquisar = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 576);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(599, 22);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(43, 17);
            this.toolStripStatusLabel1.Text = "Admin";
            // 
            // btnApuracao
            // 
            this.btnApuracao.BackgroundImage = global::urnaEletronicaTCC.Properties.Resources.APURACAO;
            this.btnApuracao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApuracao.ForeColor = System.Drawing.Color.Transparent;
            this.btnApuracao.Location = new System.Drawing.Point(347, 416);
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
            this.btnVotacao.Location = new System.Drawing.Point(347, 331);
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
            this.btnCadastrar.Location = new System.Drawing.Point(142, 416);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(106, 47);
            this.btnCadastrar.TabIndex = 9;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // frmPesquisar
            // 
            this.frmPesquisar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.frmPesquisar.Location = new System.Drawing.Point(142, 326);
            this.frmPesquisar.Name = "frmPesquisar";
            this.frmPesquisar.Size = new System.Drawing.Size(106, 57);
            this.frmPesquisar.TabIndex = 62;
            this.frmPesquisar.Text = "EDITAR CANDIDATO";
            this.frmPesquisar.UseVisualStyleBackColor = false;
            this.frmPesquisar.Click += new System.EventHandler(this.frmPesquisar_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::urnaEletronicaTCC.Properties.Resources.tela5;
            this.ClientSize = new System.Drawing.Size(599, 598);
            this.Controls.Add(this.frmPesquisar);
            this.Controls.Add(this.statusStrip1);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btnApuracao;
        private System.Windows.Forms.Button btnVotacao;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button frmPesquisar;
    }
}

