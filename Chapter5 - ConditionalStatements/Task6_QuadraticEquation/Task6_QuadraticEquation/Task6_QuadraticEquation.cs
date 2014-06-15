using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_QuadraticEquation
{
	class Task6_QuadraticEquation
	{
		static void Main(string[] args)
		{
			//Task solve Quadratic Equation print the number of the roots (0, 1, 2) and the roots
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
				if (D > 0)
				{
					Console.WriteLine("The answers to the equation {0}x*x + {1}x + {2} = 0 are x1 = {3} x2 = {4}. Two different roots", a, b, c, x1, x2);
				}
				if (D == 0)
				{
					Console.WriteLine("The answer to the equation {0}x*x + {1}x + {2} = 0 is x1 = {3}. One double root", a, b, c, x1);
				}

			}
		}
	}
}
