using System;

namespace EvenPowersof2
{
	class MainClass
	{
		public static void Main ()
		{

			int	a = int.Parse (Console.ReadLine ());
			int b = 1;
			int c = 4;
			int	d = a % 2;
			int f = a - d;


			Console.WriteLine (b);
				for (int i = 1; i < f; i+=2) {

					Console.WriteLine (c);
					c *= 4;

				}

			}
		}
	}
