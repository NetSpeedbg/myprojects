using System;

namespace tasktwo
{
	class MainClass
	{
		public static void Main ()
		{
			int hours = int.Parse (Console.ReadLine ());
			int days = int.Parse (Console.ReadLine ());
			int workers = int.Parse (Console.ReadLine ());

			int result = 0.9 * days * 8 + workers * 2 * days; 
			if (Math.Floor(result>=hours)) {

				Console.WriteLine ("Yes!{0} hours left.",Math.Floor(result)-hours);

				
			} else {

				Console.WriteLine ("Not enough time!{0} hours needed.",hours - Math.Floor (result));
			}

		}
	}
}
