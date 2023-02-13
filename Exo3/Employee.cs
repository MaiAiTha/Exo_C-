using System;
namespace Exo3
{
    abstract public class Employee
    {

        public String Matricule ="";
        public String FirstName ="";
        public String LastName ="";
        public String DateOfBirth ="";

        public Employee()
        { }

        public Employee(String Matricule,String FirstName, String LastName, String DateOfBirth  )
        {
            this.Matricule = Matricule;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
        }


        public override String ToString()
        {
            return this.Matricule + this.FirstName + this.LastName + this.DateOfBirth;
        }

        public abstract double GetSalary();


    }
}

