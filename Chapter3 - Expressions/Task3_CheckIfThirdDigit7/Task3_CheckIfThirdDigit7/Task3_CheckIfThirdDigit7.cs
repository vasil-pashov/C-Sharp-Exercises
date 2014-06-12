using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_CheckIfThirdDigit7
{
	class Task3_CheckIfThirdDigit7
	{
		static void Main(string[] args)
		{
			//Task write expression that checks if the third digit (from right to left) of a number is 7
			int number = int.Parse(Console.ReadLine());
			bool isSeven = (number / 100) % 10 == 7 ? true : false;
			Console.WriteLine("Is the third digit of {0} 7 {1}", number, isSeven);
		}
	}
}
