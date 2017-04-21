using System;

namespace numbersoneton
{
	class MainClass
	{
		public static void Main()
		{
			
			int a = int.Parse (Console.ReadLine());
			int b = 1;

			do {

				Console.WriteLine (b);
				b += 3; 

			} while (b<=a);
		}
	}
}