using System;

namespace pesho2
{
	class MainClass
	{
		public static void Main ()
		{
			var	number = 1000; 
			do {
				Console.WriteLine (number);
				number = number + 100;

			} while (number<1000);
		}
	}
}
