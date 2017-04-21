using System;

namespace trip
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var	money = decimal.Parse ( Console.ReadLine ());
			var	season = Console.ReadLine() .ToLower;
			var	budged = 0.00M;
			if (money <=100.000M && season=="summer") {
				budged == money * 0.3;
				Console.WriteLine ("„Somewhere in Bulgaria");
				Console.WriteLine ("Camp - {0:F2}",budged);
			}
		
			else if (money <= 100.000M && season == "winter") {

				budged = money * 0.7;
				Console.WriteLine ("Somewhere in Balkans");
				Console.WriteLine ("Hotel - {0:F2}",budged);

				{
			
		}

		}
	
	}
}
