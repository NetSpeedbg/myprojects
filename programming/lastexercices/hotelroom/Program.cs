using System;

namespace hotelroom
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string monts = Console.ReadLine ();
			string strdays = Console.ReadLine ();
			double dates = Convert.ToDouble (strdays);

			double studiomayandoctomber = 50;
			double apartmentmayandoctomber = 65;

			double studiojunyandseptember = 75.20;
			double apartmentjunyandseptember = 68.70;

			double studiojuluandaugust = 76;
			double apartmentjuluandaugust = 77;

			double totalprice = 0;



			if (monts == "may" || monts == "october" && dates < 7) {

				double discount = apartmentmayandoctomber * 0.30;
				apartmentmayandoctomber = apartmentmayandoctomber * 0.05 * dates;
				studiomayandoctomber = studiomayandoctomber * 0.05 * dates;

				Console.WriteLine (apartmentmayandoctomber);
				Console.WriteLine (studiomayandoctomber);
				Console.WriteLine (discount);
				

			}

			else if (monts == "may" || monts == "october" && dates < 14) {

				double discount = apartmentmayandoctomber * 0.30;

				apartmentmayandoctomber = apartmentmayandoctomber * 0.30 * dates;
				studiomayandoctomber = studiomayandoctomber * 0.30	* dates;

				//Console.WriteLine (apartmentmayandoctomber);
				//Console.WriteLine (studiomayandoctomber);
				Console.WriteLine (discount);

			}


		}
	}
}
