using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12_ArabicToRoman
{
	class Task12_ArabicToRoman
	{
		static string GetThousand(int number)
		{
			int thousand = number / 1000;
			switch (thousand)
			{
				case 0: return "";
				case 1: return "M";
				case 2: return "MM";
				case 3: return "MMM";
				default: return null;
			}
		}
		static string GetHundred(int number)
		{
			int hundred = (number / 100) % 10;
			switch (hundred)
			{
				case 0: return "";
				case 1: return "C";
				case 2: return "CC";
				case 3: return "CCC";
				case 4: return "CD";
				case 5: return "D";
				case 6: return "DC";
				case 7: return "DCC";
				case 8: return "DCCC";
				case 9: return "CM";
				default: return null;
			}
		}
		static string GetTens(int number)
		{
			int tens = (number / 10) % 10;
			switch (tens)
			{
				case 0: return "";
				case 1: return "X";
				case 2: return "XX";
				case 3: return "XXX";
				case 4: return "XL";
				case 5: return "X";
				case 6: return "LX";
				case 7: return "LXX";
				case 8: return "LXXX";
				case 9: return "XC";
				default: return null;
			}
		}
		static string GetDigit(int number)
		{
			int digit = number % 10;
			switch (digit)
			{
				case 0: return "";
				case 1: return "I";
				case 2: return "II";
				case 3: return "III";
				case 4: return "IV";
				case 5: return "V";
				case 6: return "VI";
				case 7: return "VII";
				case 8: return "VIII";
				case 9: return "IX";
				default: return null;
			}
		}
		static void Main(string[] args)
		{
			//Task: Convert arabic number to roman
			Console.WriteLine("Enter arabic number in interval [1; 3999]");
			int arabic = int.Parse(Console.ReadLine());
			if (arabic < 1 || arabic > 3999)
			{
				Console.WriteLine("The number must be between 1 and 3999");
			}
			else
			{
				string roman = "";
				roman += GetThousand(arabic);
				roman += GetHundred(arabic);
				roman += GetTens(arabic);
				roman += GetDigit(arabic);
				Console.WriteLine("{0} = {1}", arabic, roman);
			}
		}
	}
}
