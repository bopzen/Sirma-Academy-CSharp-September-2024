namespace LibraryBooks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("title1", -2001);
            Book book2 = new Book("title2", 2002, "author 1");
            Book book3 = new Book("title3", 2003, "author 1", "author 2");

            Console.WriteLine(book1);
            Console.WriteLine(book2);
            Console.WriteLine(book3);
        }
    }
}
