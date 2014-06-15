using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_FibonacciSum
{
	class Task5_FibonacciSum
	{
		static void Main(string[] args)
		{
			//Task: Find the sum of the first n fibonacci numbers 0, 1, 1...
			int n = int.Parse(Console.ReadLine());
			ulong sum = 1, a = 0, b = 1;
			for (int i = 0; i < n - 2; i++)
			{
				ulong next = a + b;
				a = b;
				b = next;
				sum += next;
				//Console.WriteLine(next);
			}
			Console.WriteLine(sum);
		}
	}
}
