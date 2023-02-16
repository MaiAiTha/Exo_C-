using System;
namespace TP1
{
	public class DVD : Media
    {
		protected int zone;

		public DVD(string titre, string nom, DateTime date,int zone) : base( titre,  nom,  date)
		{
			this.zone = zone;
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
    }

}



