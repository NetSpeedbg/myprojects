using System;

namespace NumbersNto1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int	a = int.Parse (Console.ReadLine());
			int b = a;

			do {
				Console.WriteLine (b);
				b -= 1;
				switch (b) {
				case 0:
				break;
				}
			} 

			while (b>=1);
		}
	}
}