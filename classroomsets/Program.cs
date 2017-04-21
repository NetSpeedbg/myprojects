using System;

namespace classroomsits
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var w = double.Parse (Console.ReadLine ());
			var h = double.Parse (Console.ReadLine ());
			var sumh = h - 1.00;
			var suma = Math.Floor (w / 1.20);
			var sumb = Math.Floor (sumh / 0.70);
			var result = (suma * sumb)-3 ;
			Console.WriteLine (result);
		}
	}
}