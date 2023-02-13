using System;
namespace Exo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Vectors2D vector2D1 = new Vectors2D(4, 8);
            Vectors2D vector2D2 = new Vectors2D(2, 6);

            Vectors3D vector3D1 = new Vectors3D(4, 8, 2);
            Vectors3D vector3D2 = new Vectors3D(2, 6, 4);

            vector2D1.ToString();
            vector2D2.ToString();
            vector3D1.ToString();
            vector3D2.ToString();

            vector2D1.Equals(vector2D2);
            vector2D1.Equals(vector2D1);

            vector3D1.Equals(vector3D2);
            vector3D1.Equals(vector3D1);

            vector2D1.GetNorm();
            vector3D1.GetNorm();

            vector2D1.getCpt();
            vector3D1.getCpt();
        }
    }
}

