using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11_BitAtPosition
{
	class Task11And12_BitAtPosition
	{
		static void Main(string[] args)
		{
			//Task print the bit of given position 
			//Task write bool expression that checks if the bit at position is 1
			int number = int.Parse(Console.ReadLine());
			int numberCopy = number;
			int position = int.Parse(Console.ReadLine());
			/*for (int i = 0; i < position; i++)
			{
				numberCopy >>= 1;
			}*/
			numberCopy >>= position;
			Console.WriteLine("Bit number {0} of {1} is {2}", position, number, numberCopy & 1);
			Console.WriteLine("Is bit {0} = 1 {1}", position, (numberCopy & 1) == 1);
		}
	}
}
