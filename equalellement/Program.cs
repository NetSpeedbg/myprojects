using System;

namespace equalellement
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var n = int.Parse (Console.ReadLine ());
			var sum = 0;
			var maxNumber = Int32.MaxValue;
			for (int i = 0; i < n; i++) {
				var number = int.Parse ( Console.ReadLine ());
				sum += number;
				if (maxNumber < number) {
					maxNumber = number;
				}
			}
			if ((sum - maxNumber) == maxNumber) {
				Console.WriteLine ("Yes");
				Console.WriteLine ("Sum = {0}",(sum-maxNumber));
			} else {
				var result = Math.Abs (sum - 2 * maxNumber); {
					Console.WriteLine ("No");
					Console.WriteLine ("Diff = {0}",result);
				}
			}
		}
	}
}