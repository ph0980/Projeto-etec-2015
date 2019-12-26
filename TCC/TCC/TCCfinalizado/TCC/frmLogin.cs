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
using MySql.Data.MySqlClient;

namespace TCC
{
    public partial class frmLogin : Form
    {
        public MySqlConnection objCnx = new MySqlConnection();
        public MySqlCommand objCmd = new MySqlCommand();
        public MySqlDataReader objDados;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            objCnx.ConnectionString = "Server=localhost; Database=BancoDeDados ;User=root; Pwd =1234; Port = 3306 ";
        }

        private void button1_Click(object sender, EventArgs e)
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
            else{
                 objCnx.Open();
                 try
                 {
                    string strSql = "select * from Usuario where nome ='"+txtUsuario.Text+"' and senha ='"+txtSenha.Text+"'";
                    objCmd.Connection = objCnx;
                    objCmd.CommandText = strSql;
                    objDados = objCmd.ExecuteReader();
                    if (objDados.HasRows)
                    {
                        frmMenu Menu = new frmMenu();
                        Menu.Show();
                        this.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Usuário não cadastrado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtSenha.Focus();
                        txtSenha.Clear();
                      
                    }

                } 
                   catch 
                {
                    MessageBox.Show("Erro na Conexão", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                objCnx.Close();
             }
      
              
           
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
