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
    public partial class frmListadeClientes : Form
    {
        public MySqlConnection objCnx = new MySqlConnection();
        public MySqlCommand objCmd = new MySqlCommand();
        public MySqlDataReader objDados;

        public frmListadeClientes()
        {
            InitializeComponent();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnAtualizar_Click_1(object sender, EventArgs e)
        {
            objCnx.Open();
            try
            {
                string strSql = "Select* from Cliente where id =" + txtId.Text;
                objCmd.Connection = objCnx;
                objCmd.CommandText = strSql;
                objDados = objCmd.ExecuteReader();
                if (!objDados.HasRows)
                {
                    MessageBox.Show("Código inexistente!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtId.Text = "";
                    txtCPF.Text = "";
                    txtTelefone.Text = "";
                    txtEndereco.Text = "";
                    txtNome.Text = "";
                    txtComplemento.Text = "";
                    txtId.Focus();
                    
                    objCmd.Connection=objCnx;
                    objCmd.CommandText=strSql;
                    objCmd.ExecuteNonQuery();
                    MessageBox.Show("Registro alterado com sucesso!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (!objDados.IsClosed) { objDados.Close(); 
                    {
                        strSql = "Update from Cliente where id =" + txtId.Text;
                        objCmd.Connection = objCnx;
                        objCmd.CommandText = strSql;
                        objCmd.ExecuteNonQuery();
                        MessageBox.Show("Registro alterado com sucesso!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                }
                if (!objDados.IsClosed) { objDados.Close(); }

            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro ==>" + Erro.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            objCnx.Close();
            dgvClientes.Rows.Add(txtId.Text, txtNome.Text, txtCPF.Text,txtBairro.Text,txtEndereco.Text,txtComplemento.Text,txtTelefone.Text);
        }
    }
}
    

