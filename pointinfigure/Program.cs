using System;

namespace pointinfigure
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var	x1 = int.Parse(Console.ReadLine ());
			var x2 = int.Parse(Console.ReadLine ());
			var	y1 = int.Parse(Console.ReadLine ());
			var	y2 = int.Parse(Console.ReadLine ());
			var pointX = int.Parse(Console.ReadLine ());
			var	pointY = int.Parse(Console.ReadLine ());

			if (pointX >= x1 && pointX <= x2 && pointY >= y1 && pointY <= y2) {
				Console.WriteLine ("Inside");			
			} else {
				Console.WriteLine ("Outside");
			}
		}
	}
}