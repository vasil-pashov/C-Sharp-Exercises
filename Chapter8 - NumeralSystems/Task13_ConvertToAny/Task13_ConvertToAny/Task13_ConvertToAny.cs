using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13_ConvertToAny
{
	class Task13_ConvertToAny
	{
		static int ConvertToDecimal(string number, int numberBase)
		{
			int decimalRepresentation = 0;
			for (int i = number.Length - 1, multiplier = 1; i >= 0; i--, multiplier *= numberBase)
			{
				int digit;
				if (Char.IsNumber(number[i]))
				{
					digit = number[i] - '0';
				}
				else
				{
					digit = (number[i] - 'A') + 10;
				}
				decimalRepresentation += digit * multiplier;
			}
			return decimalRepresentation;
		}
		static string ConvertToNewBaseSystem(int decimalNumber, int newBase)
		{
			string newNumber = "";
			while (decimalNumber > 0)
			{
				int decDigit = decimalNumber % newBase;
				char newDigit;
				if (decDigit < 10)
				{
					newDigit = (char)(decDigit + '0');
				}
				else
				{
					newDigit = (char)('A' + (decDigit - 10));
				}
				newNumber = newDigit + newNumber;
				decimalNumber /= newBase;
			}
			return newNumber;
		}
		static void Main(string[] args)
		{
			//Task: Convert number - N from numeral system with base S to numeral system with base D. Where (2 ≤ S, D ≥ 16)
			Console.WriteLine("Number");
			string n;
			int s, d;
			n = Console.ReadLine();
			Console.WriteLine("Number base");
			s = int.Parse(Console.ReadLine());
			Console.WriteLine("New base");
			d = int.Parse(Console.ReadLine());
			string newNumber = ConvertToNewBaseSystem(ConvertToDecimal(n, s), d);
			Console.WriteLine("{0} with base {1} is equal to {2} with base {3}",n, s, newNumber, d);
		}
	}
}
