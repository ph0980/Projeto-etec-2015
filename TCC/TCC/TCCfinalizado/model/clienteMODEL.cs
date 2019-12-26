using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dto;
using dao;

namespace model
{
    public class clienteMODEL
    {
        public int cadastrarCliente(clienteDTO objclientedto)
        {
            return new clienteDAO().inserirDadosCliente(objclientedto);
        }

        public int excluirCliente(clienteDTO objclientedto)
        {
            return new clienteDAO().excluirDadosCliente(objclientedto);
        }

        public int atualizarCliente(clienteDTO objclientedto)
        {
            return new clienteDAO().atualizarDadosCliente(objclientedto);
        }
        public int quitarDividaCliente(clienteDTO objclientedto)
        {
            return new clienteDAO().quitarDividaCliente(objclientedto);
        }

        public int listarCliente(clienteDTO objclientedto)
        {
            return new clienteDAO().listarDadosCliente(objclientedto);
        }
    }
}
