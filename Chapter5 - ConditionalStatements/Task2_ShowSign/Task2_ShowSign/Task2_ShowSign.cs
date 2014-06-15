using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_ShowSign
{
	class Task2_ShowSign
	{
		static void Main(string[] args)
		{
			//Task. Given three real numbers show the sign of their miltiplication without calculating it
			double a, b, c;
			bool isPositive = true;
			a = double.Parse(Console.ReadLine());
			b = double.Parse(Console.ReadLine());
			c = double.Parse(Console.ReadLine());
			if (a < 0)
				isPositive = false;
			isPositive = !((b > 0) ^ isPositive);
			isPositive = !((c > 0) ^ isPositive);
			if (isPositive)
			{
				Console.WriteLine("+");
			}
			else
			{
				Console.WriteLine('-');
			}
		}
	}
}
