using System;

namespace tasksix
{
	class MainClass
	{
		public static void Main ()
		{
			int number = int.Parse ( Console.ReadLine ());
			int a = number / 100; //firstdigit
			int b = number / 10 % 10; //middledigit
			int c = number % 10; //lastdigit
			int count = 0;
			int countrow = 0;
		

			for (int n = 0; n <= a+b; n++) { //colomn


				for (int m = 0; m <= a+b; ++m) {  //row

					if (countrow == a+b) {
						break;
					}

					if (count == a+c) {
						Console.WriteLine (' ');
						count = 0;
						countrow++;
						continue;
					}

					if (number % 5 == 0) {

						number -= a;
						Console.Write (number + " ");
						count++;
						continue;
					}
					else if (number % 3 == 0) {
						number -= b;
						Console.Write (number + " " );
						count++;
						continue;

					} else {
						number += c;
						Console.Write (number + " " );
						count++;
						continue;
					}

				}

			}
			//Console.WriteLine (a);
			//Console.WriteLine (b);
			//Console.WriteLine (c);
			//Console.WriteLine (a+b);
		}
	}
}