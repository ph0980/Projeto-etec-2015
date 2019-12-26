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
    public partial class frmIniciarCaixa : Form
    {
        public MySqlConnection objCnx = new MySqlConnection();
        public MySqlCommand objCmd = new MySqlCommand();
        public MySqlDataReader objDados;

        public frmIniciarCaixa()
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

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMensal_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmCadastroDeProduto>().Count() > 0)
            {
                return;
            }
            else if (Application.OpenForms.OfType<frmCaixaLogin>().Count() > 0)
            {
                return;
            }
            else if (Application.OpenForms.OfType<frmIniciarVendas>().Count() > 0)
            {
                return;
            }
            else if (Application.OpenForms.OfType<frmCadastroDeCliente>().Count() > 0)
            {
                return;
            }
            else {
                frmLucros Lucros = new frmLucros();
                Lucros.Location = new Point(480, 270);
                Lucros.Show();
                this.Close();
            }                      
        }

    
        private void frmIniciarCaixa_Load(object sender, EventArgs e)
        {

        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGastos_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmCadastroDeProduto>().Count() > 0)
            {
                return;
            }
            else if (Application.OpenForms.OfType<frmCaixaLogin>().Count() > 0)
            {
                return;
            }
            else if (Application.OpenForms.OfType<frmIniciarVendas>().Count() > 0)
            {
                return;
            }
            else if (Application.OpenForms.OfType<frmCadastroDeCliente>().Count() > 0)
            {
                return;
            }
            else
            {

                frmGastos Gastos = new frmGastos();
                Gastos.Location = new Point(480, 270);
                Gastos.Show();
                this.Close();
            }                      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmCadastroDeProduto>().Count() > 0)
            {
                return;
            }
            else if (Application.OpenForms.OfType<frmCaixaLogin>().Count() > 0)
            {
                return;
            }
            else if (Application.OpenForms.OfType<frmIniciarVendas>().Count() > 0)
            {
                return;
            }
            else if (Application.OpenForms.OfType<frmCadastroDeCliente>().Count() > 0)
            {
                return;
            }
            else
            {

                frmContabilidade Contabilidade = new frmContabilidade();
                Contabilidade.Location = new Point(480, 270);
                Contabilidade.Show();
                this.Close();
            }

        }
    }
}
