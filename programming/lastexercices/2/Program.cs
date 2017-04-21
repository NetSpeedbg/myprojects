using System;

namespace Application
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int toBuy = int.Parse ( Console.ReadLine ());
			var count = 0;


			while (!(count == toBuy)) {

				var product = Console.ReadLine ();
				if (product != "chocolate") {

					continue;

					//vrashta v nachaloto na cikala
				}
				count++;
			}
		}
	}
}
