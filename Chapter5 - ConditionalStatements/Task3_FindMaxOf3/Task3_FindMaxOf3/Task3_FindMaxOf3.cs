using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_FindMaxOf3
{
	class Task3_FindMaxOf3
	{
		static void Main(string[] args)
		{
			//Task: Given 3 numbers find the max
			int a, b, c;
			a = int.Parse(Console.ReadLine());
			b = int.Parse(Console.ReadLine());
			c = int.Parse(Console.ReadLine());
			int max = Math.Max(Math.Max(a, b), c);
			Console.WriteLine("The max number is {0}", max);
		}
	}
}
