using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStockGeneriqe.Interface
{
    public interface ICondition<T>
    {
        bool Verifier(T element);
    }
}
