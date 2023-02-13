using System;
namespace Exo3
{
	public class Worker : Employee
    {
		public DateTime EntryDate;
		public const double SMIG = 2500;

		public Worker(String Matricule, String FirstName, String LastName, String DateOfBirth, DateTime EntryDate) : base( Matricule,  FirstName,  LastName,  DateOfBirth)
		{
			this.EntryDate = EntryDate;
		}

		public override double GetSalary()
		{
			if (SMIG * 2 > SMIG + (DateTime.Now.Year - EntryDate.Year) * 100)
				return SMIG + (DateTime.Now.Year - EntryDate.Year) * 100;
			else
				return SMIG * 2;
		}
	}
}

