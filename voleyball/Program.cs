using System;

namespace voleyball
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var	year = Console.ReadLine ();
			var p = int.Parse(Console.ReadLine ());
			var h = int.Parse(Console.ReadLine ());
			var weekends = 48;

			var gamesinsofia =(3*(weekends - h))/4.0;
			var holydays = 2 * p / 3.0;
			var allgames = gamesinsofia + h + holydays;

			if (year == "leap") {

				allgames = allgames*1.15;
			}
		
			Console.WriteLine (Math.Floor (allgames));
			Console.WriteLine (result);
		}
	}
} 