using System;

namespace Repairoftile
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var n = double.Parse (Console.ReadLine ());
			var w = double.Parse (Console.ReadLine ());
			var l = double.Parse (Console.ReadLine ());
			var m = double.Parse (Console.ReadLine ());
			var o = double.Parse (Console.ReadLine ());
			var time = 0.2;

			var nn = (n * n) - (m * o); //liceto na kvadrata - pejkata;
			var lm = l * w; // edinichen razmer na plochkata;
			var nnlm = nn/lm; // neobhodimi plocki;
			var nnlmox = nnlm * time; //vreme za izpylnenie na zadachata

			Console.WriteLine (nnlm);
			Console.WriteLine (nnlmox);
		}
	}
}