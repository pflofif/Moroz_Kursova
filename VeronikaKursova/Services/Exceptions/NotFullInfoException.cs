using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeronikaKursova.Services.Exceptions
{
    internal class NotFullInfoException : Exception
    {
        public NotFullInfoException() : base(@"Not all information is filled or you make mistake!
Please, check if you fill each fields correctly.")
        {
        }
        
    }
}
