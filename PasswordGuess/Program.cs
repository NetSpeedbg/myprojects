using System;

namespace PasswordGuess
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var trythepassword = Console.ReadLine ();

			if (trythepassword == "s3cr3t!P@ssw0rd") {

				Console.WriteLine ("Welcome");
			}
				else {
					Console.WriteLine ("Wrong password!");
			}
		}
	}
}