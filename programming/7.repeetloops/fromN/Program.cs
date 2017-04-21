using System;

namespace fromN
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var n = int.Parse ( Console.ReadLine ());
			for (int i = n; i >= 1; i--) {

				Console.WriteLine (i);

			}

			do {

				Console.WriteLine (n);
				n--;

			} while (n>=1);
		}
	}
}
