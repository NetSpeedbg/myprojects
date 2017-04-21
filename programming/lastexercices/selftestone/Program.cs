using System;

namespace selftestone
{
	class MainClass
	{
		static int Pow (int x, int y)
		{

			int result = 1;
			for (int i = 0; i < y; i++) {

				result *= x;

			}
			return result;
		}

		public static void Main (string[] args)
		{

			Console.WriteLine (Pow(3,4));
		}
	}
}
