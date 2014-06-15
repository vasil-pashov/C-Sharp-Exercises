using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12_DecToBin
{
	class Task12_DecToBin
	{
		static void Main(string[] args)
		{
			//Task: Convert decimal number to binary number
			int n = int.Parse(Console.ReadLine());
			string binary = "";
			//With func
			Console.WriteLine(Convert.ToString(n,2));
			//Loop
			while (n != 0)
			{
				//binary = binary.Insert(0, (n % 2).ToString());
				binary = n % 2 == 1 ? 1 + binary : 0 + binary;
				n /= 2;
			}
			Console.WriteLine(binary);
		}
	}
}
