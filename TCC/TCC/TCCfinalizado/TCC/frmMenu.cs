using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCC;

namespace TCC
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }


        private void btnIniciarCaixa_Click(object sender, EventArgs e)
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
                frmCaixaLogin Login = new frmCaixaLogin();
                Login.Show();
            }

        }


        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCliente_Click(object sender, EventArgs e)
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
                CadastroCliente.Show();
            }



        }

        private void btnProduto_Click(object sender, EventArgs e)
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
                frmCadastroDeProduto CadastroProduto = new frmCadastroDeProduto();
                CadastroProduto.Show();
            }
        }



        private void tmrHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToShortTimeString();
            lblData.Text = DateTime.Now.ToShortDateString();
        }




        private void frmMenu_Load(object sender, EventArgs e)
        {
            int AlturaDesktop = Screen.PrimaryScreen.Bounds.Height;
            int LarguraDesktop = Screen.PrimaryScreen.Bounds.Width;

            this.Size = new Size(LarguraDesktop, AlturaDesktop);
            this.Location = new Point(0, 0);

        }

        private void btnIniciarCompra_Click(object sender, EventArgs e)
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
                frmIniciarVendas Vendas = new frmIniciarVendas();
                Vendas.Show();
            }
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmLoginDeCadastro>().Count() > 0)
            {
                return;
            }
            else if (Application.OpenForms.OfType<frmCadastroDeProduto>().Count() > 0)
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
            else if (Application.OpenForms.OfType<frmIniciarCaixa>().Count() > 0)
            {
                return;
            }
            else if (Application.OpenForms.OfType<frmCadastroDeUsuario>().Count() > 0)
            {
                return;
            }
            else
            {
                frmLoginDeCadastro LogCad = new frmLoginDeCadastro();
                LogCad.Location = new Point(30, 270);
                LogCad.Show();
            }
        }
    }
}