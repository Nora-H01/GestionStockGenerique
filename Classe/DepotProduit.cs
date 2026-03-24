using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionStockGeneriqe.Interface;

namespace GestionStockGeneriqe.Classe
{
    public class DepotProduit<T> : Depot<T> where T : IProduit
    {
        public double PrixTotal()
        {
            double total = 0;
            for (int i = 0; i < Count; i++)
            {
                total += Get(i).Prix;
            }
            return total;
        }
    }
}
