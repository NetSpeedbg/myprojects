using System;

namespace Sequence2k1
{
	class MainClass
	{
		public static void Main()
		{
			int n = int.Parse (Console.ReadLine ());
			int b = 1;

			Console.WriteLine (b);

				for (int i = 1; i <= n; i++) {

					b = b * 2 + 1;
				if (n<b) {
					break;
				}

				Console.WriteLine (b);
			}
		}
	}
}