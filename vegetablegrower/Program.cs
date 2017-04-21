using System;

namespace vegetablegrower
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var n = double.Parse (Console.ReadLine ());
			var m = double.Parse (Console.ReadLine ());
			var howmuchvegetables = int.Parse (Console.ReadLine ());
			var howmuchfriuts = int.Parse (Console.ReadLine ());
			var euro = 1.94;

			var firstresult = n * howmuchvegetables;
			var secondresults = m * howmuchfriuts;
			var thirdresult = firstresult + secondresults;
			var forthresult = (thirdresult / euro);

			Console.WriteLine (forthresult);

		}
	}
}