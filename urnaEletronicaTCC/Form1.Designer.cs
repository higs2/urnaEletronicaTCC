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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnZerarCandidatos = new System.Windows.Forms.Button();
            this.btnZerarVotacao = new System.Windows.Forms.Button();
            this.btnApuracao = new System.Windows.Forms.Button();
            this.btnVotacao = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(755, 22);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(595, 91);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 156);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(595, 255);
            this.dataGridView1.TabIndex = 14;
            // 
            // btnZerarCandidatos
            // 
            this.btnZerarCandidatos.Location = new System.Drawing.Point(613, 364);
            this.btnZerarCandidatos.Name = "btnZerarCandidatos";
            this.btnZerarCandidatos.Size = new System.Drawing.Size(106, 47);
            this.btnZerarCandidatos.TabIndex = 13;
            this.btnZerarCandidatos.Text = "Zerar Candidatos";
            this.btnZerarCandidatos.UseVisualStyleBackColor = true;
            // 
            // btnZerarVotacao
            // 
            this.btnZerarVotacao.Location = new System.Drawing.Point(613, 311);
            this.btnZerarVotacao.Name = "btnZerarVotacao";
            this.btnZerarVotacao.Size = new System.Drawing.Size(106, 47);
            this.btnZerarVotacao.TabIndex = 12;
            this.btnZerarVotacao.Text = "Zerar Votação";
            this.btnZerarVotacao.UseVisualStyleBackColor = true;
            // 
            // btnApuracao
            // 
            this.btnApuracao.Location = new System.Drawing.Point(613, 258);
            this.btnApuracao.Name = "btnApuracao";
            this.btnApuracao.Size = new System.Drawing.Size(106, 47);
            this.btnApuracao.TabIndex = 11;
            this.btnApuracao.Text = "Apuração";
            this.btnApuracao.UseVisualStyleBackColor = true;
            // 
            // btnVotacao
            // 
            this.btnVotacao.Location = new System.Drawing.Point(613, 205);
            this.btnVotacao.Name = "btnVotacao";
            this.btnVotacao.Size = new System.Drawing.Size(106, 47);
            this.btnVotacao.TabIndex = 10;
            this.btnVotacao.Text = "Votação";
            this.btnVotacao.UseVisualStyleBackColor = true;
            this.btnVotacao.Click += new System.EventHandler(this.btnVotacao_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(613, 152);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(106, 47);
            this.btnCadastrar.TabIndex = 9;
            this.btnCadastrar.Text = "Cadastrar / Alterar Cadindadtos";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 31);
            this.label1.TabIndex = 17;
            this.label1.Text = "VOTAÇÃO";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnZerarCandidatos);
            this.Controls.Add(this.btnZerarVotacao);
            this.Controls.Add(this.btnApuracao);
            this.Controls.Add(this.btnVotacao);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu - Urna Eletrônica";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnZerarCandidatos;
        private System.Windows.Forms.Button btnZerarVotacao;
        private System.Windows.Forms.Button btnApuracao;
        private System.Windows.Forms.Button btnVotacao;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label1;
    }
}

