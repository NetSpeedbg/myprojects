using System;

namespace fruitorvegitable
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var	something = Console.ReadLine ().ToLower;

			if (something == "banana" || something == "apple" || something == "kiwi" || something == "cherry" || something == "lemon" || something == "grapes") {
				Console.WriteLine ("fruit");

				else if (something == "tomato" ||something == "cucumber" ||something == "pepper" ||something == "carrot") {
					
					Console.WriteLine ("vegetble");

			}
		}
	}
}
