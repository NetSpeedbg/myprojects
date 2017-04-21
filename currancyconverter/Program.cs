using System;

namespace currancyconverter
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var value = double.Parse (Console.ReadLine ());
			var currancy1 = Console.ReadLine ();
			var currancy2 = Console.ReadLine ();

			var bgnlv = 1;
			var bgusd = 1.79549;
			var bgeur = 1.95583;
			var bggbp = 2.53405;

			if (currancy1 == "BGN" ) {
				if (currancy2 == "USD") {
					
					Console.WriteLine (System.Math.Round(value/bgusd,2));
				}

				if (currancy2 == "EUR") {

					Console.WriteLine (System.Math.Round(value/bgeur,2));
				}

				if (currancy2 == "GBP") {

					Console.WriteLine (System.Math.Round(value/bggbp,2));
				}


			}

			if (currancy1 == "USD") {

				if (currancy2 == "BGN") {

					Console.WriteLine (System.Math.Round(value*bgusd,2));
				}
			
				if (currancy2 == "EUR") {

					Console.Write (System.Math.Round((value*bgusd)/bgeur,2));
				}

				if (currancy2 == "GBP") {

					Console.WriteLine (System.Math.Round((value*bgusd)/bggbp,2));
				}
			}

			if (currancy1 == "EUR") {

				if (currancy2 == "BGN") {

					Console.WriteLine (System.Math.Round(value/bgnlv,2));
				}
				if (currancy2 == "USD") {

					Console.WriteLine (System.Math.Round((value*bgeur)/bgusd,2));
				}
				if (currancy2 == "GBP") {

					Console.WriteLine (System.Math.Round ((value*bgeur)/bggbp,2));
				}

			}
			if (currancy1 == "GBP") {
				if (currancy2 == "BGN") {

					Console.WriteLine (System.Math.Round(value/bgnlv,2));
				}
			
				if (currancy2 == "USD") {

					Console.WriteLine (System.Math.Round ((value*bggbp)/bgusd,2));
				}
				if (currancy2 == "EUR") {
					Console.WriteLine (System.Math.Round (value*bgeur,2));
				}
			}
			Console.Write (" " +currancy2);
		}
	}
}