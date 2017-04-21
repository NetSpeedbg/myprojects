using System;

namespace Rectangleof10x10Stars
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			for (int i = 1; i <= 10; i++) {
				Console.WriteLine (new String('*',10));
			}
		}
	}
}