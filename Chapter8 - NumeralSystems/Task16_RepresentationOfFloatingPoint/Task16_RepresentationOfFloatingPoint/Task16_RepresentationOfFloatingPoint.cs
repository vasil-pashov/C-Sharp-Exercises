using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task16_RepresentationOfFloatingPoint
{
	class Task16_RepresentationOfFloatingPoint
	{
		static void Main(string[] args)
		{
			//Task: Print the mantissam the sign of the mantissa and the exponent
			Console.WriteLine("Enter float number");
			float number = float.Parse(Console.ReadLine());
			long convertBitsOfNumber = BitConverter.DoubleToInt64Bits(number);
			string bits = Convert.ToString(convertBitsOfNumber, 2);
			Console.Write(bits[0] + " ");
			Console.Write(bits[1]);
			for (int i = 5; i < 12; i++)
			{
				Console.Write(bits[i]);
			}
			Console.Write(" ");
			for (int i = 12; i < 35; i++)
			{
				Console.Write(bits[i]);
			}
			Console.WriteLine();
		}
	}
}
