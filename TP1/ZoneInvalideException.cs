using System;
namespace TP1
{
    public class ZoneInvalideException : Exception
    {
        public ZoneInvalideException() : base("La zone spécifiée n'est pas valide.")
        {
        }

        public ZoneInvalideException(string message) : base(message)
        {
        }

        public ZoneInvalideException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public ZoneInvalideException(ZoneInvalideException ex)
        {
        }
    }

}

