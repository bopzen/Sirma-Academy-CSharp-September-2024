using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBooks
{
    public class BookComparer : IComparer<Book>
    {
        public int Compare(Book? x, Book? y)
        {
            int result = x.CompareTo(y);
            if (result == 0)
            {
                result = x.CompareTo(y);
            }
            return result;
        }
    }
}
