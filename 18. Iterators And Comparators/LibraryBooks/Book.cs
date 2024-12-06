using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBooks
{
    public class Book
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public List<string> Authors {  get; private set; }

        public Book(string title, int year, params string[] authors) 
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                throw new ArgumentNullException("Title cannot be null or empty");
            }

            if (year < 0)
            {
                throw new ArgumentOutOfRangeException("Year cannot be negative");
            }

            Title = title;
            Year = year;
            Authors = new List<string>(authors);
        }

        public override string ToString()
        {
            string authors = Authors.Count > 0 ? string.Join(", ", Authors) : "No authors";
            return $"Title: {Title}, Year: {Year}, Authors: {authors}";
        }
    }
}
