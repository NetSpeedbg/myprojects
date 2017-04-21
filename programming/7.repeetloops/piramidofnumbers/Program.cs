using System;

namespace piramidofnumbers
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var	number = int.Parse ( Console.ReadLine ());

			//1
			//2 3
			//4 5 6
			//7 8 9 10

			var i = 1;


			do {
				var row = 1;

				do {
					for (int col = 0; col < row; col++) {

						Console.WriteLine ("{0} ",i);
						if (i>=number) {
							break;
						}
						i++;
					}
					Console.WriteLine ();
					row++;
					
				} while (true);
				

				
			} while (i<=number);

			i++;
		}
	}
}