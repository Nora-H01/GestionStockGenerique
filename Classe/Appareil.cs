using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionStockGeneriqe.Interface;

namespace GestionStockGeneriqe.Classe
{
    public class Appareil : IProduit
    {
        public string Nom { get; set; }
        public double Prix { get; set; }
    }
}
