using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8_PointInCircle
{
	class Point
	{
		float x;
		float y;
		public Point()
		{
			this.x = float.MinValue;
			this.y = float.MinValue;
		}
		public Point(float x, float y)
		{
			this.x = x;
			this.y = y;
		}
		public float X
		{
			get { return this.x; }
			set { this.x = value; }
		}
		public float Y
		{
			get { return this.y; }
			set { this.y = value; }
		}
		public float FindSqrtDistanceTo(Point other)
		{
			return (this.x - other.x) * (this.x - other.x) + (this.y - other.y) * (this.y - other.y);
		}
	}
}
