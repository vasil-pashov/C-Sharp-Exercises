using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8_PointInCircle
{
	class Task8And9_PointInCircle
	{
		static void Main(string[] args)
		{
			//Task Check if point O(x,y) lies in the circle K((0,0), 5)
			//Task Check if point lies in the circle and is ot of the rectangle
			Circle c = new Circle(0f,0f,5f);
			Point p = new Point();
			p.X = float.Parse(Console.ReadLine());
			p.Y = float.Parse(Console.ReadLine());
			Rectangle r = new Rectangle(-1,1,5,5);
			Console.WriteLine("Does the point lie in the circle {0}", c.ContainsPoint(p));
			Console.WriteLine("Is point in the circle and out of the rectangle {0}", c.ContainsPoint(p) && (!r.ContainsPoint(p)));
		}
	}
}
