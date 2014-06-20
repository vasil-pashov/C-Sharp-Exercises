using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10_Horner
{
	class Task10_Horner
	{
		static void Main(string[] args)
		{
			//Task: Convert binary number to decimal using Horner's method
			Console.WriteLine("Enter binary number");
			string binary = Console.ReadLine();
			int dec = 0;
			for (int i = 0; i < binary.Length - 1; i++)
			{
				dec += binary[i] - '0';
				dec <<= 1;
			}
			dec += binary[binary.Length - 1] - '0';
			Console.WriteLine("The decimal representation of {0} is {1}", binary, dec);
		}
	}
}
