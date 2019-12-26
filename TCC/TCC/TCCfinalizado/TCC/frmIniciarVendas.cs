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
    public partial class frmIniciarVendas : Form
    {
        public MySqlConnection objCnx = new MySqlConnection();
        public MySqlCommand objCmd = new MySqlCommand();
        public MySqlDataReader objDados;


        vendasDTO objVendasdto = new vendasDTO();
        decimal somaTotal;
        decimal troco;
        decimal dinheiro;



        private void frmVendas_Load(object sender, EventArgs e)
        {
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        public frmIniciarVendas()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {  
            troco = 0;
            somaTotal = 0;
            txtDinheiro.Text = "";
            txtTroco.Text = "";
            txtValorDaCompra.Text = "";
            txtCodBarra.Text = "";
            txtQuantidade.Text = "";
            Produtos.Items.Clear();
        }

        private void txtCodBarra_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtQuantidade.Text == "")
                {
                    txtQuantidade.Text = "1";
                }
                using (MySqlConnection conexao = new MySqlConnection())
                {
                    conexao.ConnectionString = "Server=localhost;database=BancoDeDados;user=root;password=1234;port=3306";
                    MySqlCommand comando = new MySqlCommand();
                    comando.CommandType = CommandType.Text;
                    conexao.Open();
                    comando.CommandText = "Select * from Produto where cod_barras ='" + txtCodBarra.Text + "'";

                    comando.Connection = conexao;
                    comando.ExecuteNonQuery();

                    //cria um dataadapter
                    MySqlDataAdapter da = new MySqlDataAdapter(comando);

                    //cria um datatable
                    DataTable dataTable = new DataTable();

                    //preenche o datatable via dataadapter
                    da.Fill(dataTable);

                    //atribui o datatable ao datagridview para exibir o resultado
                    dgvProduto.DataSource = dataTable;

                    dgvProduto.Columns[0].Visible = false;
                    dgvProduto.Columns[1].Visible = false;

                    MySqlDataReader leitor;
                    comando.CommandText = "Select * from Produto where cod_barras ='" + txtCodBarra.Text + "'";
                    comando.Connection = conexao;
                    leitor = comando.ExecuteReader();

                    if (!leitor.HasRows)
                    {
                        MessageBox.Show("Produto não encontrado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        leitor.Close();
                        txtQuantidade.Focus();
                    }
                    else
                    {
                        leitor.Close();
                        int quantidade = Convert.ToInt32(dgvProduto.Rows[0].Cells[6].Value);
                        if ((Convert.ToInt32(dgvProduto.Rows[0].Cells[6].Value) - (Convert.ToInt32(txtQuantidade.Text)) < 0))
                        {
                            MessageBox.Show("Limite em estoque atingido", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            dgvProduto.Rows[0].Cells[6].Value = quantidade;
                            txtQuantidade.Focus();
                        }
                        else
                        {
                            if ((Convert.ToInt32(dgvProduto.Rows[0].Cells[6].Value) == 0))
                            {
                                dgvProduto.Rows[0].Cells[6].Value = 0;
                                MessageBox.Show("Produto esgotado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                txtQuantidade.Focus();
                            }
                            else
                            {
                                somaTotal = somaTotal + (Convert.ToDecimal(dgvProduto.Rows[0].Cells[5].Value) * Convert.ToDecimal(txtQuantidade.Text));
                                txtValorDaCompra.Text = somaTotal.ToString();
                                somaTotal = Convert.ToDecimal(txtValorDaCompra.Text);

                                comando.CommandText = "update Produto set quantidade = '" + (Convert.ToInt32(dgvProduto.Rows[0].Cells[6].Value) - Convert.ToInt32(txtQuantidade.Text)) + "' where cod_barras = '" + txtCodBarra.Text + "'";
                                comando.Connection = conexao;
                                comando.ExecuteNonQuery();
                                da.Fill(dataTable);
                                dgvProduto.DataSource = null;
                                dgvProduto.Rows.Clear();

                                comando.CommandText = "Select * from Produto where cod_barras ='" + txtCodBarra.Text + "'";
                                comando.Connection = conexao;
                                comando.ExecuteNonQuery();

                                MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                                DataTable table = new DataTable();
                                adapter.Fill(table);
                                dgvProduto.DataSource = table;
                                dgvProduto.Columns[0].Visible = false;
                                dgvProduto.Columns[1].Visible = false;
                                txtCodBarra.Focus();


                            }
                            for (int q = 0; q < Convert.ToInt32(txtQuantidade.Text); q++)
                            {
                                Produtos.Items.Add(dgvProduto.Rows[0].Cells[3].Value + " - " + dgvProduto.Rows[0].Cells[4].Value + " - " + dgvProduto.Rows[0].Cells[5].Value + "  ");
                            }
                            txtCodBarra.Text = "";

                        }
                    }

                }
            }
        }

        private void txtQuantidade_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCodBarra.Focus();
            }
        }

        private void btnRegistrarVenda_Click(object sender, EventArgs e)
        {
            if (txtValorDaCompra.Text == "" || txtValorDaCompra.Text == "0" || txtValorDaCompra.Text == "0,0" || txtValorDaCompra.Text == "0,00")
            {
                MessageBox.Show("Nenhuma venda em andamento", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantidade.Text = "";
            }
            else
            {

                objVendasdto.Valor = Convert.ToDecimal(txtValorDaCompra.Text);
                objVendasdto.Data_venda = Convert.ToDateTime(dtDataDaVenda.Text);
                objVendasdto.Produto = dgvProduto.Rows[0].Cells[3].Value.ToString();
                objVendasdto.Preco = Convert.ToDecimal(dgvProduto.Rows[0].Cells[5].Value);




                int x = new vendasMODEL().registrarCompra(objVendasdto);

                if (x > 0)
                {
                    MessageBox.Show("Venda registrada com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    troco = 0;
                    somaTotal = 0;
                    txtDinheiro.Text = "";
                    txtTroco.Text = "";
                    txtValorDaCompra.Text = "";
                    txtCodBarra.Text = "";
                    txtQuantidade.Text = "";
                    Produtos.Items.Clear();
                }
                else
                {
                    MessageBox.Show("Não foi possivel registrar a compra", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void txtDinheiro_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtValorDaCompra.Text == "")
                {
                    MessageBox.Show("Nenhuma venda em andamento", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    dinheiro = Convert.ToDecimal(txtDinheiro.Text);
                    troco = dinheiro - somaTotal;
                    txtTroco.Text = troco.ToString();
                }
            }
        }

        private void btnRegistrarDivida_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms.OfType<frmCadastroDeProduto>().Count() > 0)
            {
                return;
            }
            else if (Application.OpenForms.OfType<frmCaixaLogin>().Count() > 0)
            {
                return;
            }
            else if (Application.OpenForms.OfType<frmCadastroDeCliente>().Count() > 0)
            {
                return;
            }
            else if (Application.OpenForms.OfType<frmIniciarCaixa>().Count() > 0)
            {
                return;
            }
            else if (Application.OpenForms.OfType<frmCadastroDeUsuario>().Count() > 0)
            {
                return;
            }
            else if (Application.OpenForms.OfType<frmLucros>().Count() > 0)
            {
                return;
            }
            else if (Application.OpenForms.OfType<frmRecuperacaoDeSenha>().Count() > 0)
            {
                return;
            }
            else if (Application.OpenForms.OfType<frmLoginDeCadastro>().Count() > 0)
            {
                return;
            }
            else
            {
                frmCadastroDeCliente CadastroCliente = new frmCadastroDeCliente();
                CadastroCliente.StartPosition = FormStartPosition.Manual;
                CadastroCliente.Location = new Point(30, 270);
                CadastroCliente.Show();
            }
        }

        private void Produtos_DoubleClick(object sender, EventArgs e)
        {
            if (Produtos.Items.Count<1)
            {
                MessageBox.Show("Não há nenhum produto na lista", "Não foi possivel selecionar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                string produto = Produtos.SelectedItem.ToString();
                string parte = produto.Substring(0, produto.IndexOf('-'));

                using (MySqlConnection conexao = new MySqlConnection())
                {
                    conexao.ConnectionString = "Server=localhost;database=BancoDeDados;user=root;password=1234;port=3306";
                    MySqlCommand comando = new MySqlCommand();
                    comando.CommandType = CommandType.Text;
                    conexao.Open();
                    comando.CommandText = "Select * from Produto where produto ='" + parte + "'";

                    comando.Connection = conexao;
                    comando.ExecuteNonQuery();

                    //cria um dataadapter
                    MySqlDataAdapter da = new MySqlDataAdapter(comando);

                    //cria um datatable
                    DataTable dataTable = new DataTable();

                    //preenche o datatable via dataadapter
                    da.Fill(dataTable);

                    //atribui o datatable ao datagridview para exibir o resultado
                    dgvProduto.DataSource = dataTable;

                    dgvProduto.Columns[0].Visible = false;
                    dgvProduto.Columns[1].Visible = false;


                    comando.CommandText = "Update produto set quantidade = '" + (Convert.ToInt32(dgvProduto.Rows[0].Cells[6].Value) + 1) + "' where produto = '" + parte + "'";
                    comando.Connection = conexao;
                    comando.ExecuteNonQuery();
                    da.Fill(dataTable);
                    somaTotal = somaTotal - Convert.ToDecimal(dgvProduto.Rows[0].Cells[5].Value);
                    txtValorDaCompra.Text = somaTotal.ToString();

                    comando.CommandText = "Select * from Produto where produto ='" + parte + "'";
                    comando.Connection = conexao;
                    comando.ExecuteNonQuery();

                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dgvProduto.DataSource = table;
                    dgvProduto.Columns[0].Visible = false;
                    dgvProduto.Columns[1].Visible = false;
                    Produtos.Items.Remove(Produtos.SelectedItem);
                }
            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();        
        }
    }
}




