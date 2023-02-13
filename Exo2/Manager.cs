using System;
namespace Exo2
{
    class Manager : Employee
    {

        public String Departement = "";

        public Manager()
        { }

        public Manager(String FirstName, String LastName, string DateOfBirth, double Salary, String Departement) : base(FirstName, LastName, DateOfBirth, Salary)
        {
            this.Departement = Departement;
        }

        public override String Display()
        {
            return base.Display() + "/n Departement : " + this.Departement;
        }



    }
}

