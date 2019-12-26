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
    public partial class frmContabilidade : Form
    {
        public MySqlConnection objCnx = new MySqlConnection();
        public MySqlCommand objCmd = new MySqlCommand();
        public MySqlDataReader objDados;


        public frmContabilidade()
        {
            InitializeComponent();
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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            frmIniciarCaixa IniciarCaixa = new frmIniciarCaixa();
            IniciarCaixa.Location = new Point(440, 270);
            IniciarCaixa.Show();
        }

        private void frmContabilidade_Load(object sender, EventArgs e)
        {
            objCnx.ConnectionString = "Server=localhost; Database=BancoDeDados ;User=root; Pwd =1234; Port = 3306 ";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DateTime dataI = Convert.ToDateTime(dtInicial.Text);
            DateTime dataF = Convert.ToDateTime(dtFinal.Text);

            string dataInicial = dataI.ToString("yyyy-MM-dd");
            string dataFinal = dataF.ToString("yyyy-MM-dd");

            objCnx.ConnectionString = "Server=Localhost;Database=BancoDeDados;User=root;Pwd=1234; port=3306";

            objCnx.Open();

            objCmd.Connection = objCnx;
            objCmd.CommandType = CommandType.Text;
            objCmd.CommandText = "select valor_venda,data from vendas where data between '" + dataInicial + "' and '" + dataFinal + "'";
            objCmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(objCmd);
            da.Fill(dt);
            dgvDatasVendas.DataSource = dt;

                objCmd.Connection = objCnx;
            objCmd.CommandType = CommandType.Text;
            objCmd.CommandText = "select valor_gasto,dt_gastos from vendas where dt_gastos between '" + dataInicial + "' and '" + dataFinal + "'";
            objCmd.ExecuteNonQuery();

            DataTable dt2 = new DataTable();
            MySqlDataAdapter da2 = new MySqlDataAdapter(objCmd);
            da2.Fill(dt2);
            dgvDatasGasto.DataSource = dt2;

            if (dgvDatasGasto.Rows[0].Cells[0].Value == null || dgvDatasVendas.Rows[0].Cells[0].Value == null)
            {
                MessageBox.Show("Não foi possível fazer o cálculo", "Registros insuficientes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

            objCmd.CommandText = "select sum(valor_venda) from vendas where data between '" + dataInicial + "' and '" + dataFinal + "'";
            objDados = objCmd.ExecuteReader();
            objDados.Read();
            txtBruto.Text = objDados["sum(valor_venda)"].ToString();
            objDados.Close();

            objCmd.CommandText = "select sum(valor_gasto) from vendas where dt_gastos between '" + dataInicial + "' and '" + dataFinal + "'";
            objDados = objCmd.ExecuteReader();
            objDados.Read();

           

            decimal gasto = Convert.ToDecimal(objDados["sum(valor_gasto)"]);
            decimal liquido = Convert.ToDecimal(txtBruto.Text) - gasto;
            txtLiquido.Text = liquido.ToString();
            //txtLiquido.Text = objDados["sum(valor_venda) - sum(valor_gasto)"].ToString();

            if (!objDados.IsClosed) { objDados.Close();}
            }
          

            
            objCnx.Close();
        }
    }
}
