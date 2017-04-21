using System;

namespace taskone
{
	class MainClass
	{
		public static void Main ()
		{
			int days = int.Parse ( Console.ReadLine ());
			int money = decimal.Parse ( Console.ReadLine ());
			int course = decimal.Parse ( Console.ReadLine ());

			decimal result = days * money;
			result = 12 * result * 2.5M; //M decimal;
			result = 0.75M*result;
			result = result * course;
			result = result / 365;
			Console.WriteLine ("{0:F2}",result);  // ili {0:00};
		}
	}
}