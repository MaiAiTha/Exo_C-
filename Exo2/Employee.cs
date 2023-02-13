using System;
namespace Exo2
{
    class Employee : Person
    {

        public double Salary;

        public Employee()
        { }

        public Employee(String FirstName, String LastName, string DateOfBirth, double Salary) : base(FirstName, LastName, DateOfBirth)
        {
            this.Salary = Salary;
        }

        public override String Display()
        {
            return base.Display() + "/n Salary : " + this.Salary;
        }



    }
}

