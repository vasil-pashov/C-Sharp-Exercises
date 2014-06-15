using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task14_DecToHex
{
	class Task14_DecToHex
	{
		static string GetHexDigit(int digit)
		{
			switch (digit)
			{
				case 0: return "0";
				case 1: return "1";
				case 2: return "2";
				case 3: return "3";
				case 4: return "4";
				case 5: return "5";
				case 6: return "6";
				case 7: return "7";
				case 8: return "8";
				case 9: return "9";
				case 10: return "A";
				case 11: return "B";
				case 12: return "C";
				case 13: return "D";
				case 14: return "E";
				case 15: return "F";
				default: return null;
			}
		}
		static void Main(string[] args)
		{
			//Task: Convert decmal number to hexadecimal
			int n = int.Parse(Console.ReadLine());
			//via function
			Console.WriteLine(Convert.ToString(n, 16));
			//via loop
			string hex = "";
			while (n > 0)
			{
				hex = GetHexDigit(n % 16) + hex;
				n /= 16;
			}
			Console.WriteLine(hex);
		}
	}
}
