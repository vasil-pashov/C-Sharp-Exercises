using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12_Fibonacci
{
	class Task12_Fibonacci
	{
		static void Main(string[] args)
		{
			//Task print first 100 fibonacci numbers. Ex 0, 1, 1...;
			ulong a = 0, b = 1;
			Console.Write(a + ", " + b + ", ");
			for (int i = 0; i < 100; i++)
			{
				Console.Write(a + b + ", ");
				ulong temp = a + b;
				a = b;
				b = temp;
			}
		}
	}
}
