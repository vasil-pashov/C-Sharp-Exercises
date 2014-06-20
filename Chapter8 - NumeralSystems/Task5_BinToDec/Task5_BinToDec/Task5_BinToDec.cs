using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_BinToDec
{
	class Task5_BinToDec
	{
		static void Main(string[] args)
		{
			//Task: Write program that converts binary number to decimal
			Console.WriteLine("Enter binary number");
			string binaryNumber = Console.ReadLine();
			int decimalNumber = 0;
			for (int i = binaryNumber.Length - 1, m = 0; i >= 0; i--)
			{
				decimalNumber += (binaryNumber[i] - '0') * (1 << m);
				m++;
			}
			Console.WriteLine("The decimal representation of {0} is {1}",binaryNumber, decimalNumber);
		}
	}
}
