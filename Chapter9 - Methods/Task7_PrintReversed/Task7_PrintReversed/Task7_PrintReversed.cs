using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_PrintReversed
{
	class Task7_PrintReversed
	{
		static void PrintReversed(int number)
		{
			while (number != 0)
			{
				Console.Write(number % 10);
				number /= 10;
			}
			Console.WriteLine();
		}
		static void Main(string[] args)
		{
			//Task: Write method which prints the digits of a number in reversed order
			Console.WriteLine("Enter number");
			int n = int.Parse(Console.ReadLine());
			PrintReversed(n);
		}
	}
}
