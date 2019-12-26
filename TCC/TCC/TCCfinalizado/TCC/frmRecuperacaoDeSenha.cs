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
    public partial class frmRecuperacaoDeSenha : Form
    {
        public MySqlConnection objCnx = new MySqlConnection();
        public MySqlCommand objCmd = new MySqlCommand();
        public MySqlDataReader objDados;

        public frmRecuperacaoDeSenha()
        {
            InitializeComponent();
        }

        private void adicionarNoCombobox()
        {
            cboPergunta.Items.Clear();
            for (int i = 0; i < dgvPergunta.Rows.Count; i++)
            {

                cboPergunta.Items.Add(dgvPergunta.Rows[i].Cells[0].Value);
            }

            objCnx.Close();
        }
        private void listarPergunta()
        {
            objCnx.Close();
            objCnx.Open();

            string strSql = "select pergunta from pergunta";
            objCmd.Connection = objCnx;
            objCmd.CommandText = strSql;
            objDados = objCmd.ExecuteReader();
            objDados.Close();


            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(objCmd);
            da.Fill(dt);
            dgvPergunta.DataSource = dt;

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                frmCaixaLogin caixalogin = new frmCaixaLogin();
                caixalogin.Show();
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void lblAlterarSenha_Click(object sender, EventArgs e)
        {
            txtRepetirSenha.Visible = true;
            txtNovaSenha.Visible = true;
            lblRepetirSenha.Visible = true;
            lblNovaSenha.Visible = true;
            btnConfirmar.Visible = true;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

            frmCaixaLogin caixalogin = new frmCaixaLogin();
            caixalogin.Show();
            this.Close();
        }

        private void btnChecar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                MessageBox.Show("Favor informar Usuário", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
            }
            else if (cboPergunta.Text == "")
            {
                MessageBox.Show("Favor informar a pergunta de segurança", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboPergunta.Focus();    
            }
            else if (txtResposta.Text == "")
            {
                MessageBox.Show("Favor informar a resposta", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtResposta.Focus();
            }

            else
            {

                objCnx.Open();
                try
                {
                    string strSql = "select * from Usuario where nome ='" + txtUsuario.Text + "' and pergunta ='" + cboPergunta.Text + "'and resposta ='" + txtResposta.Text + "'";
                    objCmd.Connection = objCnx;
                    objCmd.CommandText = strSql;
                    objDados = objCmd.ExecuteReader();
                    if (objDados.HasRows)
                    {
                        if (!objDados.IsClosed) { objDados.Close(); }
                        DataTable dt = new DataTable();
                        MySqlDataAdapter da = new MySqlDataAdapter(objCmd);
                        da.Fill(dt);
                        dgv.DataSource = dt;
                        txtSenhaAtual.Visible = true;
                        lblSenhaAtual.Visible = true;
                        lblAlterarSenha.Visible = true;
                        txtSenhaAtual.Text = dgv.CurrentRow.Cells[1].Value.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Favor preencher os campos corretamente", "Dados inválidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch
                {
                    MessageBox.Show("Erro na Conexão", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                objCnx.Close();
            }
        }

        private void frmRecuperacaoDeSenha_Load(object sender, EventArgs e)
        {
            objCnx.ConnectionString = "Server=localhost; Database=BancoDeDados ;User=root; Pwd =1234; Port = 3306 ";
            listarPergunta();
            adicionarNoCombobox();

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtNovaSenha.Text == "")
            {

                MessageBox.Show("Favor informar a nova senha", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNovaSenha.Focus();

            }
            else if (txtRepetirSenha.Text!=txtNovaSenha.Text)
            {
                MessageBox.Show("Favor repetir a nova senha corretamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                objCnx.Open();
                try
                {
                    string strSql = "select * from Usuario where senha = '" + txtSenhaAtual.Text + "'";
                    objCmd.Connection = objCnx;
                    objCmd.CommandText = strSql;
                    objDados = objCmd.ExecuteReader();

                    if (!objDados.IsClosed) { objDados.Close(); }

                    strSql = "update usuario set senha = '" + txtNovaSenha.Text + "'";
                    objCmd.Connection = objCnx;
                    objCmd.CommandText = strSql;
                    objCmd.ExecuteNonQuery();
                    MessageBox.Show("Senha alterada com sucesso", "Alteração concluida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtRepetirSenha.Visible = false;
                    txtNovaSenha.Visible = false;
                    lblRepetirSenha.Visible = false;
                    lblNovaSenha.Visible = false;
                    btnConfirmar.Visible = false;
                }
                catch 
                {
                    MessageBox.Show("Erro na Conexão", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtRepetirSenha.Visible = false;
                    txtNovaSenha.Visible = false;
                    lblRepetirSenha.Visible = false;
                    lblNovaSenha.Visible = false;
                    btnConfirmar.Visible = false;
                }
                txtNovaSenha.Clear();
                txtResposta.Clear();
                txtSenhaAtual.Clear();
                txtUsuario.Clear();
                cboPergunta.Text = "";
                objCnx.Close();
            }
        }
    }
}
