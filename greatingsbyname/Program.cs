using System;

namespace greatingsbyname
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.Write ("Въведете името на човека, който желаете да поздравите: ");
			var personname = Console.ReadLine ();
			Console.WriteLine ($"Здравей: {personname}!");
		}
	}
}
