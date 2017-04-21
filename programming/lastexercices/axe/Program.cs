using System;

namespace axe
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int num = int.Parse (Console.ReadLine());
			int num2 = num / 2;

			for (int i = 0; i < num; i++) {

				Console.WriteLine ("{0}*{1}*{2}",
					new string ('-',3 * num),
					new string ('-', i),
					new string ('-', (2 * num - 2 - i)));
				
			}

			for (int b = 0; b < num2; b++) {
				Console.WriteLine ("{0}*{1}*{2}",
					new string ('*',3 * num),
					new string ('-',num - 1),
					new string ('-', (num - 1)));
				
			}

			for (int c = 0; c < num	; c++) {

				if (c != num-1) {

					Console.WriteLine ("{0}*{1}*{2}",
						new string ('*',3 * num - c),
						new string ('-',num - 1 + 2 * c),
						new string ('-', (num - 1)));
					
				}


			}
		}
	}
}