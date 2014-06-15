using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_PrintSmallest
{
	class Task3_PrintSmallest
	{
		static void Main(string[] args)
		{
			//Task: Read n numbers from the console and and print the smallest
			int min = int.MaxValue, n;
			n = int.Parse(Console.ReadLine());
			for (int i = 0; i < n; i++)
			{
				int number = int.Parse(Console.ReadLine());
				min = number < min ? number : min;
			}
			Console.WriteLine(min);
		}
	}
}
