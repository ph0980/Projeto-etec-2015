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

namespace TCC
{
    public partial class frmLucros : Form
    {
        public MySqlConnection objCnx = new MySqlConnection();
        public MySqlCommand objCmd = new MySqlCommand();
        public MySqlDataReader objDados;

        public frmLucros()
        {
            InitializeComponent();
        }
        private void buscar()
        {
            DateTime dataI = Convert.ToDateTime(dtInicial.Text);
            DateTime dataF = Convert.ToDateTime(dtFinal.Text);

            string dataInicial = dataI.ToString("yyyy-MM-dd");
            string dataFinal = dataF.ToString("yyyy-MM-dd");

            objCnx.ConnectionString = "Server=Localhost;Database=BancoDeDados;User=root;Pwd=1234; port=3306";

            objCnx.Open();

            objCmd.Connection = objCnx;
            objCmd.CommandType = CommandType.Text;
            objCmd.CommandText = "select valor_venda,data,preco,produto,descricao from vendas where data between '" + dataInicial + "' and '" + dataFinal + "'";
            objCmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(objCmd);
            da.Fill(dt);
            dgvDatas.DataSource = dt;


            objCmd.CommandText = "select sum(valor_venda) from vendas where data between '" + dataInicial + "' and '" + dataFinal + "'";
            objDados = objCmd.ExecuteReader();
            objDados.Read();
            txtTotal.Text = objDados["sum(valor_venda)"].ToString();

            if (!objDados.IsClosed) { objDados.Close(); }
            objCnx.Close();
        }
        private void frmMensal_Load(object sender, EventArgs e)
        {
            objCnx.ConnectionString = "Server=localhost; Database=BancoDeDados ;User=root; Pwd =1234; Port = 3306 ";
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

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
            frmIniciarCaixa IniciarCaixa = new frmIniciarCaixa();
            IniciarCaixa.Location = new Point(440, 270);
            IniciarCaixa.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar();
            }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (txtValor.Text == "")
            {
                MessageBox.Show("Favor inserir um valor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtdescricao.Text == "")
            {
                MessageBox.Show("Favor inserir uma descrição", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtdescricao.Focus();
            }
            else
            {
                DateTime data = Convert.ToDateTime(dtData.Text);
                string dataConv = data.ToString("yyyy-MM-dd");


                objCnx.ConnectionString = "Server=Localhost;Database=BancoDeDados;User=root;Pwd=1234";
                objCnx.Open();
                try
                {
                    string strSql = "insert into vendas(data,valor_venda,descricao)values('" + dataConv + "','" + txtValor.Text.Replace(",", ".") + "','" + txtdescricao.Text + "')";
                    objCmd.Connection = objCnx;
                    objCmd.CommandText = strSql;
                    objCmd.ExecuteNonQuery();

                    MessageBox.Show("Dados inseridos com sucesso", "Dados inseridos");
                    txtValor.Text = "";
                    txtdescricao.Text = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("Favor inserir um valor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            objCnx.Close();
            buscar();
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsSeparator(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        }

    }

