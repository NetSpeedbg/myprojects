﻿using System;

namespace biggernumber
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Enter two integers:");
			var num1 = int.Parse ( Console.ReadLine ());
			var num2 = int.Parse ( Console.ReadLine ());

			if (num1 < num2) {
				Console.WriteLine ($"Greater number: {num2}");
			}
			else {
				Console.WriteLine ($"Greater number: {num1}");
				
			}
		}
	}
}