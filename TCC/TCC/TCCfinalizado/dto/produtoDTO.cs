using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dto
{
    public class produtoDTO
    {
        private int idprod;
        private string tipo;
        private string produto;
        private string peso;
        private decimal preco;
        private int quantidade;
        private string cod;


        public int Idprod
        {
            get { return idprod; }
            set { idprod = value; }
        }


        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }


        public string Produto
        {
            get { return produto; }
            set { produto = value; }
        }


        public string Peso
        {
            get { return peso; }
            set { peso = value; }
        }


        public decimal Preco
        {
            get { return preco; }
            set { preco = value; }
        }


        public int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }

        public string Cod
        {
            get{return cod;}
            set{cod = value;}
        }
    }
}

