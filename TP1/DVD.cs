using System;
namespace TP1
{
	public class DVD : Media
    {
		private int zone;

		public DVD(String titre, String nom, DateTime date,int zone) : base( titre,  nom,  date)
		{
			this.zone = zone;
			if (this.zone > 8)
				this.zone = 8;

		}

        public bool readable(int[] zones)
        {

			return true;

        }
	}
}

