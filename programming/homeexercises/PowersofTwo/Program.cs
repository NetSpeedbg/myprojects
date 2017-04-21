using System;

namespace PowersofTwo
{
	class MainClass
	{
		public static void Main()
		{
			int a = int.Parse(Console.ReadLine());
			int b = 1;
			int d = 2;
			int f = 0;

			Console.WriteLine (b);

				if (a == 1) {
					Console.WriteLine (d);
							}
						else if (a == 0) {
							}
							else {
				
							do {

					Console.WriteLine (d);
					d += d;
					f += 1;

				} while (a > f);
			}
		}
	}
}