using System;

namespace xoneagain
{
	class MainClass

	//21
	//75.00
	//1.59

	//15
	//105
	//1.71

	{
		public static void Main (string[] args)
		{
			double days = double.Parse ( Console.ReadLine ());
			double moneyparday = double.Parse ( Console.ReadLine ());
			double course = double.Parse ( Console.ReadLine ());

			double montsalary = days * moneyparday;
			double yearsalary = montsalary * 12 + montsalary * 2.5;
			double taxes = yearsalary * 0.25;
			double clearyearprofit = yearsalary - taxes;
			double moneyconverter = clearyearprofit * course;
			double earnmoneyperday = moneyconverter / 365 ;
			earnmoneyperday = Math.Round (earnmoneyperday, 2);


			//Console.WriteLine (montsalary);
			//Console.WriteLine (yearsalary);
			//Console.WriteLine (taxes);
			//Console.WriteLine (clearyearprofit);
			//Console.WriteLine (moneyconverter);
			Console.WriteLine (earnmoneyperday);

		}
	}
}