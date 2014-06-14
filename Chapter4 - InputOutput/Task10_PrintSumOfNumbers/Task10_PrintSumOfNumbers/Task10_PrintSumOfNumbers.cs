using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10_PrintSumOfNumbers
{
	class Task10_PrintSumOfNumbers
	{
		static void Main(string[] args)
		{
			//Task enter a number n. Then n more numbers and print theri sum;
			int n, sum = 0;
			n = int.Parse(Console.ReadLine());
			for (int i = 0; i < n; i++)
			{
				int num = int.Parse(Console.ReadLine());
				sum += num;
			}
			Console.WriteLine("The sum is {0}", sum);
		}
	}
}
