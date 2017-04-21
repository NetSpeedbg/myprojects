using System;

namespace finalexamchashi2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			double broichashizaizrabotka = double.Parse (Console.ReadLine ());
			double broirabotnici = double.Parse (Console.ReadLine());
			double rabotnidni = double.Parse (Console.ReadLine());

			double a = broirabotnici * rabotnidni * 8;
			double b = a / 5;
			double c = Math.Floor (b);

			if (broichashizaizrabotka>c) {

				broichashizaizrabotka -= c;
				broichashizaizrabotka *= 4.20;
				Console.WriteLine ("Losses: {0:F2}",broichashizaizrabotka);
			} else {

				c -= broichashizaizrabotka;
				c *= 4.20;

				Console.Write ("{0:F2} extra money",c);
			}
		}
	}
}