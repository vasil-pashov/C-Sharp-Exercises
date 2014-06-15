using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11_FactorialZeros
{
	class Task11_FactorialZeros
	{
		static void Main(string[] args)
		{
			//Task compute how many zeros are there at the end of n! for given n
			int n, zeros = 0;
			n = int.Parse(Console.ReadLine());
			for (int d = 5; d <= n; d *= 5 )
			{
				zeros += n / d;
			}
			Console.WriteLine(zeros);
		}
	}
}
