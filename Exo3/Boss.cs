using System;
namespace Exo3
{
	public class Boss : Employee
    {
		public const double turnover = 10;
		public double percent;

		public Boss(String Matricule, String FirstName, String LastName, String DateOfBirth, double percent) : base( Matricule,  FirstName,  LastName,  DateOfBirth)
		{
			this.percent = percent;
		}

		public override double GetSalary()
		{
			return turnover * percent * 100;
		}
	}
}

