using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.exceptions
{
    internal class NotFoundException : Exception
    {
        public NotFoundException(string message = "Knížka nebyla nalezena!") : base(message) { }
    }
}