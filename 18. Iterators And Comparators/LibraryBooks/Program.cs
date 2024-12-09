using System.Collections.Immutable;
using System.Net.Http.Headers;

namespace LibraryBooks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("b title1", 2001);
            Book book2 = new Book("c title2", 2002, "author 1");
            Book book3 = new Book("a title3", 2003, "author 1", "author 2");

            Library library = new Library(book1, book2, book3);
            List<Book> books = new List<Book> { book1, book2, book3 };
            var bookComparator = new BookComparer();
            books.Sort(bookComparator);

            foreach (var book in library)
            {
                Console.WriteLine(book);
            }

            foreach (var book in books)
            {
                Console.WriteLine(book);
            }

            Console.WriteLine(book1.CompareTo(book2));
        }
    }
}
