using System;

namespace finalexam4lections
{
	class MainClass
	{
		public static void Main ()
		{
			double houmuchlections = double.Parse (Console.ReadLine());
			double bujet = double.Parse (Console.ReadLine());
			//lektori broi lekcii
			double Jelev = 0;
			double RoYaL = 0;
			double Roli = 0;
			double Trofon = 0;
			double Sino = 0;
			double others = 0;

			//bujetlektori

			//double bujetlectors = bujet / houmuchlections;

			//parilektori

			//double Jelevsalary = 0;
			//double RoYaLsalary = 0;
			//double Rolisalary = 0;
			//double Trofonsalary = 0;
			//double Sinosalary = 0;
			//double Otherssalary = 0;


			for (int i = 0; i < houmuchlections; i++){
				string lectorname = Console.ReadLine ();
				if (lectorname == "Jelev") {
					Jelev++;
					continue;
					//Jelevsalary += bujetlectors;
				}
				else if (lectorname == "RoYaL") {
					RoYaL++;
					continue;
					//RoYaLsalary += bujetlectors;
				}
				else if (lectorname == "Roli") {
					Roli++;
					continue;
					//Rolisalary += bujetlectors;
				}
				else if (lectorname == "Trofon") {
					Trofon++;
					continue;
					//Trofonsalary += bujetlectors;
				} else if (lectorname == "Sino") {
					Sino++;
					continue;
					//Sinosalary += bujetlectors;
				} //else {
					//others++;
					//Otherssalary += bujetlectors;
				}
			Console.WriteLine ("Jelev salary: {0:F2} lv",Jelev*bujet/houmuchlections);
			Console.WriteLine ("RoYaL salary: {0:F2} lv",RoYaL*bujet/houmuchlections);
			Console.WriteLine ("Roli salary: {0:F2} lv",Roli*bujet/houmuchlections);
			Console.WriteLine ("Trofon salary: {0:F2} lv",Trofon*bujet/houmuchlections);
			Console.WriteLine ("Sino salary: {0:F2} lv",Sino*bujet/houmuchlections);
			Console.WriteLine ("Others salary: {0:F2} lv",(houmuchlections - Jelev - RoYaL - Roli - Trofon - Sino)*bujet/houmuchlections);
		}
	}
}