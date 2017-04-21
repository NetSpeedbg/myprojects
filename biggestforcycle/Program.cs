using System;

namespace sumnumbers
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var n = int.Parse(Console.ReadLine ());
			double s = Int32.MinValue;
			for (int i = 0; i < n; i++) {
				var number = int.Parse(Console.ReadLine ());
				if (s < number ) {
					s = number;
				}
			}
			Console.WriteLine (s);
		}
	}
}