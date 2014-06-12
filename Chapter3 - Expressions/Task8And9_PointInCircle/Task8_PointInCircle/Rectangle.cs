using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8_PointInCircle
{
	class Rectangle
	{
		Point upperLeft;
		Point lowerRight;
		public Rectangle()
		{
			this.upperLeft = new Point();
			this.lowerRight = new Point();
		}
		public Rectangle(float leftX, float leftY, float rightX, float rightY)
		{
			this.upperLeft = new Point(leftX, leftY);
			this.lowerRight = new Point(rightX, rightY);
		}
		public Rectangle(Point upperLeft, Point lowerRight)
		{
			this.upperLeft = upperLeft;
			this.lowerRight = lowerRight;
		}
		public Point UpperLeft
		{
			get { return this.upperLeft; }
			set { this.upperLeft = value; }
		}
		public Point LowerRight
		{
			get { return this.lowerRight; }
			set { this.lowerRight = value; }
		}
		public bool ContainsPoint(Point p)
		{
			return (p.X > upperLeft.X && p.Y < upperLeft.Y) && (p.X < lowerRight.X && p.Y > lowerRight.Y);
		}
	}
}
