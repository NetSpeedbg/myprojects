using System;

namespace pesho
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			double water = 100;
			double bucket = double.Parse ( Console.ReadLine ());
			while (water>0) {

				water = water - bucket;
				System.Console.WriteLine (water);

			}
		}
	}
}
