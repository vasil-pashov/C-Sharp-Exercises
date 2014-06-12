using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_TrapezoidArea
{
	class Task5_TrapezoidArea
	{
		static void Main(string[] args)
		{
			float a, b, h;
			a = float.Parse(Console.ReadLine());
			b = float.Parse(Console.ReadLine());
			h = float.Parse(Console.ReadLine());
			float area = (a + b) * h / 2;
			Console.WriteLine("The area of the trapezoid is {0}", area);

		}
	}
}
