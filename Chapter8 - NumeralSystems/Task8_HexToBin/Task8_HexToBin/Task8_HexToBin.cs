using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8_HexToBin
{
	class Task8_HexToBin
	{
		static string GetDigit(char digit)
		{
			switch (digit)
			{
				case '0': return "0000";
				case '1': return "0001";
				case '2': return "0010";
				case '3': return "0011";
				case '4': return "0100";
				case '5': return "0101";
				case '6': return "0110";
				case '7': return "0111";
				case '8': return "1000";
				case '9': return "1001";
				case 'A': return "1010";
				case 'B': return "1011";
				case 'C': return "1100";
				case 'D': return "1101";
				case 'E': return "1110";
				case 'F': return "1111";
				default: return null;
			}
		}
		static string ConvertToBinary(string hex)
		{
			string result = "";
			for (int i = hex.Length - 1; i >= 0; i--)
			{
				result = GetDigit(hex[i]) + result;
			}
			return result;
		}
		static void Main(string[] args)
		{
			//Task: Convert hexadecimal number to binary
			Console.WriteLine("Enter hexadecimal number");
			string hex, bin = "";
			hex = Console.ReadLine();
			hex = hex.ToUpper();
			bin = ConvertToBinary(hex);
			Console.WriteLine("The binary representation of {0} is {1}", hex, bin);
		}
	}
}
