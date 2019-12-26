namespace TCC
{
    partial class frmRecuperacaoDeSenha
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtResposta = new System.Windows.Forms.TextBox();
            this.cboPergunta = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNovaSenha = new System.Windows.Forms.Label();
            this.txtNovaSenha = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblSenhaAtual = new System.Windows.Forms.Label();
            this.lblAlterarSenha = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.txtSenhaAtual = new System.Windows.Forms.TextBox();
            this.btnChecar = new System.Windows.Forms.Button();
            this.lblRepetirSenha = new System.Windows.Forms.Label();
            this.txtRepetirSenha = new System.Windows.Forms.TextBox();
            this.dgvPergunta = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPergunta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(143, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 24);
            this.label5.TabIndex = 19;
            this.label5.Text = "Resposta:";
            // 
            // txtResposta
            // 
            this.txtResposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtResposta.Location = new System.Drawing.Point(244, 178);
            this.txtResposta.Name = "txtResposta";
            this.txtResposta.Size = new System.Drawing.Size(205, 20);
            this.txtResposta.TabIndex = 18;
            // 
            // cboPergunta
            // 
            this.cboPergunta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboPergunta.FormattingEnabled = true;
            this.cboPergunta.Location = new System.Drawing.Point(244, 141);
            this.cboPergunta.Name = "cboPergunta";
            this.cboPergunta.Size = new System.Drawing.Size(205, 21);
            this.cboPergunta.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(11, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "Pergunta de segurança:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtUsuario.Location = new System.Drawing.Point(244, 103);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(205, 20);
            this.txtUsuario.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(158, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Usuário:";
            // 
            // lblNovaSenha
            // 
            this.lblNovaSenha.AutoSize = true;
            this.lblNovaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNovaSenha.ForeColor = System.Drawing.Color.White;
            this.lblNovaSenha.Location = new System.Drawing.Point(96, 279);
            this.lblNovaSenha.Name = "lblNovaSenha";
            this.lblNovaSenha.Size = new System.Drawing.Size(127, 24);
            this.lblNovaSenha.TabIndex = 23;
            this.lblNovaSenha.Text = "Nova senha:";
            this.lblNovaSenha.Visible = false;
            // 
            // txtNovaSenha
            // 
            this.txtNovaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtNovaSenha.Location = new System.Drawing.Point(219, 283);
            this.txtNovaSenha.Name = "txtNovaSenha";
            this.txtNovaSenha.PasswordChar = '*';
            this.txtNovaSenha.Size = new System.Drawing.Size(241, 20);
            this.txtNovaSenha.TabIndex = 22;
            this.txtNovaSenha.Visible = false;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(193, 341);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 25;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Visible = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.Location = new System.Drawing.Point(274, 341);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 26;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblSenhaAtual
            // 
            this.lblSenhaAtual.AutoSize = true;
            this.lblSenhaAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaAtual.ForeColor = System.Drawing.Color.White;
            this.lblSenhaAtual.Location = new System.Drawing.Point(116, 212);
            this.lblSenhaAtual.Name = "lblSenhaAtual";
            this.lblSenhaAtual.Size = new System.Drawing.Size(129, 24);
            this.lblSenhaAtual.TabIndex = 28;
            this.lblSenhaAtual.Text = "Senha Atual:";
            this.lblSenhaAtual.Visible = false;
            // 
            // lblAlterarSenha
            // 
            this.lblAlterarSenha.AutoSize = true;
            this.lblAlterarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlterarSenha.ForeColor = System.Drawing.Color.Cyan;
            this.lblAlterarSenha.Location = new System.Drawing.Point(365, 240);
            this.lblAlterarSenha.Name = "lblAlterarSenha";
            this.lblAlterarSenha.Size = new System.Drawing.Size(84, 13);
            this.lblAlterarSenha.TabIndex = 29;
            this.lblAlterarSenha.Text = "Alterar Senha";
            this.lblAlterarSenha.Visible = false;
            this.lblAlterarSenha.Click += new System.EventHandler(this.lblAlterarSenha_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(238, 30);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(77, 17);
            this.dgv.TabIndex = 35;
            // 
            // txtSenhaAtual
            // 
            this.txtSenhaAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtSenhaAtual.Location = new System.Drawing.Point(244, 217);
            this.txtSenhaAtual.Name = "txtSenhaAtual";
            this.txtSenhaAtual.ReadOnly = true;
            this.txtSenhaAtual.Size = new System.Drawing.Size(205, 20);
            this.txtSenhaAtual.TabIndex = 36;
            this.txtSenhaAtual.Visible = false;
            // 
            // btnChecar
            // 
            this.btnChecar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnChecar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChecar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChecar.ForeColor = System.Drawing.Color.White;
            this.btnChecar.Location = new System.Drawing.Point(455, 178);
            this.btnChecar.Name = "btnChecar";
            this.btnChecar.Size = new System.Drawing.Size(55, 23);
            this.btnChecar.TabIndex = 34;
            this.btnChecar.Text = "Checar";
            this.btnChecar.UseVisualStyleBackColor = false;
            this.btnChecar.Click += new System.EventHandler(this.btnChecar_Click);
            // 
            // lblRepetirSenha
            // 
            this.lblRepetirSenha.AutoSize = true;
            this.lblRepetirSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepetirSenha.ForeColor = System.Drawing.Color.White;
            this.lblRepetirSenha.Location = new System.Drawing.Point(11, 308);
            this.lblRepetirSenha.Name = "lblRepetirSenha";
            this.lblRepetirSenha.Size = new System.Drawing.Size(212, 24);
            this.lblRepetirSenha.TabIndex = 39;
            this.lblRepetirSenha.Text = "Repita  a nova senha:";
            this.lblRepetirSenha.Visible = false;
            // 
            // txtRepetirSenha
            // 
            this.txtRepetirSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtRepetirSenha.Location = new System.Drawing.Point(219, 312);
            this.txtRepetirSenha.Name = "txtRepetirSenha";
            this.txtRepetirSenha.PasswordChar = '*';
            this.txtRepetirSenha.Size = new System.Drawing.Size(241, 20);
            this.txtRepetirSenha.TabIndex = 38;
            this.txtRepetirSenha.Visible = false;
            // 
            // dgvPergunta
            // 
            this.dgvPergunta.AllowUserToAddRows = false;
            this.dgvPergunta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPergunta.Location = new System.Drawing.Point(162, 18);
            this.dgvPergunta.Name = "dgvPergunta";
            this.dgvPergunta.Size = new System.Drawing.Size(171, 41);
            this.dgvPergunta.TabIndex = 40;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox1.Image = global::TCC.Properties.Resources.REC_DE_SENHA;
            this.pictureBox1.Location = new System.Drawing.Point(31, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(464, 60);
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.Location = new System.Drawing.Point(0, -2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(529, 14);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 33;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Location = new System.Drawing.Point(0, 378);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(529, 14);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 32;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Location = new System.Drawing.Point(0, -2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(10, 394);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 31;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(520, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 394);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // frmRecuperacaoDeSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(530, 391);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvPergunta);
            this.Controls.Add(this.lblRepetirSenha);
            this.Controls.Add(this.txtRepetirSenha);
            this.Controls.Add(this.txtSenhaAtual);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnChecar);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblAlterarSenha);
            this.Controls.Add(this.lblSenhaAtual);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lblNovaSenha);
            this.Controls.Add(this.txtNovaSenha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtResposta);
            this.Controls.Add(this.cboPergunta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRecuperacaoDeSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "RecuperacaoDeSenha";
            this.Load += new System.EventHandler(this.frmRecuperacaoDeSenha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPergunta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtResposta;
        private System.Windows.Forms.ComboBox cboPergunta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNovaSenha;
        private System.Windows.Forms.TextBox txtNovaSenha;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblSenhaAtual;
        private System.Windows.Forms.Label lblAlterarSenha;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox txtSenhaAtual;
        private System.Windows.Forms.Button btnChecar;
        private System.Windows.Forms.Label lblRepetirSenha;
        private System.Windows.Forms.TextBox txtRepetirSenha;
        private System.Windows.Forms.DataGridView dgvPergunta;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}