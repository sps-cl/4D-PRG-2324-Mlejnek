using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarriageApp.exceptions
{
    internal class InvalidEventException : Exception
    {
        public InvalidEventException(string message = "Tato událost neexistuje") : base(message) { }
    }
}
