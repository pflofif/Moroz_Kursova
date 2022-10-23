using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeronikaKursova.Services.Exceptions
{
    internal static class ExceptionExtensions
    {
        public static T Rethrow<T>(this Exception e) => (T)Activator.CreateInstance(typeof(T))!;
    }
}
