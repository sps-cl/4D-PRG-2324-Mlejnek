using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.models
{
    internal class Book : LibraryItem<Book>
    {
        public int NumberOfPages { get; }
        public string Author { get; }

        public Book(string author, int numberOfPages, int id, string title) : base(id, title)
        {
            Author = author;
            NumberOfPages = numberOfPages;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Autor {Author} a počet stran: {NumberOfPages}");
        }
    }
}
