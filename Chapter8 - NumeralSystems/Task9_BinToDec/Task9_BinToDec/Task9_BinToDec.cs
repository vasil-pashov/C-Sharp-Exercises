using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9_BinToDec
{
	class Task9_BinToDec
	{
		static string ConvertByte(string binByte)
		{
			switch (binByte)
			{
				case "0000": return "0";
				case "0001": return "1";
				case "0010": return "2";
				case "0011": return "3";
				case "0100": return "4";
				case "0101": return "5";
				case "0110": return "6";
				case "0111": return "7";
				case "1000": return "8";
				case "1001": return "9";
				case "1010": return "A";
				case "1011": return "B";
				case "1100": return "C";
				case "1101": return "D";
				case "1110": return "E";
				case "1111": return "F";
				default: return null;
			}
		}
		static string ConvertToHex(string bin)
		{
			string hex = "";
			for (int i = 0; i < bin.Length; i+=4 )
			{
				hex += ConvertByte(bin.Substring(i, 4));
			}
			return hex;
		}
		static void Main(string[] args)
		{
			//Task: Convert binaty number to hexadecimal
			Console.WriteLine("Enter binary number");
			string bin, hex = "";
			bin = Console.ReadLine();
			while (bin.Length % 4 != 0)
			{
				bin = 0 + bin;
			}
			hex = ConvertToHex(bin);
			Console.WriteLine("The hexadecimal representation of {0} is {1}", bin, hex);
		}
	}
}
