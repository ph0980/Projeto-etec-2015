namespace TCC
{
    partial class frmSplash
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
            this.components = new System.ComponentModel.Container();
            this.pbrCarregar = new System.Windows.Forms.ProgressBar();
            this.tmrCarregar = new System.Windows.Forms.Timer(this.components);
            this.lblPorcentagem = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pbrCarregar
            // 
            this.pbrCarregar.BackColor = System.Drawing.Color.Yellow;
            this.pbrCarregar.ForeColor = System.Drawing.Color.Azure;
            this.pbrCarregar.Location = new System.Drawing.Point(2, 263);
            this.pbrCarregar.Name = "pbrCarregar";
            this.pbrCarregar.Size = new System.Drawing.Size(713, 10);
            this.pbrCarregar.TabIndex = 0;
            this.pbrCarregar.Click += new System.EventHandler(this.pbrCarregar_Click);
            // 
            // tmrCarregar
            // 
            this.tmrCarregar.Enabled = true;
            this.tmrCarregar.Tick += new System.EventHandler(this.tmrCarregar_Tick);
            // 
            // lblPorcentagem
            // 
            this.lblPorcentagem.AutoSize = true;
            this.lblPorcentagem.BackColor = System.Drawing.Color.SteelBlue;
            this.lblPorcentagem.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.lblPorcentagem.ForeColor = System.Drawing.Color.White;
            this.lblPorcentagem.Location = new System.Drawing.Point(663, 233);
            this.lblPorcentagem.Name = "lblPorcentagem";
            this.lblPorcentagem.Size = new System.Drawing.Size(0, 23);
            this.lblPorcentagem.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox2.Image = global::TCC.Properties.Resources.NOVO_LOGO7;
            this.pictureBox2.Location = new System.Drawing.Point(135, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(430, 217);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(715, 285);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblPorcentagem);
            this.Controls.Add(this.pbrCarregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmSplash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pbrCarregar;
        private System.Windows.Forms.Timer tmrCarregar;
        private System.Windows.Forms.Label lblPorcentagem;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

