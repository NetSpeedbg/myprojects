using System;

namespace NOD
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var	a = int.Parse ( Console.ReadLine ());
			var b = int.Parse ( Console.ReadLine ());
			var result = 0;
			if (b == 0) {
				result = a;
				
			}
			while (a != b) {
				if (a>b) {
					a =a / (a - b);

				} else {

					while (a != b) {
						if (a>b) {

							a = a - b;
						} else {
							b = b - a;
						}
					}
					result = a;
					}
				Console.WriteLine ("{0},{1}",a,b);
			}
		}
	}
}
