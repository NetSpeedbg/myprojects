using System;

namespace numberofrange
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			
			Console.Write ("Еnter a number in the range [1...100]:");
			int a = int.Parse (Console.ReadLine ());

			bool running = true;

			if (a<100) {

				Console.WriteLine ("The number is:" + a);
			}
			else if (a>=100 || a<=0 ) {

				Console.WriteLine ("Invalid number!");
				Console.Write ("Еnter a number in the range [1...100]:");
				int b = int.Parse (Console.ReadLine ());

				a = b;
			}

		}
	}
}
