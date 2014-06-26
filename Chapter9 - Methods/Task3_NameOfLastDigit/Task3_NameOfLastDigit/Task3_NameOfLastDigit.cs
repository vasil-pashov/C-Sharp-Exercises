using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_NameOfLastDigit
{
	class Task3_NameOfLastDigit
	{
		static string GetLastDigitName(int number)
		{
			int lastDigit = number % 10;
			switch (lastDigit)
			{
				case 0: return "Zero";
				case 1: return "One";
				case 3: return "Three";
				case 4: return "Four";
				case 5: return "Five";
				case 6: return "Six";
				case 7: return "Seven";
				case 8: return "Eight";
				case 9: return "Nine";
				default: throw new Exception("Incorrect input");
			}
		}
		static void Main(string[] args)
		{
			//Task: Write method that returns the name of the last digit of a number
			Console.WriteLine(GetLastDigitName(123));
		}
	}
}
