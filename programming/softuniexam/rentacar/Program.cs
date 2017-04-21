using System;

namespace rentacar
{
	class MainClass
	{
		public static void Main ()
		{
			double bujet = double.Parse (Console.ReadLine());
			string season = Console.ReadLine();
			var carclass = "standard class";
			var carmodel = "base";

		
			if (bujet > 500) {

				carclass = "Luxury class";


				if (season == "Summer") {

					carmodel = "Jeep";
					bujet *= 0.90;


				}
				if (season == "Winter") {
					carmodel = "Jeep";
					bujet *= 0.90;
				}

			}

		
			else if (bujet > 100 || bujet <= 500) {

				carclass = "Compact class";

				if (season == "Summer") {

					carmodel = "Cabrio";
					bujet *= 0.45;


				}
				if (season == "Winter") {
					carmodel = "Jeep";
					bujet *= 0.80;
				}
			}

		else if (bujet <= 100) {
				carclass = "Economy class";

				if (season == "Summer") {

					carmodel = "Cabrio";
					bujet *= 0.35;

				}
				if (season == "Winter") {

					carmodel = "Jeep";
					bujet *= 0.65;
				}
			}
				
			Console.WriteLine (carclass);
			Console.WriteLine (carmodel);
			Console.WriteLine ("{0:F2}",bujet);
		}
	}
}