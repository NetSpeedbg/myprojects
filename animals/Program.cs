using System;

namespace animals
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var animals = Console.ReadLine ();

			switch (animals) {
			case "dog":
				Console.WriteLine ("DOG");
				break;
			case "crocodile":
				Console.WriteLine ("riptile");
				break;
			case "snake"
				Console.WriteLine ("shit");
				break;
			default:
				Console.WriteLine ("Нещо друго");
				break;
			}
		}
	}
}
