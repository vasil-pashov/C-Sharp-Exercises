using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Task10_Factoriel
{
	class Task10_Factoriel
	{
		static BigInteger ComputeFactoriel(int n)
		{
			BigInteger result = 1;
			for (int i = 2; i <= n; i++)
			{
				result *= i;
			}
			return result;
		}
		static void Main(string[] args)
		{
			//Write method that computes n! in interval [1; 100]
			Console.WriteLine("Enter n");
			int n = int.Parse(Console.ReadLine());
			Console.WriteLine("{0}! = {1}", n, ComputeFactoriel(n));
		}
	}
}
