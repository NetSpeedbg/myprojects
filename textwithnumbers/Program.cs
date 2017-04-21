using System;

namespace textwithnumbers
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.Write ("Въведете името на човека: ");
			var firstname = Console.ReadLine ();
			Console.Write ("Въведете фамилията на човека: ");
			var lastname = Console.ReadLine ();
			Console.Write ("Въведете годините на човека: ");
			var age = int.Parse( Console.ReadLine ());
			Console.WriteLine ($"Той се казва {firstname} {lastname} и е на {age} години.");
		}
	}
}
