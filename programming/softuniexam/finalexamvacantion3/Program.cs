using System;

namespace finalexamvacantion3
{
	class MainClass
	{
		public static void Main ()
		{
			double bujet  = double.Parse ( Console.ReadLine ());
			string season = Console.ReadLine ();
			string nastaniavane = "testone";
			string miasto = "testtwo";

			if (bujet <=1000) {
				nastaniavane = "Camp";

				if (season == "Summer") {

					miasto = "Alaska";
					bujet *= 0.65;
				} else {
					miasto = "Morocco";
					bujet *= 0.45;
				}


		}
			else if (bujet>1000 && bujet <= 3000) {
				nastaniavane = "Hut";

				if (season == "Summer") {

					miasto = "Alaska";
					bujet *= 0.80;
				} else {
					miasto = "Morocco";
					bujet *= 0.60;
				}


			}
			else {
				nastaniavane = "Hotel";

				if (season == "Summer") {

					miasto = "Alaska";
					bujet *= 0.90;
				} else {
					miasto = "Morocco";
					bujet *= 0.90;
				}
			}
			Console.Write (miasto + " - ");
			Console.Write (nastaniavane + " - ");
			Console.Write ("{0:F2}",bujet);
		}
	}
}