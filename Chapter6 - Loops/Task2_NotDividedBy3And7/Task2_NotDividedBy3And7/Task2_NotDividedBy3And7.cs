using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_NotDividedBy3And7
{
	class Task2_NotDividedBy3And7
	{
		static void Main(string[] args)
		{
			//Task: Print the numbers 1 to N that are not divided by 3 and 7 simultaneously
			int n = int.Parse(Console.ReadLine());
			for (int i = 1; i < n; i++)
			{
				if (i % 21 != 0)
				{
					Console.WriteLine(i);
				}
			}
		}
	}
}
