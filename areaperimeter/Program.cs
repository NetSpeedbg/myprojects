using System;

namespace areaperimeter
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			
			var input = double.Parse(Console.ReadLine ());
			double area = Math.PI * input * input;
			double perimeter = 2 * Math.PI * input;
			Console.WriteLine ("Обиколката е:" + area);
			Console.WriteLine ("Лицето е: " + perimeter);
		}
	}
}