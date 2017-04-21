using System;

namespace test1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var	one = int.Parse (Console.ReadLine);
			int two = 0;

			for (int i = 1; i <= one; i++) {
				Console.WriteLine ("$ ");
				if (i == 1 || i == one) {
					
				}
				else {
					two += 1;
				}

				for (int b = 2; b <= two; b++) {
					Console.Write ("$ ");
					
				}
					
				}
		}				
	}
}