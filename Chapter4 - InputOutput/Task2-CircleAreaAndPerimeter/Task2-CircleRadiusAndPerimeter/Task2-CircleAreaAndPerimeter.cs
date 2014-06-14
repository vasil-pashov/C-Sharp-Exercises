using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_CircleRadiusAndPerimeter
{
	class Task2_CircleAreaAndPerimeter
	{
		static void Main(string[] args)
		{
			//Task: Read the radius of a circle and output its perimeter and area
			double r = double.Parse(Console.ReadLine());
			double perimeter = 2 * Math.PI * r;
			double area = Math.PI * r * r;
			Console.WriteLine("The perimeter of the circle is {0}, the area is {1}", perimeter, area);
		}
	}
}
