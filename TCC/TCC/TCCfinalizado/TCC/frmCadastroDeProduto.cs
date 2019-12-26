using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using dto;
using model;

namespace TCC
{
    public partial class frmCadastroDeProduto : Form
    {
        public MySqlConnection objCnx = new MySqlConnection();
        public MySqlCommand objCmd = new MySqlCommand();
        public MySqlDataReader objDados;

        produtoDTO objProdutoDTO = new produtoDTO();
        public frmCadastroDeProduto()
        {
            InitializeComponent();
        }

        private void adicionarNoCombobox()
        {
            cboTipo.Items.Clear();
            for (int i = 0; i < dgvTipo.Rows.Count; i++)
            {
                cboTipo.Items.Add(dgvTipo.Rows[i].Cells[0].Value);
            }

            objCnx.Close();
        }
        private void listarTipo()
        {
            objCnx.Close();
            objCnx.Open();

            string strSql = "select tipo from tipo";
            objCmd.Connection = objCnx;
            objCmd.CommandText = strSql;
            objDados = objCmd.ExecuteReader();
            objDados.Close();


            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(objCmd);
            da.Fill(dt);
            dgvTipo.DataSource = dt;
            objCnx.Close();

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            if (keyData == Keys.F1)
            {
                if (cboTipo.Text == "")
                {
                    MessageBox.Show("Favor informar o tipo do produto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboTipo.Focus();
                }
                else
                {
                    for (int i = 0; i < dgvTipo.Rows.Count; i++)
                    {

                        if (cboTipo.Text == dgvTipo.Rows[i].Cells[0].Value.ToString())
                        {
                            cadastrarProduto();
                        }

                        else if (dgvTipo.RowCount - 1 == i)
                        {
                            objCnx.Open();
                            string strSql = "insert into tipo(tipo) values ('" + cboTipo.Text + "')";
                            objCmd.Connection = objCnx;
                            objCmd.CommandText = strSql;
                            objDados.Close();
                            objDados = objCmd.ExecuteReader();


                            listarTipo();
                            adicionarNoCombobox();
                            i--;
                        }
                    }
                    listarProdutos();
                    limparCamposProduto();
                }
            }
            if (keyData == Keys.F2)
            {
                excluirProduto();
                limparCamposProduto();
                listarProdutos();
            }
            if (keyData == Keys.F3)
            {
                if (cboTipo.Text == "")
                {
                    MessageBox.Show("Favor informar o tipo do produto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboTipo.Focus();
                }
                else
                {
                    for (int i = 0; i < dgvTipo.Rows.Count; i++)
                    {

                        if (cboTipo.Text == dgvTipo.Rows[i].Cells[0].Value.ToString())
                        {
                            atualizarProdutos();
                        }

                        else if (dgvTipo.RowCount - 1 == i)
                        {
                            if (cboTipo.Text == "")
                            {
                                MessageBox.Show("Favor informar o tipo do produto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                cboTipo.Focus();
                            }
                            else
                            {
                                objCnx.Open();
                                string strSql = "insert into tipo(tipo) values  ('" + cboTipo.Text + "')";
                                objCmd.Connection = objCnx;
                                objCmd.CommandText = strSql;
                                objDados.Close();
                                objDados = objCmd.ExecuteReader();


                                listarTipo();
                                adicionarNoCombobox();
                                i--;
                            }
                        }
                    }
                    listarProdutos();
                    limparCamposProduto();
                }
            }
            if (keyData == Keys.F4)
            {
                listarProdutos();
                limparCamposProduto();
                listarProdutos();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }



        public void limparCamposProduto()
        {
            txtCodBarra.Text = "";
            txtProd.Text = "";
            cboTipo.Text = "";
            txtIdProd.Text = "";
            txtPreco.Text = "";
            txtQuantidade.Text = "";
            txtPeso.Text = "";
            txtCodBarra.Focus();
        }


        public void cadastrarProduto()
        {
            if (txtCodBarra.Text == "")
            {
                MessageBox.Show("Favor informar o código de barras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodBarra.Focus();
            }
            else if (cboTipo.Text == "")
            {
                MessageBox.Show("Favor informar o tipo do produto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboTipo.Focus();
            }
            else if (txtProd.Text == "")
            {
                MessageBox.Show("Favor informar o Nome do produto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProd.Focus();
            }
            else if (txtPeso.Text == "")
            {
                MessageBox.Show("Favor informar o Peso do produto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPeso.Focus();
            }
            else if (txtPreco.Text == "")
            {
                MessageBox.Show("Favor informar o Preço do produto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPreco.Focus();
            }
            else if (txtQuantidade.Text == "")
            {
                MessageBox.Show("Favor informar a Quantidade do produto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantidade.Focus();
            }

            else
            {
                objCnx.Open();
                string strSql = "select * from Produto where produto = '" + txtProd.Text + "' or cod_barras ='" + txtCodBarra.Text + "'";
                objCmd.Connection = objCnx;
                objCmd.CommandText = strSql;
                //if (!objDados.IsClosed) { objDados.Close(); }
                objDados = objCmd.ExecuteReader();
                if (objDados.HasRows) { MessageBox.Show("O Produto já está cadastrado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                else {
                    objProdutoDTO.Cod = txtCodBarra.Text;
                    objProdutoDTO.Tipo = cboTipo.Text;
                    objProdutoDTO.Produto = txtProd.Text;
                    objProdutoDTO.Peso = txtPeso.Text;
                    objProdutoDTO.Preco = Convert.ToDecimal(txtPreco.Text);
                    objProdutoDTO.Quantidade = Convert.ToInt32(txtQuantidade.Text);

                    int x = new produtoMODEL().cadastrarProduto(objProdutoDTO);
                    if (x > 0)
                    {
                        MessageBox.Show(string.Format("Produto: {0} cadastrado com sucesso ", txtProd.Text));
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível cadastrar este produto.");
                    }
                    limparCamposProduto();
                }
            }
            objCnx.Close();
        }

        public void excluirProduto()
        {
            if (txtIdProd.Text == "")
            {
                MessageBox.Show("Favor selecionar um produto! ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                if (MessageBox.Show("Deseja excluir", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {

                    objProdutoDTO.Idprod = Convert.ToInt32(txtIdProd.Text);
                    int x = new produtoMODEL().excluirProduto(objProdutoDTO);
                    if (x > 0)
                    {
                        MessageBox.Show(string.Format("Produto: {0} excluido com sucesso !! ", txtProd.Text));
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível excluir este produto.");
                    }
                }
            }
        }

        public void atualizarProdutos()
        {
            if (txtIdProd.Text == "")
            {
                MessageBox.Show("Favor selecionar um produto! ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtCodBarra.Text == "")
            {
                MessageBox.Show("Favor informar o código de barras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodBarra.Focus();
            }
            else if (cboTipo.Text == "")
            {
                MessageBox.Show("Favor informar o tipo do produto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboTipo.Focus();
            }
            else if (txtProd.Text == "")
            {
                MessageBox.Show("Favor informar o Nome do produto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProd.Focus();
            }
            else if (txtPeso.Text == "")
            {
                MessageBox.Show("Favor informar o Peso do produto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPeso.Focus();
            }
            else if (txtPreco.Text == "")
            {
                MessageBox.Show("Favor informar o Preço do produto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPreco.Focus();
            }
            else if (txtQuantidade.Text == "")
            {
                MessageBox.Show("Favor informar a Quantidade do produto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantidade.Focus();
            }
            else
            {
                objCnx.ConnectionString = "Server=localhost; Database=BancoDeDados ;User=root; Pwd =1234; Port = 3306 ";
                objCnx.Open();
                string strSql = "select * from produto where cod_barras = '" + txtCodBarra.Text + "' and produto <> '"+txtProd.Text+"'";
                objCmd.Connection = objCnx;
                objCmd.CommandText = strSql;
                objDados = objCmd.ExecuteReader();
                if (objDados.HasRows) { MessageBox.Show("Dados pertencentes a outro produto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                else {
                    objProdutoDTO.Idprod = Convert.ToInt32(txtIdProd.Text);
                    objProdutoDTO.Cod = txtCodBarra.Text;
                    objProdutoDTO.Produto = txtProd.Text;
                    objProdutoDTO.Peso = txtPeso.Text;
                    objProdutoDTO.Preco = Convert.ToDecimal(txtPreco.Text);
                    objProdutoDTO.Quantidade = Convert.ToInt32(txtQuantidade.Text);
                    objProdutoDTO.Tipo = cboTipo.Text;


                    int x = new produtoMODEL().atualizarProduto(objProdutoDTO);
                    if (x > 0)
                    {
                        MessageBox.Show(string.Format("Dados do produto: {0} atualizados com sucesso !! ", txtProd.Text));
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível atualizar os dados deste produto.");
                    }
                }
            }
                objCnx.Close();
        }


        public void listarProdutos()
        {
            objCnx.Open();
            try
            {
                string strSql = "Select * from Produto Order by idprod";
                objCmd.Connection = objCnx;
                objCmd.CommandText = strSql;
                objCmd.ExecuteNonQuery();


                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(objCmd);
                da.Fill(dt);
                Dr.DataSource = dt;
            }

            catch (Exception Erro)
            {
                MessageBox.Show("Erro ==>" + Erro.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            objCnx.Close();
        }
        private void frmCadastroDeProduto_Load(object sender, EventArgs e)
        {
            objCnx.ConnectionString = "Server=localhost; Database=BancoDeDados ;User=root; Pwd = 1234; Port = 3306 ";
            listarProdutos();
            listarTipo();
            adicionarNoCombobox();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            limparCamposProduto();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (cboTipo.Text == "")
            {
                MessageBox.Show("Favor informar o tipo do produto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboTipo.Focus();
            }
            else
            {
                for (int i = 0; i < dgvTipo.Rows.Count; i++)
                {

                    if (cboTipo.Text == dgvTipo.Rows[i].Cells[0].Value.ToString())
                    {
                        cadastrarProduto();
                    }

                    else if (dgvTipo.RowCount - 1 == i)
                    {
                        objCnx.Open();
                        string strSql = "insert into tipo(tipo) values ('" + cboTipo.Text + "')";
                        objCmd.Connection = objCnx;
                        objCmd.CommandText = strSql;
                        objDados.Close();
                        objDados = objCmd.ExecuteReader();


                        listarTipo();
                        adicionarNoCombobox();
                        i--;
                    }
                }
                listarProdutos();
                limparCamposProduto();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            excluirProduto();
            listarProdutos();
            limparCamposProduto();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (cboTipo.Text == "")
            {
                MessageBox.Show("Favor informar o tipo do produto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboTipo.Focus();
            }
            else
            {
                for (int i = 0; i < dgvTipo.Rows.Count; i++)
                {

                    if (cboTipo.Text == dgvTipo.Rows[i].Cells[0].Value.ToString())
                    {
                        atualizarProdutos();
                    }

                    else if (dgvTipo.RowCount - 1 == i)
                    {
                        objCnx.Open();
                        string strSql = "insert into tipo(tipo) values  ('" + cboTipo.Text + "')";
                        objCmd.Connection = objCnx;
                        objCmd.CommandText = strSql;
                        objDados.Close();
                        objDados = objCmd.ExecuteReader();


                        listarTipo();
                        adicionarNoCombobox();
                        i--;
                    }
                }
                listarProdutos();
                limparCamposProduto();
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            listarProdutos();
        }

        private void Dr_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdProd.Text = Dr.CurrentRow.Cells[0].Value.ToString();
            txtCodBarra.Text = Dr.CurrentRow.Cells[1].Value.ToString();
            cboTipo.Text = Dr.CurrentRow.Cells[2].Value.ToString();
            txtProd.Text = Dr.CurrentRow.Cells[3].Value.ToString();
            txtPeso.Text = Dr.CurrentRow.Cells[4].Value.ToString();
            txtPreco.Text = Dr.CurrentRow.Cells[5].Value.ToString();
            txtQuantidade.Text = Dr.CurrentRow.Cells[6].Value.ToString();
        }

        private void frmCadastroDeProduto_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txtPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsSeparator(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsSeparator(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

       
    }
}
