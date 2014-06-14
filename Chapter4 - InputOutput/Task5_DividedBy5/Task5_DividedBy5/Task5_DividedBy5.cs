using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_DividedBy5
{
	class Task5_DividedBy5
	{
		static void Main(string[] args)
		{
			//Task: Input two numbers and output the how many numbers int the interval [a;b] are devided by 5
			int a, b;
			a = int.Parse(Console.ReadLine());
			b = int.Parse(Console.ReadLine());
			int counter = 0;
			for (int i = a; i <= b; i++)
			{
				if (i % 5 == 0)
				{
					counter++;
				}
			}
			Console.WriteLine(counter);
		}
	}
}
