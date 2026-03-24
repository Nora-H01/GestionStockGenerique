using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionStockGeneriqe.Interface;

namespace GestionStockGeneriqe.Classe
{
    public class Depot<T> : IDepot<T>
    {
        private List<T> _elements = new List<T>();

        public void Add(T item)
        {
            _elements.Add(item);
        }

        public void RemoveAt(int index)
        {
            _elements.RemoveAt(index);
        }

        public T Get(int index)
        {
            return _elements[index];
        }

        public int Count => _elements.Count;

        public void Afficher()
        {
            foreach (T item in _elements)
            {
                Console.WriteLine(item);
            }
        }
    }
}