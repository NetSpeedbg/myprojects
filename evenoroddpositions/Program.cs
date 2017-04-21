using System;

namespace evenoroddpositions
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			var n = int.Parse ( Console.ReadLine ());
			var OddSum = 0; 
			var OddMin = Int32.MaxValue;
			var OddMax = Int32.MinValue;
			var EvenSum = 0; 
			var EvenMin = 0;
			var EvenMax = 0;


			for (int i = 1; i <= n; i++) {
				var number = double.Parse ( Console.ReadLine ());
					if (i % 2 == 1); {

						OddSum += number;
						if (OddMin > number) {
							OddMin = number;
						}
						if (OddMin < number) {
							OddMax = number;
						}
					
				} else {
					
						EvenSum += number;
					if (EvenMin > number) {

						EvenMin = number;
					}
					if (EvenMax < number) {
						EvenMax = number;
					}

					Console.WriteLine ($"Oddsum = [Oddsum]");
					Console.WriteLine ($"Oddmin = [OddMin]") != Double.MaxValue; OddMin.
					Console.WriteLine ($"Oddmax = [OddMax]");
					Console.WriteLine ($"EvenSum = [EvenSum]");
					Console.WriteLine ($"EvenMin = [Evenmin]");
					Console.WriteLine ($"EvenMax = [EvenMax]");
				}
			}
		}
	}
}