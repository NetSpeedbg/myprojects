using System;

namespace twoagain
{
	class MainClass
	{

		//90
		//7
		//3
		public static void Main ()
		{
			double hours = double.Parse (Console.ReadLine());
			double days = double.Parse (Console.ReadLine ());
			double imploysoutwork = double.Parse (Console.ReadLine ());

			double ejecate = days * 0.10;


			double hoursminejecate = days - ejecate;
			double hoursworkperdaynormal = hoursminejecate * 8;
			double outworkemplayshours = imploysoutwork * 2 * days;
			double allhours = hoursworkperdaynormal + outworkemplayshours;
			//Console.WriteLine (allhours);
			allhours = Math.Floor(allhours);

			//Console.WriteLine (ejecate);
			//Console.WriteLine (hoursminejecate);
			//Console.WriteLine (hoursworkperdaynormal);
			//Console.WriteLine (outworkemplayshours);
			//Console.WriteLine (allhours);


			if (allhours>=hours) {

				allhours = allhours - hours;
				Console.WriteLine ("Yes!{0} hours left.",allhours);
			} else {

				hours = hours - allhours;
				Console.WriteLine ("Not enough time!{0} hours needed.",hours);
			}
		}
	}
}