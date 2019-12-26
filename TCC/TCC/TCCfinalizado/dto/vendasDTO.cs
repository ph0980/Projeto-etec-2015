using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dto
{
    public class vendasDTO
    {
        private decimal valor;
        private DateTime data_venda;
        private decimal preco;
        private string produto;

        public string Produto
        {
            get { return produto; }
            set { produto = value; }
        } 

        

        public decimal Preco
        {
            get { return preco; }
            set { preco = value; }
        }

        public decimal Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public DateTime Data_venda
        {
            get { return data_venda; }
            set { data_venda = value; }
        }


    }
}
