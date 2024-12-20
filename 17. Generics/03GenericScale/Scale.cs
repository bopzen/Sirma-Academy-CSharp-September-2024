﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03GenericScale
{
    public class Scale<T> where T: IComparable<T>
    {
        private T left;
        private T right;

        public Scale(T left, T right)
        {
            this.left = left;
            this.right = right;
        }

        public T GetHeavier()
        {
            if (this.left.CompareTo(this.right) > 0)
            {
                return this.left;
            }
            else if (this.left.CompareTo(this.right) < 0)
            {
                return this.right;
            }
            else
            {
                return default;
            }
        }
    }
}
