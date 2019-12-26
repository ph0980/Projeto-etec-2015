﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dto;

namespace dto
{
     public class clienteDTO
    {
        private int id;
        private string cpf;
        private string nome;
        private string bairro;
        private string endereco;
        private string complemento;
        private string telefone;
        private string celular;
        private Decimal divida;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }



        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }


        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }


        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }


        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }


        public string Complemento
        {
            get { return complemento; }
            set { complemento = value; }
        }


        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public string Celular
        {
            get { return celular; }
            set { celular = value; }
        }

        public Decimal Divida
        {
            get { return divida; }
            set { divida = value; }
        }
    }
}

