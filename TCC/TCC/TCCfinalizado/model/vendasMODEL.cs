using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dto;
using dao;

namespace model
{
    public class vendasMODEL
    {
        public int quitarDivida(vendasDTO objVendasdto)
        {
            return new vendasDAO().quitarDivida(objVendasdto);
        }



        public int registrarCompra(vendasDTO objVendasdto)
        {
            return new vendasDAO().registrarCompra(objVendasdto);
        }
    }
}
