using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_MaxSum
{
	class Task7_MaxSum
	{
		static void Main(string[] args)
		{
			//Task: Read two numbers N and K (K < N) then an array of N elements. Find K consecutive numbers with max sum.
			Console.WriteLine("Input N and K");
			int n, k, maxSum = 0, currentSum = 0, startIndex = 0;
			n = int.Parse(Console.ReadLine());
			k = int.Parse(Console.ReadLine());
			int[] numbers = new int[n];
			Console.WriteLine("Input the array");
			for (int i = 0; i < n; i++)
			{
				numbers[i] = int.Parse(Console.ReadLine());
			}
			for (int i = 0; i < k; i++)
			{
				currentSum += numbers[i];
			}
			maxSum = currentSum;
			for (int i = k; i < n; i++)
			{
				currentSum -= numbers[i - k];
				currentSum += numbers[i];
				if (currentSum > maxSum)
				{
					maxSum = currentSum;
					startIndex = i - k + 1;
				}
			}
			Console.Write("Max sum is {0}. Elements -> ", maxSum);
			for (int i = startIndex; i < startIndex + k; i++)
			{
				Console.Write(numbers[i] + " ");
			}
		}
	}
}
