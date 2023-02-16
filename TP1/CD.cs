using System;
namespace TP1
{
	public class CD : Media
    {
        protected string categorie = "";

        public CD() : base()
        {
        }

        //Constructeur qui throw une exception si la catégorie entré n'est pas une voulue.
        public CD(string titre, string nom, DateTime date,string categorie) : base( titre,  nom,  date)
		{
            this.categorie = categorie;

            if(this.categorie != "CD musical" || this.categorie != "OGG" || this.categorie != "MP3")
                throw new CategorieInvalideException("La Categorie entrée invalide.");
        }

        public CD(CD cd) : base()
        {
            base.titre = cd.titre;
            base.nom = cd.nom;
            base.date = cd.date;
            this.categorie = cd.categorie;
        }

        // Ajout categorie
        public override string ToString()
        {
            return "Titre :" + this.titre + " par : " + this.nom + "[" + this.categorie + "]" +",  date : jours : " + date.Day + " mois " + date.Month + " Annee : " + date.Year;
        }


        //Getter & Setter
        public void setCategorie(string categorie)
        {
            this.categorie = categorie;
        }

        public string getCategorie()
        {
            return this.categorie;
        }

    }
}

