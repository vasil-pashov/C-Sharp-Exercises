using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11_NumberNames
{
	class Task11_NumberNames
	{
		static string GetDigitName(int digit)
		{
			switch (digit)
			{
				case 1: return "one";
				case 2: return "two"; 
				case 3: return "three";
				case 4: return "four";
				case 5: return "five";
				case 6: return "six";
				case 7: return "seven";
				case 8: return "eight";
				case 9: return "nine";
				default: return null;
			}
		}
		static string GetTensName(int tens)
		{
			switch (tens)
			{
				case 1: return "ten";
				case 2: return "twenty";
				case 3: return "thirty";
				case 4: return "fourty";
				case 5: return "fivety";
				case 6: return "sixty";
				case 7: return "seventy";
				case 8: return "eighty";
				case 9: return "ninety";
				default: return null;
			}
		}
		static string GetTeenName(int teen)
		{
			switch (teen)
			{
				case 10: return "ten";
				case 11: return "eleven";
				case 12: return "twelve";
				case 13: return "thirteen";
				case 14: return "fourteen";
				case 15: return "fifteen";
				case 16: return "sixteen";
				case 17: return "seventeen";
				case 18: return "eighteen";
				case 19: return "nineteen";
				default: return null;
			}
		}
		static string GetName(int number)
		{
			int digit = number % 10;
			int tens = (number / 10) % 10;
			int hundreds = (number / 100);
			string numberName = "";
			if (hundreds > 0)
			{
				numberName += GetDigitName(hundreds) + " hundred ";
			}
			if (tens == 0 ^ digit == 0 && hundreds != 0)
			{
				numberName += "and ";
			}
			if (tens == 1)
			{
				numberName += GetTeenName(tens * 10 + digit);
			}
			else
			{
				numberName += GetTensName(tens) + " ";
				numberName += GetDigitName(digit);
			}
			return numberName;
		}
		static void Main(string[] args)
		{
			//*Task input a number [0;999] and print its name
			//int number = int.Parse(Console.ReadLine());
			for (int i = 1; i < 200; i++)
			{
				Console.WriteLine(GetName(i));
			}
		}
	}
}
