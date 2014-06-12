using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_RectangularFaceAndPerimeter
{
	class Task6_RectangularFaceAndPerimeter
	{
		static void Main(string[] args)
		{
			//Task find the area and the perimeter of a rectangle
			float a, b;
			a = float.Parse(Console.ReadLine());
			b = float.Parse(Console.ReadLine());
			float area = a * b;
			float perimeter = 2 * (a + b);
			Console.WriteLine("The area of the rectangle is {0} the perimeter is {1}", area, perimeter);
		}
	}
}
