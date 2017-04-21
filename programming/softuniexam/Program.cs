using System;

namespace doghousepain
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			double sidea = double.Parse (Console.ReadLine());
			double sideb = double.Parse (Console.ReadLine());

			double roofone = sidea * (sidea / 2) * 2;
			double square = (sidea/2)*(sidea / 2);
			double triangle = (sidea / 2 * (sideb - sidea / 2)) / 2;
			double input = (sidea / 5) * (sidea / 5);
			double rearwall = square + triangle;
			double frontwall = rearwall - input;
			double totalarea = roofone + rearwall + frontwall;

			double greenpaint = totalarea / 3;
			double roof = sidea * (sidea / 2) * 2;
			double redpaint = roof / 5;

			//Console.WriteLine (square); //y
			//Console.WriteLine (triangle); //y
			//Console.WriteLine (input); //y
			//Console.WriteLine (rearwall); //y
			//Console.WriteLine (frontwall); //y
			//Console.WriteLine (totalarea);
			Console.WriteLine ("{0:F2}",greenpaint);
			//Console.WriteLine (roof); //y
			Console.WriteLine ("{0:F2}",redpaint);
		}
	}
}