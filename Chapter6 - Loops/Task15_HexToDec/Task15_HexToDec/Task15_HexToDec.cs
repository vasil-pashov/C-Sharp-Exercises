using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task15_HexToDec
{
	class Task15_HexToDec
	{
		static int GetDigit(char digit)
		{
			switch (digit)
			{
				case '0': return 0;
				case '1': return 1;
				case '2': return 2;
				case '3': return 3;
				case '4': return 4;
				case '5': return 5;
				case '6': return 6;
				case '7': return 7;
				case '8': return 8;
				case '9': return 9;
				case 'A': return 10;
				case 'B': return 11;
				case 'C': return 12;
				case 'D': return 13;
				case 'E': return 14;
				case 'F': return 15;
				default: return 0;
			}
		}
		static void Main(string[] args)
		{
			//Task: Convert hexadecimal number to decimal
			string hex = Console.ReadLine();
			int decNumber = 0;
			hex = hex.ToUpper();
			for (int i = hex.Length - 1, d = 1; i >= 0; i--, d*=16)
			{
				decNumber += GetDigit(hex[i]) * d;
			}
			Console.WriteLine(decNumber);
		}
	}
}
