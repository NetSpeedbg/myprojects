using System;

namespace digitssum
{
	class MainClass
	{
		public static void Main ()
		{
			var number = Console.ReadLine ();
			var result = 0;
			for (int i = 0; i < number.Length; i++) {

				result += int.Parse (number[i].ToString());

			}
			Console.WriteLine (result);
		}
	}
}
