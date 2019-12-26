using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dto;
using MySql.Data.MySqlClient;
using System.Data;

namespace dao
{
    public class clienteDAO
    {
        public int inserirDadosCliente(clienteDTO objclientedto)
        {
            using (MySqlConnection conexao = new MySqlConnection())
            {
                conexao.ConnectionString = "Server=localhost;database=BancoDeDados;user=root;password=1234;port=3306";
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                conexao.Open();
                comando.CommandText = "insert into Cliente(cpf,nome,bairro,endereco,complemento,telefone,celular,divida)" +
                    "values(@cpf,@nome,@bairro,@endereco,@complemento,@telefone,@celular,@divida)";


                comando.Parameters.Add("divida", MySqlDbType.Decimal).Value = objclientedto.Divida;
                comando.Parameters.Add("cpf", MySqlDbType.VarChar).Value = objclientedto.Cpf;
                comando.Parameters.Add("nome", MySqlDbType.VarChar).Value = objclientedto.Nome;
                comando.Parameters.Add("bairro", MySqlDbType.VarChar).Value = objclientedto.Bairro;
                comando.Parameters.Add("endereco", MySqlDbType.VarChar).Value = objclientedto.Endereco;
                comando.Parameters.Add("complemento", MySqlDbType.VarChar).Value = objclientedto.Complemento;
                comando.Parameters.Add("telefone", MySqlDbType.VarChar).Value = objclientedto.Telefone;
                comando.Parameters.Add("celular", MySqlDbType.VarChar).Value = objclientedto.Celular;

                comando.Connection = conexao;
                int valor = comando.ExecuteNonQuery();
                return valor;
            }
        }

        public int listarDadosCliente(clienteDTO objclientedto)
        {
            using (MySqlConnection conexao = new MySqlConnection())
            {
                conexao.ConnectionString = "Server=localhost;database=BancoDeDados;user=root;password=1234;port=3306";
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexao;
                comando.CommandType = CommandType.Text;
                conexao.Open();
                comando.CommandText = "Select * from Cliente Order by id";
                comando.ExecuteNonQuery();
                DataTable datatable = new DataTable();
                MySqlDataAdapter dataadapter = new MySqlDataAdapter(comando);
                dataadapter.Fill(datatable);
                //dgvClientes.DataSource = datatable;
                comando.Connection = conexao;
                int valor = comando.ExecuteNonQuery();
                return valor;
            }
        }

        public int quitarDividaCliente(clienteDTO objclientedto)
        {
            using (MySqlConnection conexao = new MySqlConnection())
            {
                conexao.ConnectionString = "Server=localhost;database=BancoDeDados;user=root;password=1234;port=3306";
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                conexao.Open();
                comando.CommandText = "update Cliente set divida = '0' where id = @id";

                comando.Parameters.Add("id", MySqlDbType.Int32).Value = objclientedto.Id;

                comando.Connection = conexao;
                int valor = comando.ExecuteNonQuery();
                return valor;
            }
        }
        public int excluirDadosCliente(clienteDTO objclientedto)
        {
            using (MySqlConnection conexao = new MySqlConnection())
            {
                conexao.ConnectionString = "Server=localhost;database=BancoDeDados;user=root;password=1234;port=3306";
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                conexao.Open();
                comando.CommandText = "Delete from Cliente where id = @id";

                comando.Parameters.Add("id", MySqlDbType.Int32).Value = objclientedto.Id;

                comando.Connection = conexao;
                int valor = comando.ExecuteNonQuery();
                return valor;
            }
        }
        public int atualizarDadosCliente(clienteDTO objclientedto)
        {
            using (MySqlConnection conexao = new MySqlConnection())
            {
                conexao.ConnectionString = "Server=localhost;database=BancoDeDados;user=root;password=1234;port=3306";
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                conexao.Open();
                comando.CommandText = "Update Cliente set cpf = @cpf, nome = @nome, bairro = @bairro, endereco = @endereco, complemento = @complemento, telefone = @telefone, celular = @celular, divida = @divida where id = @id";

                comando.Parameters.Add("id", MySqlDbType.Int32).Value = objclientedto.Id;
                comando.Parameters.Add("divida", MySqlDbType.Decimal).Value = objclientedto.Divida;
                comando.Parameters.Add("cpf", MySqlDbType.VarChar).Value = objclientedto.Cpf;
                comando.Parameters.Add("nome", MySqlDbType.VarChar).Value = objclientedto.Nome;
                comando.Parameters.Add("bairro", MySqlDbType.VarChar).Value = objclientedto.Bairro;
                comando.Parameters.Add("endereco", MySqlDbType.VarChar).Value = objclientedto.Endereco;
                comando.Parameters.Add("complemento", MySqlDbType.VarChar).Value = objclientedto.Complemento;
                comando.Parameters.Add("telefone", MySqlDbType.VarChar).Value = objclientedto.Telefone;
                comando.Parameters.Add("celular", MySqlDbType.VarChar).Value = objclientedto.Celular;

                comando.Connection = conexao;
                int valor = comando.ExecuteNonQuery();
                return valor;
            }
        }
    }
}

