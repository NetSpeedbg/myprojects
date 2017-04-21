using System;

namespace bonuspoints
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var num = double.Parse (Console.ReadLine());
			var bonuscore = 0.0;
			if (num >= 1000) {
				bonuscore += (num * 0.1);  
			} 
			else if (num > 100) {

				bonuscore += (num * 0.2);
			}
			else if (num <= 100) { //bonusScore = bonusscore +5;

				bonuscore += 5;
			} 

			if (num%2 == 0) {

				bonuscore += 1;
			}

			if (num%10 == 5) {

				bonuscore += 2;
			}
			Console.WriteLine("Bonus score: {0}", bonuscore);

			Console.WriteLine("Total score: {0}", num + bonuscore);

			}
		}
	}