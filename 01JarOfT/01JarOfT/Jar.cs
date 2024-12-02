using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01JarOfT
{
    public class Jar<T>
    {
        private Stack<T> stack = new Stack<T>();    

        public void Add(T item)
        {
            stack.Push(item);
        }

        public T Remove()
        {
            return stack.Pop();
        }
    }
}
