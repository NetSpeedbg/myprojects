using System;

namespace figurearea
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string one = Console.ReadLine ();
			string two = Console.ReadLine ();
			string three = Console.ReadLine ();

			if (one.Equals("square")) {
				Console.WriteLine (Convert.ToDouble(two)*Convert.ToDouble(two));
			}
			else if (one.Equals("rectangle")) {
				Console.WriteLine (Convert.ToDouble(two) * Convert.ToDouble(three));
			}
				
			else if (one.Equals("circle")) {
				Console.WriteLine ((Convert.ToDouble(two)*(Convert.ToDouble(two)))*Math.PI);	
		
			} 
			else if (one.Equals("triangle")) {
				Console.WriteLine ((Convert.ToDouble(two)*Convert.ToDouble(three))/2);	
			} 
		}
	}			
}