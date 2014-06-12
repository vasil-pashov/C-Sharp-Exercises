using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_IsDevidedBy5And7
{
	class Task2_IsDevidedBy5And7
	{
		static void Main(string[] args)
		{
			//Task write an expression taht checks if number can be devided by 5 and 7 at the same time
			int num = int.Parse(Console.ReadLine());
			bool isDevided = num % 35 == 0 ? true : false;
			Console.WriteLine("Is {0} devided by 7 and 5 {1}", num, isDevided);
		}
	}
}
