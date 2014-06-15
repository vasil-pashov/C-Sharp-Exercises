using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_FactorialsDivision
{
	class Task7_FactorialsDivision
	{
		static void Main(string[] args)
		{
			//Task: Compute N! * K! / (N - K)! (1 < K < N)
			int n, k;
			n = int.Parse(Console.ReadLine());
			k = int.Parse(Console.ReadLine());
			ulong product = 1;
			for (int i = 2; i <= k; i++)
			{
				product *= (ulong)i;
			}
			for (int i = n - k + 1; i <= n; i++ )
			{
				product *= (ulong)i;
			}
			Console.WriteLine(product);
		}
	}
}
