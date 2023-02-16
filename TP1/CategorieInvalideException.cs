using System;
namespace TP1
{
    public class CategorieInvalideException : Exception
    {
        public CategorieInvalideException() : base("Categorie entrée invalide.")
        {
        }

        public CategorieInvalideException(string message) : base(message)
        {
        }

        public CategorieInvalideException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}

