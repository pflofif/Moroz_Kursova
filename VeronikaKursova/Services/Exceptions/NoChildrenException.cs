using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeronikaKursova.Services.Exceptions
{
    internal class NoChildrenException : Exception
    
    {
        public NoChildrenException() 
            : base("There are no childrens\nPlease, add child or read information from file.")
        {
            
        }
    }
}
