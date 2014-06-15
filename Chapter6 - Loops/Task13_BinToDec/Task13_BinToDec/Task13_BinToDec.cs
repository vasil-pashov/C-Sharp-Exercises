using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13_BinToDec
{
	class Task13_BinToDec
	{
		static void Main(string[] args)
		{
			//Task convert Binary number to decimal 
			string binary = Console.ReadLine();
			int number = 0;
			for (int i = binary.Length - 1, m = 1; i >= 0; i--, m*=2 )
			{
				number += (binary[i] - '0') * m;
			}
			Console.WriteLine(number);
		}
	}
}
