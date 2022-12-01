using System;

namespace BibliotecaDeClases
{
    public class DatoErroneoException : Exception
    {
        public DatoErroneoException(string message) : base(message)
        {
        }
    }
}
