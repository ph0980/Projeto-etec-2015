using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dto;
using dao;

namespace model
{
    public class produtoMODEL
    {
        public int cadastrarProduto(produtoDTO objProdutoDTO)
        {
            return new produtoDAO().InserirDadosProduto(objProdutoDTO);
        }

        public int excluirProduto(produtoDTO objProdutoDTO)
        {
            return new produtoDAO().ExcluirDadosProduto(objProdutoDTO);
        }

        public int atualizarProduto(produtoDTO objProdutoDTO)
        {
            return new produtoDAO().AtualizarDadosProduto(objProdutoDTO);
        }
    }
}
