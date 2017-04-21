using System;

namespace sumingshar
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var text = Console.ReadLine().ToLower();
			var sum = 0;
			for (int i = 1; i < text.Length; i++) {

				var symbol = text [i];
				switch (symbol)
				{
				case 'a': { sum +=1;}break;
				case 'e': { sum +=2;}break;
				case 'i': { sum +=3;}break;
				case 'o': { sum +=4;}break;
				case 'u': { sum +=5;}break;
				default:
					break;
				}
			}
			Console.WriteLine (sum);
		}
	}
}