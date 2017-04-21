using System;

namespace invalidnumber
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var number = int.Parse (Console.ReadLine ());
			var range = ((number >= 100 && number <= 200) || number == 0);
			if (!range) {

				Console.WriteLine ("invalid");
			}
		}
	}
}
