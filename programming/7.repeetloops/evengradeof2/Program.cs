using System;

namespace evengradeof2
{
	class MainClass
	{
		public static void Main ()
		{
			int n = int.Parse (Console.ReadLine());

			var result = 1;
			for (int i = 0; i <= n; i+=2) {
				Console.WriteLine (result);
				result += 4;
			}
		}
	}
}
