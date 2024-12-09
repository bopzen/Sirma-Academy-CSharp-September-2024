using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01SingleResponsibilityPrincipleSRP
{
    public class BookRepository
    {
        public void SaveToDatabase(Book book)
        {
            Console.WriteLine($"{book.Title} saved to database");
        }
    }
}
