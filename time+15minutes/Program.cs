using System;

namespace time15minutes
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var hours = double.Parse (Console.ReadLine ());
			var minutes = double.Parse (Console.ReadLine ());
			var minutesoutput = 0M;
			var minutesround = Math.Round (minutesoutput, 2);

			if (minutes == 00) {
				minutesoutput += 15;
			}
			else if (minutes == 01) {
				minutesoutput += 16;
			}
			else if (minutes == 02) {
				minutesoutput += 17;
			}
			else if (minutes == 03) {
				minutesoutput += 18;
			}
			else if (minutes == 04) {
				minutesoutput += 19;
			}
			else if (minutes == 05) {
				minutesoutput += 20;
			}
			else if (minutes == 06) {
				minutesoutput += 21;
			}
			else if (minutes == 07) {
				minutesoutput += 22;
			}
			else if (minutes == 08) {
				minutesoutput += 23;
			}
			else if (minutes == 09) {
				minutesoutput += 24;
			}
			else if (minutes == 10) {
				minutesoutput += 25;
			}
			else if (minutes == 11) {
				minutesoutput += 26;
			}
			else if (minutes == 12) {
				minutesoutput += 27;
			}
			else if (minutes == 13) {
				minutesoutput += 28;
			}
			else if (minutes == 14) {
				minutesoutput += 29;
			}
			else if (minutes == 15) {
				minutesoutput += 30;
			}
			else if (minutes == 16) {
				minutesoutput += 31;
			}
			else if (minutes == 17) {
				minutesoutput += 32;
			}
			else if (minutes == 18) {
				minutesoutput += 33;
			}
			else if (minutes == 19) {
				minutesoutput += 34;
			}
			else if (minutes == 20) {
				minutesoutput += 35;
			}
			else if (minutes == 21) {
				minutesoutput += 36;
			}
			else if (minutes == 22) {
				minutesoutput += 37;
			}
			else if (minutes == 23) {
				minutesoutput += 38;
			}
			else if (minutes == 24) {
				minutesoutput += 39;
			}
			else if (minutes == 25) {
				minutesoutput += 40;
			}
			else if (minutes == 26) {
				minutesoutput += 41;
			}
			else if (minutes == 27) {
				minutesoutput += 42;
			}
			else if (minutes == 28) {
				minutesoutput += 43;
			}
			else if (minutes == 29) {
				minutesoutput += 44;
			}
			else if (minutes == 30) {
				minutesoutput += 45;
			}
			else if (minutes == 31) {
//				minutesoutput += 46;
			}
			else if (minutes == 32) {
				minutesoutput += 47;
			}
			else if (minutes == 33) {
				minutesoutput += 48;
			}
			else if (minutes == 34) {
				minutesoutput += 49;
			}
			else if (minutes == 35) {
				minutesoutput += 50;
			}
			else if (minutes == 36) {
				minutesoutput += 51;
			}
			else if (minutes == 37) {
				minutesoutput += 52;
			}
			else if (minutes == 38) {
				minutesoutput += 53;
			}
			else if (minutes == 39) {
				minutesoutput += 54;
			}
			else if (minutes == 40) {
				minutesoutput += 55;
			}
			else if (minutes == 41) {
				minutesoutput += 56;
			}
			else if (minutes == 42) {
				minutesoutput += 57;
			}
			else if (minutes == 43) {
				minutesoutput += 58;
			}
			else if (minutes == 44) {
				minutesoutput += 59;
			}
			else if (minutes == 45) {
				hours += 1;
			}
			else if (minutes == 46) {
				hours += 1;
				minutesoutput += 01;
			}
			else if (minutes == 47) {
				hours += 1;
				minutesoutput += 02;
			}
			else if (minutes == 48) {
				hours += 1;
				minutesoutput += 03;
			}
			else if (minutes == 49) {
				hours += 1;
				minutesoutput += 04;
			}
			else if (minutes == 50) {
				hours += 1;
				minutesoutput += 05;
			}
			else if (minutes == 51) {
				hours += 1;
				minutesoutput += 06;
			}
			else if (minutes == 52) {
				hours += 1;
				minutesoutput += 07;
			}
			else if (minutes == 53) {
				hours += 1;
				minutesoutput += 08;
			}
			else if (minutes == 54) {
				hours += 1;
				minutesoutput += 09;
			}
			else if (minutes == 55) {
				hours += 1;
				minutesoutput += 10;
			}
			else if (minutes == 56) {
				hours += 1;
				minutesoutput += 11;
			}
			else if (minutes == 57) {
				hours += 1;
				minutesoutput += 12;
			}
			else if (minutes == 58) {
				hours += 1;
				minutesoutput += 13;
			}
			else if (minutes == 59) {
				hours += 1;
				minutesoutput += 14;
			}
			Console.WriteLine ($"{hours}:{minutesround}");
		}
	}
}