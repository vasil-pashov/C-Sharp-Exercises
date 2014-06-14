using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_Input5Numbers
{
	class Task7_Input5Numbers
	{
		static void Main(string[] args)
		{
			//Task input 5 numbers if there is mistake print message and wait for new input and print their sum
			int sum = 0, counter = 0;
			while (counter < 5)
			{
				int number;
				bool isCorrect = int.TryParse(Console.ReadLine(), out number);
				if (isCorrect)
				{
					counter++;
					sum += number;
				}
				else
				{
					Console.WriteLine("The input is wrong. Please try again. You should enter an integer.");
				}
			}
			Console.WriteLine(sum);
		}
	}
}
