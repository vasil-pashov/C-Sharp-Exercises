using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_NFactDevidedByKFact
{
	class Task6_NFactDevidedByKFact
	{
		static void Main(string[] args)
		{
			//Task compute N!/K! for (1 < K < N)
			int n, k;
			n = int.Parse(Console.ReadLine());
			k = int.Parse(Console.ReadLine());
			ulong product = 1;
			for (int i = k + 1; i <= n; i++)
			{
				product *= (ulong)i;
			}
			Console.WriteLine(product);
		}
	}
}
