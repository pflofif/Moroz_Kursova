using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeronikaKursova.Services.Exceptions
{
    internal class EmptyFileException : Exception
    {
        public EmptyFileException() :base("Sorry, file is empty. Try to restart program")
        {
            
        }
    }
}
