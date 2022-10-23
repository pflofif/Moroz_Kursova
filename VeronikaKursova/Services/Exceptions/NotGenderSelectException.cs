using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeronikaKursova.Services.Exceptions
{
    internal class NotGenderSelectException : Exception
    {
        public NotGenderSelectException()
            :base("Inedible present created by gender. Please, select child's gender.")
        {
        }
    }
}
