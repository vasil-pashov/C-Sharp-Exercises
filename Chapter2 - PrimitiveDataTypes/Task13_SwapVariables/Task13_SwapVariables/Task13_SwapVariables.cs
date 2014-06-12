using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13_SwapVariables
{
	class Task13_SwapVariables
	{
		static void Main(string[] args)
		{
			int a = 5, b = 10;
			Console.WriteLine("a: {0} b {1}", a, b);
			a ^= b;
			b ^= a;
			a ^= b;
			Console.WriteLine("a: {0} b{1}", a, b);
		}
	}
}
