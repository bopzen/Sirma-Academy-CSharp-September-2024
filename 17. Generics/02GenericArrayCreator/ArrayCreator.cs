using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _02GenericArrayCreator
{
    public class ArrayCreator<T>
    {
        public static T[] Create(int length, T item)
        {
            T[] array = new T[length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = item;
            }
            return array;
        }

        public static T[] Create(Type type, int length, T item)
        {
            if (type != typeof(T))
            {
                throw new ArgumentException($"Provided type {type} does not match the generic type {typeof(T)}.");
            }
            return Create(length, item);
        }
    }
}
