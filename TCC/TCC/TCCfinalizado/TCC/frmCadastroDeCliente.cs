using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using dto;
using model;



namespace TCC
{
    public partial class frmCadastroDeCliente : Form
    {
        public MySqlConnection objCnx = new MySqlConnection();
        public MySqlCommand objCmd = new MySqlCommand();
        public MySqlDataReader objDados;

        public frmCadastroDeCliente()
        {
            InitializeComponent();
        }
        private void frmCadastroDeCliente_Load(object sender, EventArgs e)
        {
            objCnx.ConnectionString = "Server=localhost; Database=BancoDeDados ;User=root; Pwd =1234; Port = 3306 ";
            listarCliente();   
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            if  (keyData == Keys.F1)
            {
                cadastrar();
                listarCliente();
            }
            if (keyData == Keys.F2)
            {
                ExcluirCliente();
                listarCliente();
            }
            if (keyData == Keys.F3)
            {
                atualizarCliente();
                listarCliente();
            }
            if (keyData == Keys.F4)
            {
                quitarDivida();
                listarCliente();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        clienteDTO objclientedto = new clienteDTO();
        vendasDTO objVendasdto = new vendasDTO();






        private void cadastrar()
        {

            if (txtDivida.Text == "")
            {
                MessageBox.Show("Favor inserir Divida! ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDivida.Focus();
            }
            else if (txtCPF.Text == "")
            {
                MessageBox.Show("Favor inserir CPF! ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCPF.Focus();
            }
            else if (!Validacao.ValidaCPF(txtCPF.Text))
            {
                MessageBox.Show("CPF Inválido!");
                txtCPF.Focus();
            }
            else if (txtNome.Text == "")
            {
                MessageBox.Show("Favor inserir Nome!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
            }
            else if (txtBairro.Text == "")
            {
                MessageBox.Show("Favor inserir Bairro! ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBairro.Focus();
            }
            else if (txtEndereco.Text == "")
            {
                MessageBox.Show("Favor inserir Endereço! ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEndereco.Focus();
            }
            else if (txtTelefone.Text.Length < 13 && txtCelular.Text != "(  )     -")
            {
                MessageBox.Show("Telefone inválido! ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCPF.Focus();
            }
            else if (txtCelular.Text.Length < 14 && txtCelular.Text != "(  )     -")
            {
                MessageBox.Show("Celular inválido! ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCelular.Focus();
            }
            else
            {
                objCnx.ConnectionString = "Server=localhost; Database=BancoDeDados ;User=root; Pwd =1234; Port = 3306 ";
                objCnx.Open();
                string strSql = "select * from Cliente where nome = '" + txtNome.Text + "' or cpf ='" + txtCPF.Text + "'";
                objCmd.Connection = objCnx;
                objCmd.CommandText = strSql;
                //if (!objDados.IsClosed) { objDados.Close(); }
                objDados = objCmd.ExecuteReader();
                if (objDados.HasRows) { MessageBox.Show("Dados pertencentes a outro cliente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                else {
                    try
                    {
                        objclientedto.Cpf = txtCPF.Text;
                        objclientedto.Nome = txtNome.Text;
                        objclientedto.Bairro = txtBairro.Text;
                        objclientedto.Endereco = txtEndereco.Text;
                        objclientedto.Complemento = txtComplemento.Text;
                        objclientedto.Telefone = txtTelefone.Text;
                        objclientedto.Celular = txtCelular.Text;
                        objclientedto.Divida = Convert.ToDecimal(txtDivida.Text);
                    }
                    catch (Exception Erro)
                    {
                        MessageBox.Show("Erro na Conexão", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    int x = new clienteMODEL().cadastrarCliente(objclientedto);
                    if (x > 0)
                    {
                        MessageBox.Show(string.Format("O cliente {0}, foi cadastrado com sucesso !! ", txtNome.Text));
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível cadastrar este cliente.");
                    }
                    LimparCampoCliente();
                    objCnx.Close();
                }
            }
            objCnx.Close();
        }

        private void LimparCampoCliente()
        {
            txtId.Text = "";
            txtCPF.Text = "";
            txtCelular.Text = "";
            txtTelefone.Text = "";
            txtBairro.Text = "";
            txtEndereco.Text = "";
            txtComplemento.Text = "";
            txtNome.Text = "";
            txtDivida.Text = "";
            txtDivida.Focus();
           
        }

        private void ExcluirCliente()
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Favor selecionar um cliente! ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("Deseja excluir", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    try
                    {
                        objclientedto.Id = Convert.ToInt32(txtId.Text);
                    }
                    catch (Exception Erro)
                    {
                        //MessageBox.Show("Erro na Conexão", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    int x = new clienteMODEL().excluirCliente(objclientedto);
                    if (x > 0)
                    {
                        MessageBox.Show(string.Format("Os dados do cliente {0}, foram excluidos com sucesso !! ", txtNome.Text));
                    }
                    else
                    {
                        MessageBox.Show(" Nenhum cliente selecionado.");
                    }
                }
            }
        }

        private void listarCliente()
        {
            objCnx.Open();
            try
            {
                string strSql = "Select * from Cliente Order by id";
                objCmd.Connection = objCnx;
                objCmd.CommandText = strSql;
                objCmd.ExecuteNonQuery();


                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(objCmd);
                da.Fill(dt);
                dgvClientes.DataSource = dt;
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro ==>" + Erro.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            objCnx.Close();
        }

        private void atualizarCliente()
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Favor selecionar um cliente! ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDivida.Focus();
            }
            else if (txtDivida.Text == "")
            {
                MessageBox.Show("Favor inserir Divida! ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDivida.Focus();
            }
            else if (txtCPF.Text == "")
            {
                MessageBox.Show("Favor inserir CPF! ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCPF.Focus();
            }
            else if (txtNome.Text == "")
            {
                MessageBox.Show("Favor inserir Nome!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
            }
            else if (txtBairro.Text == "")
            {
                MessageBox.Show("Favor inserir Bairro! ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBairro.Focus();

            }
            else if (txtEndereco.Text == "")
            {
                MessageBox.Show("Favor inserir Endereço! ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEndereco.Focus();
            }
            else if (!Validacao.ValidaCPF(txtCPF.Text))
            {
                MessageBox.Show("CPF Inválido!");
            }
            else if (txtTelefone.Text.Length < 13 && txtCelular.Text != "(  )     -")
            {
                MessageBox.Show("Telefone inválido! ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCPF.Focus();
            }
            else if (txtCelular.Text.Length < 14 && txtCelular.Text != "(  )     -")
            {
                MessageBox.Show("Celular inválido! ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCelular.Focus();
            }
            else
            {
                objCnx.ConnectionString = "Server=localhost; Database=BancoDeDados ;User=root; Pwd =1234; Port = 3306 ";
                objCnx.Open();
                string strSql = "select * from cliente where nome = '" + txtNome.Text + "' and cpf <> '" + txtCPF.Text + "'";
                objCmd.Connection = objCnx;
                objCmd.CommandText = strSql;
                objDados = objCmd.ExecuteReader();
                if (objDados.HasRows) { MessageBox.Show("Dados pertencentes a outro cliente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                else {
                    try
                    {
                        objclientedto.Id = Convert.ToInt32(txtId.Text);
                        objclientedto.Cpf = txtCPF.Text;
                        objclientedto.Nome = txtNome.Text;
                        objclientedto.Bairro = txtBairro.Text;
                        objclientedto.Endereco = txtEndereco.Text;
                        objclientedto.Complemento = txtComplemento.Text;
                        objclientedto.Telefone = txtTelefone.Text;
                        objclientedto.Celular = txtCelular.Text;
                        objclientedto.Divida = Convert.ToDecimal(txtDivida.Text);

                    }
                    catch (Exception Erro)
                    {
                        MessageBox.Show("Erro na Conexão", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    int x = new clienteMODEL().atualizarCliente(objclientedto);
                    if (x > 0)
                    {
                        MessageBox.Show(string.Format("Os dados do cliente {0}, foram atualizados com sucesso !! ", txtNome.Text));
                    }
                    else
                    {
                        MessageBox.Show("Não foi possivel atualizar os dados deste cliente.");
                    }
                    LimparCampoCliente();
                }
            }
                objCnx.Close();
        }

        public void quitarDivida()
        {
            if(txtDivida.Text == "" || txtId.Text == "" ||dtData.Text == "")
            {
                MessageBox.Show("Nenhum cliente selecionado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                objVendasdto.Valor = Convert.ToDecimal(txtDivida.Text);
                objVendasdto.Data_venda = Convert.ToDateTime(dtData.Text);
                objclientedto.Id = Convert.ToInt32(txtId.Text);


                int x = new vendasMODEL().quitarDivida(objVendasdto);
                int x1 = new clienteMODEL().quitarDividaCliente(objclientedto);
                if (x > 0 || x1 > 0)
                {
                    MessageBox.Show(string.Format("A dívida do cliente {0}, foi quitada com sucesso !! ", txtNome.Text));
                }
                else
                {
                    MessageBox.Show("Não foi possível quitar a dívida este cliente.");
                }
            }
          
           
           
        }



        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparCampoCliente();
        }

      

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            cadastrar();
            listarCliente();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ExcluirCliente();
            listarCliente();
            LimparCampoCliente();
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            quitarDivida();
            listarCliente();
            LimparCampoCliente();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            atualizarCliente();
            listarCliente();
           
        }

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvClientes.CurrentRow.Cells[0].Value.ToString();
            txtCPF.Text = dgvClientes.CurrentRow.Cells[1].Value.ToString();
            txtNome.Text = dgvClientes.CurrentRow.Cells[2].Value.ToString();
            txtBairro.Text = dgvClientes.CurrentRow.Cells[3].Value.ToString();
            txtEndereco.Text = dgvClientes.CurrentRow.Cells[4].Value.ToString();
            txtComplemento.Text = dgvClientes.CurrentRow.Cells[5].Value.ToString();
            txtCelular.Text = dgvClientes.CurrentRow.Cells[7].Value.ToString();
            txtTelefone.Text = dgvClientes.CurrentRow.Cells[6].Value.ToString();
            txtDivida.Text = dgvClientes.CurrentRow.Cells[8].Value.ToString();

        }

        private void txtDivida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsSeparator(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        
    }
    }

       


    

