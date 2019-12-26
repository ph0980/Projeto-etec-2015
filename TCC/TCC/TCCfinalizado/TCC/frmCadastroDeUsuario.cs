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

    public partial class frmCadastroDeUsuario : Form
    {
        public MySqlConnection objCnx = new MySqlConnection();
        public MySqlCommand objCmd = new MySqlCommand();
        public MySqlDataReader objDados;

        public frmCadastroDeUsuario()
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
        private void cadastrarUsuario()
        {
            objCnx.Close();
            objCnx.Open();

            string strSql = "select * from Usuario where nome = '" + txtUsuario.Text + "'";
            objCmd.Connection = objCnx;
            objCmd.CommandText = strSql;
            objDados = objCmd.ExecuteReader();
            if (objDados.HasRows) { MessageBox.Show("Nome de usuário indisponível", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            else
            {
                strSql = "select * from Usuario";
                objCmd.Connection = objCnx;
                objCmd.CommandText = strSql;
                if (!objDados.IsClosed) { objDados.Close(); }
                objDados = objCmd.ExecuteReader();
                strSql = "Insert into Usuario (nome,senha,pergunta,resposta)" + "Values ('" + txtUsuario.Text + "','" + txtSenha.Text + "','" + cboPergunta.Text.ToString() + "','" + txtResposta.Text + "')";
                objCmd.Connection = objCnx;
                objCmd.CommandText = strSql;
                if (!objDados.IsClosed) { objDados.Close(); }
                objCmd.ExecuteNonQuery();
                MessageBox.Show("Registro incluido com sucesso", "Agenda", MessageBoxButtons.OK, MessageBoxIcon.Information);

                limpar();
            }
            objCnx.Close();
        }
        private void adicionarNoCombobox()
        {
            cboPergunta.Items.Clear();
            for (int i = 0;i<dgvPergunta.Rows.Count;i++){

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
        private void limpar()
        {

            txtrepetirSenha.Text = "";
            txtUsuario.Text = "";
            txtSenha.Text = "";
            cboPergunta.Text = "";
            txtResposta.Text = "";
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCadastroDeUsuario_Load(object sender, EventArgs e)
        {

            objCnx.ConnectionString = "Server=localhost; Database=BancoDeDados ;User=root; Pwd =1234; Port = 3306 ";
            listarPergunta();
            adicionarNoCombobox();
        }



        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                MessageBox.Show("Favor inserir o usuário", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
            }
            else if (txtSenha.Text == "")
            {
                MessageBox.Show("Favor inserir a senha", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSenha.Focus();
            }
            else if (txtrepetirSenha.Text != txtSenha.Text)
            {
                MessageBox.Show("Favor repetir a senha corretamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtrepetirSenha.Focus();
            }
            else if (cboPergunta.Text == "")
            {
                MessageBox.Show("Favor informar a pergunta de segurança", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboPergunta.Focus();
            }
            else if (txtResposta.Text == "")
            {
                MessageBox.Show("Favor inserir a resposta", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtResposta.Focus();
            }

            else
            {
                
                for (int i = 0; i < dgvPergunta.Rows.Count; i++)
                {

                    if (cboPergunta.Text == dgvPergunta.Rows[i].Cells[0].Value.ToString())
                    {
                        cadastrarUsuario();
                    }

                    else if (dgvPergunta.RowCount -1 == i)
                    {
                        objCnx.Open();
                        string strSql = "insert into pergunta(pergunta)  values  ('" + cboPergunta.Text + "')";
                        objCmd.Connection = objCnx;
                        objCmd.CommandText = strSql;
                        objDados.Close();
                        objDados = objCmd.ExecuteReader();


                        listarPergunta();
                        adicionarNoCombobox();
                        i--;
                    }
                }
               
            }
                }
            }
    }


