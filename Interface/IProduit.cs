using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStockGeneriqe.Interface
{
    public interface IProduit
    {
        string Nom { get; set; }
        double Prix { get; set; }
    }
}
