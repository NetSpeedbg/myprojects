using System;

namespace repeetloops
{
	class MainClass
	{
		public static void Main ()
		{
			int varnumber = int.Parse( Console.ReadLine ());

			for (int row = 0; row < varnumber; row++) {

				for (int col = 1; col <= varnumber; col++) {

					Console.WriteLine ("{0:00} ", col + varnumber * row);
				}

				Console.WriteLine ();
			}
		}
	}
}
