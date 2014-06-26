using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_GetMax
{
	class Task2_GetMax
	{
		static int GetMax(int a, int b)
		{
			return a > b ? a : b;
		}
		static void Main(string[] args)
		{
			//Task: Write method that takes two int parameters and returns the bigger. Find the largest of three ints using it.
			Console.WriteLine( GetMax(GetMax(5, 8), 3) );
		}
	}
}
