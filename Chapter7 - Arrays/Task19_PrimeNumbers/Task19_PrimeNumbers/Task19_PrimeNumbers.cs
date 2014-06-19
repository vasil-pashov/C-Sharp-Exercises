using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task19_PrimeNumbers
{
	class Task19_PrimeNumbers
	{
		static void Main(string[] args)
		{
			//Task: Find all prime numbers in interval [1; 10 000 000]
			int[] isPrime = new int[10000000];
			List<int> primeNumbers = new List<int>();
			for (int i = 2; i < 10000000; i++)
			{
				if (isPrime[i] == -1)
				{
					continue;
				}
				primeNumbers.Add(i);
				for (int j = i + i; j < 10000000; j += i)
				{
					isPrime[j] = -1;
				}
			}
			for (int i = 0; i < primeNumbers.Count; i++)
			{
				Console.Write(primeNumbers[i] + " ");
			}
		}
	}
}
