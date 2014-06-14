using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9_QuadraticEquation
{
	class Task9_QuadraticEquation
	{
		static void Main(string[] args)
		{
			int a, b, c;
			a = int.Parse(Console.ReadLine());
			b = int.Parse(Console.ReadLine());
			c = int.Parse(Console.ReadLine());
			double D = b * b - 4 * a * c;
			if (D < 0)
			{
				Console.WriteLine("The solution is not real number");
			}
			else
			{
				double x1 = (-b + Math.Sqrt(D)) / 2 * a;
				double x2 = (-b - Math.Sqrt(D)) / 2 * a;
				Console.WriteLine("The answers to the equation {0}x*x + {1}x + {2} = 0 are x1 = {3} x2 = {4}", a, b, c, x1, x2);
			}
		}
	}
}
