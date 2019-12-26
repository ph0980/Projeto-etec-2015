namespace TCC
{
    partial class frmIniciarVendas
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistrarDivida = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.dtDataDaVenda = new System.Windows.Forms.DateTimePicker();
            this.btnRegistrarVenda = new System.Windows.Forms.Button();
            this.txtTroco = new System.Windows.Forms.TextBox();
            this.txtDinheiro = new System.Windows.Forms.TextBox();
            this.txtValorDaCompra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvProduto = new System.Windows.Forms.DataGridView();
            this.txtCodBarra = new System.Windows.Forms.TextBox();
            this.Produtos = new System.Windows.Forms.ListBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 99;
            this.label1.Text = "Quantidade:";
            // 
            // btnRegistrarDivida
            // 
            this.btnRegistrarDivida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarDivida.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnRegistrarDivida.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarDivida.Location = new System.Drawing.Point(473, 315);
            this.btnRegistrarDivida.Name = "btnRegistrarDivida";
            this.btnRegistrarDivida.Size = new System.Drawing.Size(118, 60);
            this.btnRegistrarDivida.TabIndex = 100;
            this.btnRegistrarDivida.TabStop = false;
            this.btnRegistrarDivida.Text = "Registrar Divida";
            this.btnRegistrarDivida.UseVisualStyleBackColor = true;
            this.btnRegistrarDivida.Click += new System.EventHandler(this.btnRegistrarDivida_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(592, 315);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(118, 60);
            this.btnLimpar.TabIndex = 101;
            this.btnLimpar.TabStop = false;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.75F);
            this.txtQuantidade.Location = new System.Drawing.Point(134, 94);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(36, 28);
            this.txtQuantidade.TabIndex = 0;
            this.txtQuantidade.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtQuantidade_KeyUp);
            // 
            // dtDataDaVenda
            // 
            this.dtDataDaVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.dtDataDaVenda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataDaVenda.Location = new System.Drawing.Point(580, 91);
            this.dtDataDaVenda.Name = "dtDataDaVenda";
            this.dtDataDaVenda.Size = new System.Drawing.Size(130, 31);
            this.dtDataDaVenda.TabIndex = 104;
            this.dtDataDaVenda.TabStop = false;
            // 
            // btnRegistrarVenda
            // 
            this.btnRegistrarVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnRegistrarVenda.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarVenda.Location = new System.Drawing.Point(354, 315);
            this.btnRegistrarVenda.Name = "btnRegistrarVenda";
            this.btnRegistrarVenda.Size = new System.Drawing.Size(118, 60);
            this.btnRegistrarVenda.TabIndex = 2;
            this.btnRegistrarVenda.Text = "Registrar Venda";
            this.btnRegistrarVenda.UseVisualStyleBackColor = true;
            this.btnRegistrarVenda.Click += new System.EventHandler(this.btnRegistrarVenda_Click);
            // 
            // txtTroco
            // 
            this.txtTroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.75F);
            this.txtTroco.Location = new System.Drawing.Point(192, 387);
            this.txtTroco.Name = "txtTroco";
            this.txtTroco.ReadOnly = true;
            this.txtTroco.Size = new System.Drawing.Size(161, 28);
            this.txtTroco.TabIndex = 106;
            this.txtTroco.TabStop = false;
            // 
            // txtDinheiro
            // 
            this.txtDinheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.75F);
            this.txtDinheiro.Location = new System.Drawing.Point(192, 359);
            this.txtDinheiro.Name = "txtDinheiro";
            this.txtDinheiro.Size = new System.Drawing.Size(161, 28);
            this.txtDinheiro.TabIndex = 107;
            this.txtDinheiro.TabStop = false;
            this.txtDinheiro.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDinheiro_KeyUp);
            // 
            // txtValorDaCompra
            // 
            this.txtValorDaCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.txtValorDaCompra.Location = new System.Drawing.Point(192, 328);
            this.txtValorDaCompra.MaxLength = 2;
            this.txtValorDaCompra.Name = "txtValorDaCompra";
            this.txtValorDaCompra.ReadOnly = true;
            this.txtValorDaCompra.Size = new System.Drawing.Size(161, 31);
            this.txtValorDaCompra.TabIndex = 108;
            this.txtValorDaCompra.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 25);
            this.label2.TabIndex = 109;
            this.label2.Text = "Valor da Compra:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(93, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 110;
            this.label3.Text = "Dinheiro:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(115, 386);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 25);
            this.label4.TabIndex = 111;
            this.label4.Text = "Troco:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(515, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 25);
            this.label5.TabIndex = 112;
            this.label5.Text = "Data:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(187, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 25);
            this.label6.TabIndex = 113;
            this.label6.Text = "Cod. de barras";
            // 
            // dgvProduto
            // 
            this.dgvProduto.AllowUserToAddRows = false;
            this.dgvProduto.AllowUserToDeleteRows = false;
            this.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduto.Location = new System.Drawing.Point(378, 35);
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.ReadOnly = true;
            this.dgvProduto.RowHeadersVisible = false;
            this.dgvProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvProduto.Size = new System.Drawing.Size(10, 10);
            this.dgvProduto.TabIndex = 116;
            this.dgvProduto.TabStop = false;
            // 
            // txtCodBarra
            // 
            this.txtCodBarra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.txtCodBarra.Location = new System.Drawing.Point(337, 91);
            this.txtCodBarra.MaxLength = 13;
            this.txtCodBarra.Name = "txtCodBarra";
            this.txtCodBarra.Size = new System.Drawing.Size(164, 31);
            this.txtCodBarra.TabIndex = 1;
            this.txtCodBarra.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCodBarra_KeyUp);
            // 
            // Produtos
            // 
            this.Produtos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.75F);
            this.Produtos.FormattingEnabled = true;
            this.Produtos.ItemHeight = 22;
            this.Produtos.Location = new System.Drawing.Point(13, 125);
            this.Produtos.Name = "Produtos";
            this.Produtos.Size = new System.Drawing.Size(700, 180);
            this.Produtos.TabIndex = 124;
            this.Produtos.DoubleClick += new System.EventHandler(this.Produtos_DoubleClick);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::TCC.Properties.Resources.iniciar_vendas_br;
            this.pictureBox4.Location = new System.Drawing.Point(214, 7);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(322, 76);
            this.pictureBox4.TabIndex = 125;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Location = new System.Drawing.Point(-4, 423);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(727, 10);
            this.pictureBox3.TabIndex = 98;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(1, -5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(727, 11);
            this.pictureBox2.TabIndex = 97;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(716, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(12, 477);
            this.pictureBox1.TabIndex = 96;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.White;
            this.pictureBox8.Location = new System.Drawing.Point(-4, -7);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(11, 450);
            this.pictureBox8.TabIndex = 95;
            this.pictureBox8.TabStop = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnVoltar.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.Location = new System.Drawing.Point(354, 376);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(356, 39);
            this.btnVoltar.TabIndex = 126;
            this.btnVoltar.TabStop = false;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // frmIniciarVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(724, 433);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.Produtos);
            this.Controls.Add(this.dgvProduto);
            this.Controls.Add(this.txtCodBarra);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtValorDaCompra);
            this.Controls.Add(this.txtDinheiro);
            this.Controls.Add(this.txtTroco);
            this.Controls.Add(this.btnRegistrarVenda);
            this.Controls.Add(this.dtDataDaVenda);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnRegistrarDivida);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmIniciarVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistrarDivida;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.DateTimePicker dtDataDaVenda;
        private System.Windows.Forms.Button btnRegistrarVenda;
        private System.Windows.Forms.TextBox txtTroco;
        private System.Windows.Forms.TextBox txtDinheiro;
        private System.Windows.Forms.TextBox txtValorDaCompra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvProduto;
        private System.Windows.Forms.TextBox txtCodBarra;
        private System.Windows.Forms.ListBox Produtos;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnVoltar;
    }
}