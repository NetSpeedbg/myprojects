using System;

namespace taskfour
{
	class MainClass
	{
		public static void Main ()
		{
			int	days = int.Parse (Console.ReadLine());
			int doctors = 7;
			int patientsaccepted = 0;
			int patientsignorred = 0;
			int counter = 0;

		//	4
		//	7
		//	27
		//	9
		//	1

			for (int i = 0; i < days; i++) {
				counter++;
				if (counter == 3) {

					if (patientsaccepted < patientsignorred) {

						doctors++;
					}
					counter = 0;
				}

				int patients = int.Parse (Console.ReadLine());

			
				if (patients>=doctors) {
					patients -= doctors;
					patientsaccepted += doctors;
					patientsignorred += patients;
				}
				else if (patients<doctors) {
					patientsaccepted += patients;
					
				} 
			}
			Console.WriteLine ("Treated patients: " + patientsaccepted + ".");
			Console.WriteLine ("Untreated patients: " + patientsignorred + ".");
		}
	}
}