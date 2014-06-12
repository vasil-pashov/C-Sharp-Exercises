using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13_ChangeBitAtPossition
{
	class Task13_ChangeBitAtPossition
	{
		static void Main(string[] args)
		{
			//Task given a number, value(0,1) and a position change n-th the bit of the number to value bit count strats from 0
			int number, position, value, mask;
			number = int.Parse(Console.ReadLine());
			position = int.Parse(Console.ReadLine());
			Console.WriteLine(Convert.ToString(number, 2));
			value = int.Parse(Console.ReadLine());
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
			Console.WriteLine(Convert.ToString(number, 2));
		}
	}
}
