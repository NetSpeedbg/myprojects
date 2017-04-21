using System;

namespace Measuringunitscalculator
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var inputnumber = double.Parse (Console.ReadLine());
			var inputmesure = Console.ReadLine ();
			var outmesure = Console.ReadLine ();

			if (inputmesure == "m") {
				if (outmesure == "mm") {
					Console.WriteLine (inputnumber*1000 + " mm");	
				}
				else if (outmesure == "cm") {
					Console.WriteLine (inputnumber*100 + " cm");
				}	
				else if (outmesure == "mi") {
					Console.WriteLine (inputnumber/1609.344 + " mi" );
				}
				else if (outmesure == "in") {
					Console.WriteLine (inputnumber/0.0254 + " in");
				}
				else if (outmesure == "km") {
					Console.WriteLine (inputnumber/1000 + " km");
				}
				else if (outmesure == "ft") {
					Console.WriteLine (inputnumber/0.3048 + " ft");
				}
				else if (outmesure == "yd") {
					Console.WriteLine (inputnumber*1.093613 + " yd");
				}
				else if (outmesure == "m") {
					Console.WriteLine (inputnumber*1 + " m");
				}
			}
			if (inputmesure == "mm") {
				if (outmesure == "m") {
					Console.WriteLine (inputnumber/1000 + " m");	
				}
				else if (outmesure == "cm") {
					Console.WriteLine (inputnumber/10 + " cm");
				}	
				else if (outmesure == "mi") {
					Console.WriteLine (inputnumber/1609344 + " mi" );
				}
				else if (outmesure == "in") {
					Console.WriteLine (inputnumber/25.4 +" in");
				}
				else if (outmesure == "km") {
					Console.WriteLine (inputnumber/1000000 + " km");
				}
				else if (outmesure == "ft") {
					Console.WriteLine (inputnumber/304.8 + " ft");
				}
				else if (outmesure == "yd") {
					Console.WriteLine (inputnumber/914.4 + " yd");
				}
				else if (outmesure == "mm") {
					Console.WriteLine (inputnumber*1 + " mm");
				}
			}
			if (inputmesure == "cm") {
				if (outmesure == "m") {
					Console.WriteLine (inputnumber/100 + " m");	
				}
				else if (outmesure == "mm") {
					Console.WriteLine (inputnumber*10 + " mm");
				}	
				else if (outmesure == "mi") {
					Console.WriteLine (inputnumber/160934.4 + " mi" );
				}
				else if (outmesure == "in") {
					Console.WriteLine (inputnumber/2.54 +" in");
				}
				else if (outmesure == "km") {
					Console.WriteLine (inputnumber/100000 + " km");
				}
				else if (outmesure == "ft") {
					Console.WriteLine (inputnumber/30.48 + " ft");
				}
				else if (outmesure == "yd") {
					Console.WriteLine (inputnumber/91.44 + " yd");
				}
				else if (outmesure == "cm") {
					Console.WriteLine (inputnumber*1 + " cm");
				}
			}
			if (inputmesure == "mi") {
				if (outmesure == "m") {
					Console.WriteLine (inputnumber*1609.344 + " m");	
				}
				else if (outmesure == "cm") {
					Console.WriteLine (inputnumber*160934.4 + " cm");
				}	
				else if (outmesure == "mm") {
					Console.WriteLine (inputnumber* 1609344 + " mm" );
				}
				else if (outmesure == "in") {
					Console.WriteLine (inputnumber*63360 +" in");
				}
				else if (outmesure == "km") {
					Console.WriteLine (inputnumber*1.609344 + " km");
				}
				else if (outmesure == "ft") {
					Console.WriteLine (inputnumber*5280 + " ft");
				}
				else if (outmesure == "yd") {
					Console.WriteLine (inputnumber*1760 + " yd");
				}
				else if (outmesure == "mi") {
					Console.WriteLine (inputnumber*1 + " mi");
				}
			}
			if (inputmesure == "in") {
				if (outmesure == "m") {
					Console.WriteLine (inputnumber*0.0254 + " m");	
				}
				else if (outmesure == "cm") {
					Console.WriteLine (inputnumber*2.54 + " cm");
				}	
				else if (outmesure == "mi") {
					Console.WriteLine (inputnumber/63360 + " mi" );
				}
				else if (outmesure == "mm") {
					Console.WriteLine (inputnumber*25.4 +" mm");
				}
				else if (outmesure == "km") {
					Console.WriteLine (inputnumber*0.0000254 + " km");
				}
				else if (outmesure == "ft") {
					Console.WriteLine (inputnumber/12 + " ft");
				}
				else if (outmesure == "yd") {
					Console.WriteLine (inputnumber/36 + " yd");
				}
				else if (outmesure == "in") {
					Console.WriteLine (inputnumber*1 + " in");
				}
			}
			if (inputmesure == "km") {
				if (outmesure == "m") {
					Console.WriteLine (inputnumber*1000 + " m");	
				}
				else if (outmesure == "cm") {
					Console.WriteLine (inputnumber*100000 + " cm");
				}	
				else if (outmesure == "mi") {
					Console.WriteLine (inputnumber/1.609344 + " mi" );
				}
				else if (outmesure == "in") {
					Console.WriteLine (inputnumber/0.0000254 +" in");
				}
				else if (outmesure == "mm") {
					Console.WriteLine (inputnumber*1000000 + " mm");
				}
				else if (outmesure == "ft") {
					Console.WriteLine (inputnumber/0.0003048 + " ft");
				}
				else if (outmesure == "yd") {
					Console.WriteLine (inputnumber/0.0009144 + " yd");
				}
				else if (outmesure == "km") {
					Console.WriteLine (inputnumber*1 + " km");
				}
			}
			if (inputmesure == "ft") {
				if (outmesure == "m") {
					Console.WriteLine (inputnumber*0.3048 + " m");	
				}
				else if (outmesure == "cm") {
					Console.WriteLine (inputnumber*30.48 + " cm");
				}	
				else if (outmesure == "mi") {
					Console.WriteLine (inputnumber/5280 + " mi" );
				}
				else if (outmesure == "in") {
					Console.WriteLine (inputnumber*12 +" in");
				}
				else if (outmesure == "km") {
					Console.WriteLine (inputnumber*0.0003048 + " km");
				}
				else if (outmesure == "mm") {
					Console.WriteLine (inputnumber*304.8 + " mm");
				}
				else if (outmesure == "yd") {
					Console.WriteLine (inputnumber/3 + " yd");
				}
				else if (outmesure == "ft") {
					Console.WriteLine (inputnumber*1 + " ft");
				}
			}
			if (inputmesure == "yd") {
				if (outmesure == "m") {
					Console.WriteLine (inputnumber*0.9144 + " m");	
				}
				else if (outmesure == "cm") {
					Console.WriteLine (inputnumber*91.44 + " cm");
				}	
				else if (outmesure == "mi") {
					Console.WriteLine (inputnumber/1760 + " mi" );
				}
				else if (outmesure == "in") {
					Console.WriteLine (inputnumber*36 +" in");
				}
				else if (outmesure == "km") {
					Console.WriteLine (inputnumber*0.0009144 + " km");
				}
				else if (outmesure == "ft") {
					Console.WriteLine (inputnumber*3 + " ft");
				}
				else if (outmesure == "mm") {
					Console.WriteLine (inputnumber*914.4 + " mm");
				}
				else if (outmesure == "yd") {
					Console.WriteLine (inputnumber*1 + " yd");
				}
			}
		}
	}
}