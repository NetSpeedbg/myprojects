using System;

namespace secondstominutes
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var a = int.Parse (Console.ReadLine ());
			var b = int.Parse (Console.ReadLine ());
			var c = int.Parse (Console.ReadLine ());

			var suminseconds = a + b + c;
			int seconds = suminseconds % 60;
			int minutes = suminseconds / 60;


			 if (seconds < 10) {

				Console.WriteLine ("{0}:0{1}",minutes,seconds);


				
			} else {

				Console.WriteLine ("{0}:{1}",minutes,seconds);
				
			 }
			//Console.WriteLine ($"{minutes} {seconds} {suminseconds}");
		}
	}
}