using System;

namespace test1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var one = int.Parse ( Console.ReadLine ());
			for (int i = 1; i <= one; i++) {
				if (i == 1) {
				}
				else {
					Console.WriteLine ("* ");
				}
				for (int b = 2; b <= one; b++) {
					Console.Write ("* ");		
				}
			}
			Console.Write ("* ");
		}
	}				
}