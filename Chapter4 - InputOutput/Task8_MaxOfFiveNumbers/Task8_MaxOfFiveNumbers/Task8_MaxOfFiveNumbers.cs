using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8_MaxOfFiveNumbers
{
	class Task8_MaxOfFiveNumbers
	{
		static void Main(string[] args)
		{
			//Task print the larger of five numbers
			int a, b, max;
			a = int.Parse(Console.ReadLine());
			b = int.Parse(Console.ReadLine());
			max = Math.Max(a, b);
			for (int i = 0; i < 3; i++)
			{
				int number = int.Parse(Console.ReadLine());
				max = Math.Max(max, number);
			}
			Console.WriteLine("Max number = {0}", max);
		}
	}
}
