using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_IsOdd
{
	class Task1_IsOdd
	{
		static void Main(string[] args)
		{
			//Task wrte expression that checks if a number is odd or even
			int num = int.Parse(Console.ReadLine());
			if (num == 0)
			{
				Console.WriteLine("0 is not odd neiter is even");
			}
			else
			{
				bool isOdd = (num & 1) == 1 ? true : false;
				Console.WriteLine("Is {0} odd {1}", num, isOdd);
			}
		}
	}
}
