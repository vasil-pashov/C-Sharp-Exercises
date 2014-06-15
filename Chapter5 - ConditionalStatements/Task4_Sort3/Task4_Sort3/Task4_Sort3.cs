using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_Sort3
{
	class Task4_Sort3
	{
		static void Main(string[] args)
		{
			//Task given 3 real numbers sort then in descending order
			double a, b, c;
			a = double.Parse(Console.ReadLine());
			b = double.Parse(Console.ReadLine());
			c = double.Parse(Console.ReadLine());
			/*SMARTER WAY
			 * double [] arr = new double[3];
			arr[0] = a;
			arr[1] = b;
			arr[2] = c;
			Array.Sort(arr);
			Array.Reverse(arr);*/
			if (a >= b && b >= c)
			{
				Console.WriteLine(a + " " + b + " " + c);
			} else if (a >= c && c >= b)
			{
				Console.WriteLine(a + " " + c + " " + b);
			}else if (b >= a && a >= c)
			{
				Console.WriteLine(b + " " + a + " " + c);
			}else if (b >= c && c >= a)
			{
				Console.WriteLine(b + " " + c + " " + a);
			}else if (c >= a && c >= b)
			{
				Console.WriteLine(c + " " + a + " " + b);
			}else if (c >= b && b >= a)
			{
				Console.WriteLine(c + " " + b + " " + a);
			}	
		}
	}
}
