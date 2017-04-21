using System;

namespace pesho
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			for (int currentDay = 1; currentDay <=5; currentDay++) {
			Console.WriteLine ("  day one");
			Console.WriteLine ("  Drink Coffee");
			Console.WriteLine ("  Programing");
			Console.WriteLine ("  Diner");
			Console.WriteLine ("  Obsujdat programata");
			Console.WriteLine ("  Go to colegues to drink BEER");
			}

			for (int currentDay = 10; currentDay >= 1; currentDay--) {
				Console.WriteLine ("Otpuska " + currentDay);
			}
		}
	}
}