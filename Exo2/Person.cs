using System;
namespace Exo2
{
    public class Person
    {
        private String FirstName = "";
        private String LastName = "";
        private String DateOfBirth = "";

        public Person()
        {
        }

        public Person(String FirstName, String LastName, String DateOfBirth)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
        }

        public Person(Person person)
        {
            this.FirstName = person.FirstName;
            this.LastName = person.LastName;
            this.DateOfBirth = person.DateOfBirth;
        }


        public virtual String Display()
        {
            return "First Name : " + this.FirstName + "/n Last Name : " + this.LastName + "/n Date Of Birth : " + this.DateOfBirth;
        }

        

    }
}

