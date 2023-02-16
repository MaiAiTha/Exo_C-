using System;
namespace TP1
{
    public class Livre : Media
    {

        public Livre() : base()
        {
        }

        public Livre(string titre, string nom, DateTime date) : base(titre, nom, date)
        {

        }

        public Livre(Livre livre) : base()
        {
            base.titre = livre.titre;
            base.nom = livre.nom;
            base.date = livre.date;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

