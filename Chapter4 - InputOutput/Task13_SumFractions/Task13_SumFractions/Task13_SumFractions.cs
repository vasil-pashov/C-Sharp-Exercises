using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13_SumFractions
{
	class Task13_SumFractions
	{
		static void Main(string[] args)
		{
			//Task pirnt the sum of 1 + 1/2 + 1/3 ... with precision 0.001
			double sum = 1.0;
			double oldSum = 0.0;
			int i = 2;
			while(sum - oldSum > 0.001)
			{
				oldSum = sum;
				sum += 1.0 / i;
				i++;
			}
			Console.WriteLine(sum + " " + oldSum);
		}
	}
}
