using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task15_SwapBits
{
	class Task15And16_SwapBits
	{
		static void ChangeBitAtPossition(ref int number, int position, int value)
		{
			int mask = 1;
			int temp = number;
			if (value == 1)
			{
				mask = 1 << position;
				number |= mask;
			}
			else if (value == 0)
			{
				mask = 1 << position;
				mask--;
				mask = (1 << position);
				number &= (~mask);
			}

		}
		static int GetBitAtPossition(int number, int position)
		{
			
			number >>= position;
			return (number & 1) == 1 ? 1 : 0;
		}
		static void SwapBits(ref int number, int position1, int position2)
		{
			int bit1 = GetBitAtPossition(number, position1);
			int bit2 = GetBitAtPossition(number, position2);
			ChangeBitAtPossition(ref number, position1, bit2);
			ChangeBitAtPossition(ref number, position2, bit1);
			//Console.WriteLine(number);
		}
		static void Main(string[] args)
		{
			int number, k, p, q;
			number = int.Parse(Console.ReadLine());
			//Task write a program that swaps the 3,4,5 th bits with the 24,25,26 th bits
			//solution
			/*
			Console.WriteLine(Convert.ToString(number, 2));
			SwapBits(ref number, 3, 24);
			Console.WriteLine(Convert.ToString(number, 2));
			SwapBits(ref number, 4, 25);
			Console.WriteLine(Convert.ToString(number, 2));
			SwapBits(ref number, 5, 26);
			Console.WriteLine(Convert.ToString(number, 2));*/
			//Task write program thaw swaps the p, p + 1, p + k - 1 bits with q, q + 1, 1 + k - 1 bits;
			k = int.Parse(Console.ReadLine());
			p = int.Parse(Console.ReadLine());
			q = int.Parse(Console.ReadLine());
			for (int i = 0; i < k; i++)
			{
				SwapBits(ref number, p + k, q + k);
			}

		}
	}
}
