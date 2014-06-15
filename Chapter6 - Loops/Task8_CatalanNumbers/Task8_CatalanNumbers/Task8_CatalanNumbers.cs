using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8_CatalanNumbers
{
	class Task8_CatalanNumbers
	{
		static void Main(string[] args)
		{
			//Task: Compute n-th Catalan number (2 * n)! / (n + 1)! * n!
			int n, counter = 2;
			n = int.Parse(Console.ReadLine());
			ulong catalan = 1;
			for (int i = n + 2; i <= 2 * n; i++)
			{
				catalan *= (ulong)i;
				if(counter <= n && catalan % (ulong)counter == 0)
				{
					catalan /= (ulong)counter;
					counter++;
				}
			}
			for (int i = counter; i <= n; i++)
			{
				catalan /= (ulong)i;
			}
			Console.WriteLine(catalan);
		}
	}
}
