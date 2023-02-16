using System;
namespace TP1
{
    public class Media
    {
        protected string titre ="";
        protected string nom ="";
        protected DateTime date;

        public Media()
        {
        }

        public Media(string Titre, string Nom, DateTime Date)
        {
            this.titre = Titre;
            this.nom = Nom;
            this.date = Date;
        }

        public string getTitre()
        {
            return this.titre;
        }
        public void setTitre(string value)
        {
            this.titre = value;
        }
        public string getNom()
        {
            return this.nom;
        }
        public void setNom(string value)
        {
            this.nom = value;
        }
        public DateTime getDate()
        {
            return this.date;
        }
        public void setDate(DateTime value)
        {
            this.date = value;
        }
        public override string ToString()
        {
            return "Titre :" + this.titre + " par : " + this.nom + ",  date : jours : " + date.Day + " mois " + date.Month + " Annee : " + date.Year;
        }
    }
}

