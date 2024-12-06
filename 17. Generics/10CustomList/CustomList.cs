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

        public CustomList()
        {
            _list = new List<T>();
        }

        public void Add(T element)
        {
            _list.Add(element);
        }

        public T Remove(int index)
        {
            if (index >=0 && index < _list.Count)
            {
                T element = _list[index];
                _list.RemoveAt(index);
                return element;
            }
            throw new IndexOutOfRangeException();
        }

        public bool Contains(T element)
        {
            return _list.Contains(element);
        }

        public void Swap(int indexOne, int indexTwo)
        {
            if (indexOne >=0 && indexOne < _list.Count && indexTwo >=0 && indexTwo < _list.Count)
            {
                (_list[indexTwo], _list[indexOne]) = (_list[indexOne], _list[indexTwo]);
            }
            
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

        public T GetMax()
        {
            return _list.Max();
        }

        public T GetMin()
        {
            return _list.Min();
        }

        public void Print()
        {
            foreach (T element in _list)
            {
                Console.WriteLine(element);
            }
        }
    }
}
