using System;
namespace TP1
{
	public class DVD : Media
    {
		protected int zone;

        public DVD() : base()
        {
        }

        public DVD(string titre, string nom, DateTime date,int zone) : base( titre,  nom,  date)
		{
			this.zone = zone;
		}

        public DVD(DVD dvd) : base()
        {
            base.titre = dvd.titre;
            base.nom = dvd.nom;
            base.date = dvd.date;
            this.zone = dvd.zone;
        }


        public bool readable(int[] zones)
        {
                for (int i=0; i < zones.Length; i++)
                {
                    if (this.zone == 0 || zones[i] == this.zone)
                    {
					    return true;
                    }

                throw new ZoneInvalideException("La zone spécifiée n'est pas valide.");
                }
            
            return false;
        }


        public override string ToString()
        {
            return "Titre :" + this.titre + " par : " + this.nom + ' zone : ' + this.zone + ",  date : jours : " + date.Day + " mois " + date.Month + " Annee : " + date.Year;
        }
    }


}



