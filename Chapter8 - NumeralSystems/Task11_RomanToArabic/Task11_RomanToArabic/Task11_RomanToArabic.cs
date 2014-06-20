using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11_RomanToArabic
{
	class Task11_RomanToArabic
	{
		static int GetDigit(char digit)
		{
			switch (digit)
			{
				case 'I': return 1;
				case 'V': return 5;
				case 'X': return 10;
				case 'L': return 50;
				case 'C': return 100;
				case 'D': return 500;
				case 'M': return 1000;
				default: return 0;
			}
		}
		static void Main(string[] args)
		{
			//Task: Convert roman number to arabic
			Console.WriteLine("Enter roman number");
			string roman = Console.ReadLine();
			roman = roman.ToUpper();
			int arabic = 0;
			for (int i = roman.Length - 1; i >= 0; i--)
			{
				arabic += GetDigit(roman[i]);
				if (i > 0 && GetDigit(roman[i - 1]) < GetDigit(roman[i]))
				{
					arabic -= GetDigit(roman[i - 1]);
					i--;
				}
			}
			Console.WriteLine("{0} = {1}", roman, arabic);
		}
	}
}
