using System;
namespace Exo3
{
	public class Executive : Employee
    {
		public int index;
		public const double SMIG = 2500;

		public Executive(String Matricule, String FirstName, String LastName, String DateOfBirth, int index) : base( Matricule,  FirstName,  LastName,  DateOfBirth)
		{
			this.index = index;
		}

		public override double GetSalary()
		{
			switch (index)
			{
				case 1:
					return 13000;
				case 2:
					return 15000;
				case 3:
					return 17000;
                default:
					return 20000;

            }
		}
	}
}

