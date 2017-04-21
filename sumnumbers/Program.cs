using System;

namespace sumnumbers
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			double sum = 0.0;
			for (int i = 0; i < n; i++) {
				var number = double.Parse(Console.ReadLine());
				sum += number; }
			Console.WriteLine (sum);
		}
	}
}