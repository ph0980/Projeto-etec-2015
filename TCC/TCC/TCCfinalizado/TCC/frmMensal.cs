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
    public partial class frmMensal : Form
    {
        
        public frmMensal()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmIniciarCaixa IniciarCaixa = new frmIniciarCaixa();
            IniciarCaixa.StartPosition = FormStartPosition.Manual;
            IniciarCaixa.Location = new Point(30, 220);
            IniciarCaixa.Show();
        }
    }
}
