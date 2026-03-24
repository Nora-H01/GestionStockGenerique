using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStockGeneriqe.Interface
{
    public interface IDepot<T>
    {
        void Add(T item);
        void RemoveAt(int index);
        T Get(int index);
        int Count { get; }
    }
}
