using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.models
{
    internal class DVD : LibraryItem<DVD>
    {
        public int Length { get; }
        public string Author { get; }

        public DVD(string author, int length, int id, string title) : base(id, title)
        {
            Author = author;
            Length = length;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Autor {Author} a délka stopy: {Length}");
        }
    }
}
