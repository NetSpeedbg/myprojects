using System;

namespace kplisone
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			double n = double.Parse ( Console.ReadLine ());
			double result = 0;

			Console.WriteLine ("1");

			do {
				result=(n*2)+1;
				Console.WriteLine (result);

			} while (result <= n);
				

		}
	}
}
