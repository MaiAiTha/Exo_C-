using System;
namespace TP1
{
	public class CD : Media
    {
        protected string categorie;

        public CD(string titre, string nom, DateTime date,string categorie) : base( titre,  nom,  date)
		{
            this.categorie = categorie;

            if(this.categorie != "CD musical" || this.categorie != "OGG" || this.categorie != "MP3")
                throw new CategorieInvalideException("La Categorie entrée invalide.");
        }

        public override string ToString()
        {
            return "Titre :" + this.titre + " par : " + this.nom + '[' + this.categorie + ']' +",  date : jours : " + date.Day + " mois " + date.Month + " Annee : " + date.Year;
        }

    }
}

