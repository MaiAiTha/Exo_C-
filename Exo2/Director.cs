using System;
namespace Exo2
{
    class Director : Manager
    {

        public String Company = "";

        public Director()
        { }

        public Director(String FirstName, String LastName, string DateOfBirth, double Salary, String Departement, String Company) : base(FirstName, LastName, DateOfBirth, Salary, Departement)
        {
            this.Company = Company;
        }

        public override String Display()
        {
            return base.Display() + "/n Company : " + this.Company;
        }



    }
}

