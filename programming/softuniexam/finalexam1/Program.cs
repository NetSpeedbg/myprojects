using System;

namespace finalexam1
{
	class MainClass
	{
		public static void Main ()
		{
			double highhouse = double.Parse (Console.ReadLine());
			double widehouse = double.Parse (Console.ReadLine());
			double hightriangle = double.Parse (Console.ReadLine());
			double prozorets = 1.5;

			double stranichnastena = highhouse * widehouse;
			double prozoretsplosht = prozorets * prozorets;
			double stranitsi = 2 * stranichnastena - 2 * prozoretsplosht;
			double zadnasena = highhouse * highhouse;
			double vhod = 1.2 * 2;
			double obshtaprednaizadna = zadnasena * 2 - vhod;
			double obshtaplosht = stranitsi + obshtaprednaizadna;
			double zelenaboq = obshtaplosht / 3.4;

			// pokriv

			double dvatapravougalnikanapokriva = 2 * (highhouse * widehouse);
			double dvatatriugalnika = 2 * (highhouse * hightriangle / 2);
			double obshtaploshtfinal = dvatapravougalnikanapokriva + dvatatriugalnika;
			double chervenaboq = obshtaploshtfinal/4.3;


			//Console.WriteLine (dvatapravougalnikanapokriva);
			//Console.WriteLine (dvatatriugalnika);
			//Console.WriteLine (obshtaploshtfinal);

			Console.WriteLine ("{0:F2}",zelenaboq);
			Console.WriteLine ("{0:F2}",chervenaboq);
		}
	}
}