using System;

namespace smallshop
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var product = Console.ReadLine().Trim().ToLower();
			var town = Console.ReadLine().Trim().ToLower();
			var quantity = double.Parse(Console.ReadLine ());

			var coffeesofia = 0.50;
			var watersofia = 0.80;
			var beersofia = 1.20;
			var sweetssofia = 1.45;
			var peanutssofia = 1.60;

			var cofeeplovdiv = 0.40;
			var waterplovdiv = 0.70;
			var beerplovdiv = 1.15;
			var sweetsplovdiv = 1.30;
			var peanutsplovdiv = 1.50;

			var coffeevarna = 0.45;
			var watervarna = 0.70;
			var beervarna = 1.10;
			var sweetvarna = 1.35;
			var peanutsvarna = 1.55;

			if (town == "Sofia") {
				if (product == "coffee") {
					Console.WriteLine (coffeesofia*quantity);
				} else if (product == "water") {
					Console.WriteLine (watersofia*quantity);
				} else if (product == "beer") {
					Console.WriteLine (beersofia*quantity);
					
				} else if (product == "sweets") {
					Console.WriteLine (sweetssofia*quantity);
				} else if (product == "peanuts") {
					Console.WriteLine (peanutssofia*quantity);
						
				} else {
					Console.WriteLine ("Подадени грешни данни");
				}
			
				if (town == "Plovdiv") {
					if (product == "coffee") {

						Console.WriteLine (cofeeplovdiv * quantity);
					} else if (product == "water") {
						Console.WriteLine (waterplovdiv * quantity);
					} else if (product == "beer") {
						Console.WriteLine (beerplovdiv * quantity);

					} else if (product == "sweets") {
						Console.WriteLine (sweetsplovdiv * quantity);
					} else if (product == "peanuts") {
						Console.WriteLine (peanutsplovdiv * quantity);

					} else {
						Console.WriteLine ("Подадени грешни данни");
					}
					if (town == "Varna") {
						if (product == "coffee") {
							Console.WriteLine (coffeevarna * quantity);
						} else if (product == "water") {
							Console.WriteLine (watervarna * quantity);
						} else if (product == "beer") {
							Console.WriteLine (beervarna * quantity);

						} else if (product == "sweets") {
							Console.WriteLine (sweetvarna * quantity);
						} else if (product == "peanuts") {
							Console.WriteLine (peanutsvarna * quantity) ;

						} else {
							Console.WriteLine ("Подадени грешни данни");
						}

					}
				}
			}
		}
	}
}