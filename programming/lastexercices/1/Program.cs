using System;

namespace Application
{
	class MainClass
	{
		public static void Main ()
		{
			
			var count = int.Parse ( Console.ReadLine ());

			for (int i = 0; i < count; i++) {

				var isfree = bool.Parse (Console.ReadLine ());
				if (isfree == "free") {

					break;
					
				}
		Console.WriteLine ("Go to  next");

		}
}
	}
}