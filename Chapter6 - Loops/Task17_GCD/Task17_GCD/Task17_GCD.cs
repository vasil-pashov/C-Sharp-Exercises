using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17_GCD
{
	class Task17_GCD
	{
		static void Main(string[] args)
		{
			//Task: Find the Gratest common divisor of two numbers
			int a, b;
			a = int.Parse(Console.ReadLine());
			b = int.Parse(Console.ReadLine());
			while (a != b)
			{
				if (a > b)
				{
					a -= b;
				}
				if (b > a)
				{
					b -= a;
				}
			}
			Console.WriteLine(a);
		}
	}
}
