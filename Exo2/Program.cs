using System;
using System.Numerics;

namespace Exo2
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Person> people = new List<Person>
            {
                new Employee("Axel","Pape","Demain",1200),
                new Employee("Misha","Setta","Hier",2400),
                new Employee("Fabien","Poulain","06/06/3030",1900),
                new Employee("Thibault","Verlain","90/90/2023",1700),
                new Employee("Bastien","Lambert","23/12/2023",1900),
                new Manager("Emile","DeGaule","Apres-demain",3000,"SI"),
                new Manager("Yanis","Zoubi","Samedi",3400,"SE"),
                new Director("Nassim","SI MOHAMMED","Chut",90000,"ALL","Feed")
        };

            foreach (Person person in people)
            {
                Console.WriteLine(person.ToString());
            }
            Console.ReadLine();

        }
    }
}

