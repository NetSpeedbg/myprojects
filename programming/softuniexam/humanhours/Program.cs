using System;

namespace humanhours
{
	class MainClass
	{
		public static void Main ()
		{
			double neededhours = double.Parse (Console.ReadLine ());
			double neededworkers = double.Parse (Console.ReadLine ());
			double workingdays = double.Parse (Console.ReadLine ());

			double calcone = (neededworkers * workingdays) * 8;

			if (calcone >= neededhours) {

				Console.WriteLine (calcone + " hours left");

			}
				else {
					
				neededhours -= calcone;
				Console.WriteLine ( neededhours + " overtime");
				neededhours *= workingdays;
				Console.WriteLine ( "Penalties: " + neededhours);
			}
		}
	}
}