using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8_PointInCircle
{
	class Circle
	{
		Point center;
		float radius;
		public Circle()
		{
			center = new Point();
			radius = 0;
		}
		public Circle(float x, float y, float r)
		{
			center = new Point(x, y);
			this.radius = r;
		}
		public float Radius
		{
			get { return this.radius; }
			set { this.radius = value; }
		}
		public Point Center
		{
			get { return this.center; }
			set { this.center = value; }
		}
		public bool ContainsPoint(Point p)
		{
			float sqrtRadius = this.radius * this.radius;
			return sqrtRadius > p.FindSqrtDistanceTo(this.Center);
		}
	}
}
