using System;

namespace OddEvenSum
{
	class OddEvenSum
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int evenSum = 0;
			int oddSum = 0;

			for (int i = 0; i < n; i++)
			{
				int numbers = int.Parse(Console.ReadLine());
				if (i % 2 == 0)
				{
					evenSum += numbers;
				}
				else if (i % 2 != 0)
				{
					oddSum += numbers;
				}
			}
			int diff = Math.Abs(evenSum - oddSum);
			if (evenSum==oddSum)
			{
				Console.WriteLine("Yes Sum = " + evenSum);
			}
			else if (evenSum!=oddSum)
			{
				Console.WriteLine("No Diff = " + diff);
			}
		}
	}
}