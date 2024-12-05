using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10CustomList
{
    public class CustomList<T> where T : IComparable<T>
    {
        private readonly List<T> _list;

        public void Add(T element)
        {
            _list.Add(element);
        }

        public T Remove(int index)
        {
            T element = _list[index];
            _list.RemoveAt(index);
            return element;
        }

        public bool Contains(T element)
        {
            return _list.Contains(element);
        }

        public void Swap(int indexOne, int indexTwo)
        {
            (_list[indexTwo], _list[indexOne]) = (_list[indexOne], _list[indexTwo]);
        }

        public int CountGreaterThan(T element)
        {
            int counter = 0;
            foreach (T currentElement in _list)
            {
                if (currentElement.CompareTo(element) > 0)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
