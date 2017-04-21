using System;

namespace selftest
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string age = Console.ReadLine ();
			int x = Convert.ToInt32	(age);
			string msg;
			msg = (x >= 18) ? "wellcome" : "Sorry";
			Console.WriteLine (msg);
		}
	}
}
