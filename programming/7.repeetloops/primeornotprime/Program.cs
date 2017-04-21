using System;

namespace primeornotprime
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var	number = int.Parse ( Console.ReadLine ());
			var prime = true;
			for (int i = 2; i < Math.Sqrt (number); i++) {

				if (number % i == 0) {
					prime = false;
				}
			}
			if (number < 2) {

				prime = false;
			}
			if (prime) {

			Console.WriteLine ("false");
			} else {
			Console.WriteLine ("Not prime");
			}	
		}
	}
}