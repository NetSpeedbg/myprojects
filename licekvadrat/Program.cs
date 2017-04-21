using System;

namespace licekvadrat
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var firstname = Console.ReadLine ();
			var lastname = Console.ReadLine ();
			var age = int.Parse (Console.ReadLine ());

			Console.WriteLine ($"Вие въведохте: {firstname} е {lastname} i e na {age}");
		}
	}
}