using System;

namespace taskthree
{
	class MainClass
	{
		public static void Main ()
		{
			int	month = Console.ReadLine ();
			int day = Console.ReadLine ();
			int priceAp = 0.00;
			int priceSt = 0.00; //0.00 double


			if (month == "may" || month == "octomber") {

				priceSt = day * 50.00;
				priceAp = day * 65;

				if (day > 7 && day <=14 ) {

					priceSt = priceSt * 0.95;
				} else if (day>14) {

					priceSt *= 0.7;
					priceAp *= 0.9;
				} 
				
			} 
			else if (month == "june" || month == "september") {

				priceSt = day * 75.20;
				priceAp = day * 60.70;

				if (day >14 ) {

					priceSt = priceSt * 0.95;
				} else if (day>14) {

					priceSt *= 0.7;
					priceAp *= 0.9;
				} 

				
			} else {
				priceSt = day * 76.00;
				priceAp = day * 77.00;

				if (day > 7 && day <=14 ) {

					priceSt = priceSt * 0.95;
				} else if (day>14) {

					priceSt *= 0.7;
					priceAp *= 0.9;
				} 

			} 
			Console.WriteLine ("Apartment:{0:F2}", priceAp);
			Console.WriteLine ("Studio:{0:F2}", priceSt);

		}
	}
}
