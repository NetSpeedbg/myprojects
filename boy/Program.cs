using System;

namespace boy
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var	age = double.Parse (Console.ReadLine ());
			var gender = Console.ReadLine ();
			if (age < 16) {
				if (gender == "m") {
					Console.WriteLine ("Master");
				} else {
					Console.WriteLine ("Miss");
				}
			} else if (age >= 16) {
				if (gender == "m") {
					Console.WriteLine ("Mr.");
				} else {
					Console.WriteLine ("Ms.");
				}
			} 
		}
	}
}