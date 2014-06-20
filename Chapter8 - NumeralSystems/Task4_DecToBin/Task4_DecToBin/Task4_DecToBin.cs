using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_DecToBin
{
	class Task4_DecToBin
	{
		static void Main(string[] args)
		{
			//Task: Write program that converts decimal number to binary
			Console.WriteLine("Enter decimal number");
			int decimalNumber, decimalNumberCopy;
			decimalNumber = int.Parse(Console.ReadLine());
			decimalNumberCopy = decimalNumber;
			string binaryNumber = "";
			while (decimalNumber > 0)
			{
				binaryNumber = decimalNumber % 2 + binaryNumber;
				decimalNumber /= 2;
			}
			Console.WriteLine("The binary representation of {0} is {1}", decimalNumberCopy, binaryNumber);
		}
	}
}
