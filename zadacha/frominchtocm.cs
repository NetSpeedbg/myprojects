using System;

namespace zadacha
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.Write ("a = ");
			var a = double.Parse (Console.ReadLine ());
			var areaA = (a*a);
			Console.WriteLine ("Square = ");
			Console.WriteLine (areaA);
	}
}
}
