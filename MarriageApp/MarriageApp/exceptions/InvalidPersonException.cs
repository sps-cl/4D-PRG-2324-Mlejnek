using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarriageApp.exceptions
{
    internal class InvalidPersonException : Exception
    {
        public InvalidPersonException(string message = "Tato osoba neexistuje") : base(message) { }
    }
}
