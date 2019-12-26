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
    public class vendasDAO
    {
        public int quitarDivida(vendasDTO objVendasdto)
        {

            using (MySqlConnection conexao = new MySqlConnection())
            {
                conexao.ConnectionString = "Server=localhost;database=BancoDeDados;user=root;password=1234;port=3306";
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                conexao.Open();
                comando.CommandText = "insert into vendas(data,valor_venda,descricao)values(@data,@valor_venda,@descricao)";

                string data = objVendasdto.Data_venda.ToString();
                string dataConvertida = Convert.ToDateTime(data).ToString("yyyy-MM-dd");

                comando.Parameters.Add("data", MySqlDbType.DateTime).Value = dataConvertida;
                comando.Parameters.Add("valor_venda", MySqlDbType.Decimal).Value = objVendasdto.Valor;
                comando.Parameters.Add("descricao", MySqlDbType.VarChar).Value = "Divida quitada";

                comando.Connection = conexao;
                int valor = comando.ExecuteNonQuery();
                return valor;
            }
        }

        public int registrarCompra(vendasDTO objVendasdto) 
        {
            using (MySqlConnection conexao = new MySqlConnection())
            {
                conexao.ConnectionString = "Server=localhost;database=BancoDeDados;user=root;password=1234;port=3306";
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                conexao.Open();
                comando.CommandText = "insert into vendas(data,valor_venda,preco,produto)values(@data,@valor_venda,@preco,@produto)";

                string data = objVendasdto.Data_venda.ToString();
                string dataConvertida = Convert.ToDateTime(data).ToString("yyyy-MM-dd");

                comando.Parameters.Add("data", MySqlDbType.DateTime).Value = dataConvertida;
                comando.Parameters.Add("valor_venda", MySqlDbType.Decimal).Value = objVendasdto.Valor;
                comando.Parameters.Add("preco", MySqlDbType.Decimal).Value = objVendasdto.Preco;
                comando.Parameters.Add("produto", MySqlDbType.VarChar).Value = objVendasdto.Produto;


                comando.Connection = conexao;
                int valor = comando.ExecuteNonQuery();
                return valor;
            }
        }
    }
}
