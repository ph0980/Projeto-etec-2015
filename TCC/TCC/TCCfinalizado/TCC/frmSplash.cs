using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void tmrCarregar_Tick(object sender, EventArgs e)
        {
             pbrCarregar.Value = pbrCarregar.Value + 2;

           
            if (pbrCarregar.Value < 100)
            {
                lblPorcentagem.Text = pbrCarregar.Value + "%";
            }
            else
            {
                this.Visible=false;
                tmrCarregar.Enabled = false;
                frmLogin Login = new frmLogin();
                Login.Show();
            }
        }

        private void pbrCarregar_Click(object sender, EventArgs e)
        {

        }

        private void frmSplash_Load(object sender, EventArgs e)
        {

        }
    }
}
