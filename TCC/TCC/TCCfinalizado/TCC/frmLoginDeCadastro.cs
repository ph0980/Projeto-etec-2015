using MySql.Data.MySqlClient;
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
    public partial class frmLoginDeCadastro : Form
    {
        public MySqlConnection objCnx = new MySqlConnection();
        public MySqlCommand objCmd = new MySqlCommand();
        public MySqlDataReader objDados;

        public frmLoginDeCadastro()
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

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            if (txtUsuario.Text == "")
            {
                MessageBox.Show("Favor informar Usuário ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
            }
            else if (txtSenha.Text == "")
            {
                MessageBox.Show("Favor informar Senha", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSenha.Focus();
            }
            else
            {
                objCnx.Open();
                try
                {
                    string strSql = "select * from Login where nome ='" + txtUsuario.Text + "' and senha ='" + txtSenha.Text + "'";
                    objCmd.Connection = objCnx;
                    objCmd.CommandText = strSql;
                    objDados = objCmd.ExecuteReader();
                    if (objDados.HasRows)
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
                        else {
                            this.Close();
                            frmCadastroDeUsuario cad = new frmCadastroDeUsuario();
                            cad.Location = new Point(440, 270);
                            cad.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Favor preencher os campos corretamente", "Dados inválidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtSenha.Focus();
                        txtSenha.Text = "";
                    }

                }
                catch (Exception Erro)
                {
                    MessageBox.Show("Erro na Conexão", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                objCnx.Close();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLoginDeCadastro_Load(object sender, EventArgs e)
        {
            objCnx.ConnectionString = "Server=localhost; Database=BancoDeDados ;User=root; Pwd =1234; Port = 3306 ";
        }

        private void lblEsqueci_Click(object sender, EventArgs e)
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
            else
            {
                frmRecuperacaoDeSenha rsenha = new frmRecuperacaoDeSenha();
                rsenha.StartPosition = FormStartPosition.Manual;
                rsenha.Location = new Point(450, 300);
                rsenha.Show();
            }
        }
    }
}
