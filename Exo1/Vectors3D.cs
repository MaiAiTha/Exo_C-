using System;
namespace Exo1
{
    class Vectors3D : Vectors2D
    {

        public double z;

        public Vectors3D()
        {}

        public Vectors3D(double x, double y, double z) : base(x,y)
        {
            this.z = z;
        }

        public Vectors3D(Vectors3D vector)
        {
            base.x = vector.x;
            base.y = vector.y;
            base.cpt++;
            this.z = vector.z;
        }

        public double getZ() { return this.z; }

        private void setZ(double z) { this.z = z; }

        public override string ToString()
        {
            return "X = " + x + " - Y = " + y + " - Z = " + z;
        }

        public bool Equals(Vectors3D vector)
        {
            if (base.x == vector.x && base.y == vector.y && this.z == vector.z)
                return true;
            else
                return false;
        }

        public new double GetNorm()
        {
            return Math.Sqrt(base.x * base.x + base.y * base.y + this.z * this.z);
        }

    }
}

