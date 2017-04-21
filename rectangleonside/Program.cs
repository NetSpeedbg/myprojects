using System;

namespace rectangleonside
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var	x1 = 2;
			var y1 = -3;
			var x2 = 12;
			var y2 = 3;

			var pointX = double.Parse(Console.ReadLine ());
			var pointY = double.Parse(Console.ReadLine ());

			if (pointX == x1 && (pointY >= y1 && pointY <= y2) || 
				pointX == x1 && (pointY >= y1 || pointY <= y2) ||
				pointY == y1 && (pointY >= x1 || pointY <= x2) ||
				pointX == y1 && (pointY >= x1 || pointY <= x2)){

				Console.WriteLine ("On border");
			}
		}
	}
}