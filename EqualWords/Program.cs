using System;

namespace EqualWords
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string word = Console.ReadLine ();
			string word2 = Console.ReadLine ();

			word = word.ToLower ();
			word2 = word2.ToLower ();

			if (word.Equals(word2)) {
				Console.WriteLine ("yes");
			} 

			else {
				Console.WriteLine ("no");
			}
		}
	}
}