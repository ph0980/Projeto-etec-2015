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

    public class produtoDAO
    {

        public int InserirDadosProduto(produtoDTO objProdutoDTO)
        {
            using (MySqlConnection conexao = new MySqlConnection())
            {
                conexao.ConnectionString = "Server=localhost;database=BancoDeDados;user=root;password=1234;port=3306";
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                conexao.Open();
                comando.CommandText = "Insert into Produto (cod_barras,tipo,produto,descricao,preco,quantidade) Values (@cod_barras,@tipo,@produto,@descricao,@preco,@quantidade)";

                comando.Parameters.Add("cod_barras", MySqlDbType.VarChar).Value = objProdutoDTO.Cod;
                comando.Parameters.Add("tipo", MySqlDbType.VarChar).Value = objProdutoDTO.Tipo;
                comando.Parameters.Add("produto", MySqlDbType.VarChar).Value = objProdutoDTO.Produto;
                comando.Parameters.Add("descricao", MySqlDbType.VarChar).Value = objProdutoDTO.Peso;
                comando.Parameters.Add("preco", MySqlDbType.Decimal).Value = objProdutoDTO.Preco;
                comando.Parameters.Add("quantidade", MySqlDbType.Int32).Value = objProdutoDTO.Quantidade;

                comando.Connection = conexao;
                int valor = comando.ExecuteNonQuery();
                return valor;
            }
        }

        public int AtualizarDadosProduto(produtoDTO objProdutoDTO)
        {
            using (MySqlConnection conexao = new MySqlConnection())
            {
                conexao.ConnectionString = "Server=localhost;database=BancoDeDados;user=root;password=1234;port=3306";
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                conexao.Open();
                comando.CommandText = "Update Produto set cod_barras=@cod_barras, tipo = @tipo , produto= @produto , descricao= @descricao , preco= @preco , quantidade= @quantidade where idprod = @idprod";

                comando.Parameters.Add("cod_barras", MySqlDbType.VarChar).Value = objProdutoDTO.Cod;
                comando.Parameters.Add("idprod", MySqlDbType.Int32).Value = objProdutoDTO.Idprod;
                comando.Parameters.Add("tipo", MySqlDbType.VarChar).Value = objProdutoDTO.Tipo;
                comando.Parameters.Add("produto", MySqlDbType.VarChar).Value = objProdutoDTO.Produto;
                comando.Parameters.Add("descricao", MySqlDbType.VarChar).Value = objProdutoDTO.Peso;
                comando.Parameters.Add("preco", MySqlDbType.Decimal).Value = objProdutoDTO.Preco;
                comando.Parameters.Add("quantidade", MySqlDbType.Int32).Value = objProdutoDTO.Quantidade;

                comando.Connection = conexao;
                int valor = comando.ExecuteNonQuery();
                return valor;
            }
        }
        public int ExcluirDadosProduto(produtoDTO objProdutoDTO)
        {

            using (MySqlConnection conexao = new MySqlConnection())
            {
                conexao.ConnectionString = "Server=localhost;database=BancoDeDados;user=root;password=1234;port=3306";
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                conexao.Open();
                comando.CommandText = "Delete from Produto where idprod = @idprod";
                comando.Parameters.Add("idprod", MySqlDbType.Int32).Value = objProdutoDTO.Idprod;
                comando.Connection = conexao;
                int valor = comando.ExecuteNonQuery();
                return valor;
            }
        }
    }
}
