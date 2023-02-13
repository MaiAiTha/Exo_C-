using System;
namespace Exo1
{
	public class Vectors2D
	{
		public double x;
        public double y;
        public double cpt;

        public Vectors2D()
        {
        }

        public Vectors2D(double x, double y)
		{
			this.x = x;
			this.y = y;
			cpt++;
		}

        public Vectors2D(Vectors2D vector)
        {
            this.x = vector.x;
            this.y = vector.y;
            cpt++;
        }


        public double getX() { return this.x; }
        public double getY() { return this.y; }
        public double getCpt() { return this.cpt; }

        private void setX(double x){ this.x = x;}
        private void setY(double y) { this.y = y; }
        private void setCpt(double cpt) { this.cpt = cpt; }

        public override string ToString()
        {
            return "X = " + x + " - Y = " + y;
        }

        public bool Equals (Vectors2D vector)
        {
            if (this.x == vector.x && this.y == vector.y)
                return true;
            else
                return false;
        }

        public double GetNorm()
        {
            return Math.Sqrt(this.x * this.x + this.y * this.y);
        }

    }
}

