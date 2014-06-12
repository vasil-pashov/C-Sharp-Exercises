using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task14_IsPrime
{
	class Task14_IsPrime
	{
		static void Main(string[] args)
		{
			//Task write program that checks if a number is prime
			int number = int.Parse(Console.ReadLine());
			bool isPrime = true;
			for (int i = 2; i < Math.Sqrt(number); i++)
			{
				if (number % i == 0)
				{
					isPrime = false;
					break;
				}
			}
			if (isPrime)
			{
				Console.WriteLine("{0} is prime", number);
			}
			else
			{
				Console.WriteLine("{0} is not prime", number);
			}
		}
	}
}
