using System;

namespace frominchtocm
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Въведе стойността в инчове: ");
			var inch = double.Parse(Console.ReadLine ());
			var result =(inch*2.54);
			Console.WriteLine ($"В сантиметри резултатът е: {result}");
		}
	}
}
