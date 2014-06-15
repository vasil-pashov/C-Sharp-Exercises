using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9_FactorialOverPower
{
	class Task9_FactorialOverPower
	{
		static void Main(string[] args)
		{
			//Task: Compute 1 + (1! / x) + (2! / x^2) + (3! / x^3)... 2! / x^n
			int n, x;
			n = int.Parse(Console.ReadLine());
			x = int.Parse(Console.ReadLine());
			ulong fact = 1, xPower = (ulong)x;
			double result = 1.0;
			for (int i = 1; i <= n; i++, xPower *= (ulong)x, fact *= (ulong)i)
			{
				//Console.WriteLine(xPower + " " + fact + " " + ((double)fact / xPower));
				result += ((double)fact / xPower);
			}
			Console.WriteLine(result);
		}
	}
}
