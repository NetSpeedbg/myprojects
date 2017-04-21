using System;

namespace Numberfrom100to200
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var number = double.Parse(Console.ReadLine());
			if (number > 200) {

				Console.WriteLine ("Greater than 200");
			} 
			else if (number >= 100) {
				Console.WriteLine ("Between 100 and 200");
			} 
			else {
				Console.WriteLine ("Less than 100");
			}
		}
	}
}