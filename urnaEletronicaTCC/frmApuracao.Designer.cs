namespace urnaEletronicaTCC
{
    partial class frmApuracao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmApuracao));
            this.dgvCandidato = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidato)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCandidato
            // 
            this.dgvCandidato.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(82)))));
            this.dgvCandidato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCandidato.Location = new System.Drawing.Point(31, 215);
            this.dgvCandidato.Name = "dgvCandidato";
            this.dgvCandidato.Size = new System.Drawing.Size(725, 255);
            this.dgvCandidato.TabIndex = 15;
            this.dgvCandidato.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCandidato_CellContentClick);
            // 
            // frmApuracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::urnaEletronicaTCC.Properties.Resources.tela3;
            this.ClientSize = new System.Drawing.Size(784, 495);
            this.Controls.Add(this.dgvCandidato);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmApuracao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mercúrio Eleitoral | Apuração";
            this.Load += new System.EventHandler(this.frmApuracao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidato)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCandidato;
    }
}