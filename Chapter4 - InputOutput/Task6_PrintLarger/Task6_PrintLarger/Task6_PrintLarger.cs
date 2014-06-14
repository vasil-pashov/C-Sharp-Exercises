using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_PrintLarger
{
	class Task6_PrintLarger
	{
		static void Main(string[] args)
		{
			//Task: Print larger number from two without using ifs
			double a, b;
			a = double.Parse(Console.ReadLine());
			b = double.Parse(Console.ReadLine());
			double smaller = ( (a + b) / 2.0 )+  Math.Abs( (a - b) / 2.0) ;
			Console.WriteLine(smaller);
		}
	}
}
