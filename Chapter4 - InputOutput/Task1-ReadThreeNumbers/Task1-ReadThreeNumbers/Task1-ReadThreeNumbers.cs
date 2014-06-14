using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_ReadThreeNumbers
{
	class Task1_ReadThreeNumbers
	{
		static void Main(string[] args)
		{
			//Task: Read three numbers and outputh their sum
			int a, b, c;
			a = int.Parse(Console.ReadLine());
			b = int.Parse(Console.ReadLine());
			c = int.Parse(Console.ReadLine());
			Console.WriteLine(a + b + c);
		}
	}
}
