using System;

namespace to100range
{
	class MainClass
	{
		public static void Main ()
		{
			Console.WriteLine ("Еnter a number in the range");
			int number = int.Parse(Console.ReadLine ());
			while (number < 1 || number > 100 ) {

				Console.WriteLine ("Invalid number!");
				Console.WriteLine ("Еnter a number in the range [1...100]:");
				number = int.Parse ( Console.ReadLine ());
			}
			Console.WriteLine ("The number is: {0}",number);
		}
	}
}
