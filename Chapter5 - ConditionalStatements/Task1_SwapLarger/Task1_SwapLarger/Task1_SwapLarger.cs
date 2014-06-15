using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_SwapLarger
{
	class Task1_SwapLarger
	{
		static void Main(string[] args)
		{
			//Task enter two numbers: a, b. Swap them if a is larger.
			int a, b;
			a = int.Parse(Console.ReadLine());
			b = int.Parse(Console.ReadLine());
			if (a > b)
			{
				a ^= b;
				b ^= a;
				a ^= b;
			}
			Console.WriteLine(a + " " + b);
		}
	}
}
