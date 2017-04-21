using System;

namespace leftandrightsum
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var n = int.Parse ( Console.ReadLine ());
			var sumleft = 0;
			var sumright = 0;

			for (int i = 0; i < n; i++) {
				var number = int.Parse ( Console.ReadLine ());
				sumleft += number;	}
			for (int i = 0; i < n; i++) {
				var number = int.Parse ( Console.ReadLine ());
				sumright += number; }
			if (sumleft == sumright) {
				Console.WriteLine ("Yes, sum = {0}",sumleft);
			} else {
				var result = Math.Abs (sumleft - sumright);
				Console.WriteLine ("No, diff = {0}",result);
			}
		}
	}
}