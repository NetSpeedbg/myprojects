using System;

namespace p05BradvaV2
{
	public class p05BradvaV2
	{
		public static void Main()
		{
			int num = int.Parse(Console.ReadLine());
			int num2 = num / 2;

			for (int i = 0; i < num; i++)
			{
				Console.WriteLine("{0}*{1}*{2}", 
					new string('-', 3 * num),
					new string('-', i),
					new string('-', (2 * num - 2 - i)));
			}

			for (int i = 0; i < num2; i++)
			{
				Console.WriteLine("{0}*{1}*{2}", 
					new string('*', 3 * num),
					new string('-', num - 1),
					new string('-', (num - 1)));
			}

			for (int i = 0; i < num2; i++)
			{
				if (i != (num2 - 1))
				{
					Console.WriteLine("{0}*{1}*{2}", 
						new string('-', 3 * num - i),
						new string('-', num - 1 + 2 * i),
						new string('-', (num - 1 - i)));
				}
				else
				{
					Console.WriteLine("{0}*{1}*{2}", 
						new string('-', 3 * num - i),
						new string('*', num - 1 + 2 * i),
						new string('-', (num - 1 - i)));

				}
			}
		}
	}
}