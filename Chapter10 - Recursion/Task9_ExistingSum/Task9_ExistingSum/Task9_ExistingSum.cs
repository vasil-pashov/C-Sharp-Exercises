using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9_ExistingSum
{
	class Task9_ExistingSum
	{
		static int[] subsetSum;
		static bool SumExistsRecursive(int[] numbers, int currentSum, int sum, int subsetIndex, int numbersIndex)
		{
			if (currentSum == sum)
			{
				for (int i = 0; i < subsetIndex; i++)
				{
					Console.Write(subsetSum[i] + " ");
				}
				Console.WriteLine();
				return true;
			}
			if (currentSum > sum)
			{
				return false;
			}
			for (int i = numbersIndex; i < numbers.Length; i++)
			{
				bool sumFound;
				subsetSum[subsetIndex] = numbers[i];
				sumFound = SumExistsRecursive(numbers, currentSum + numbers[i], sum, subsetIndex + 1, i + 1);
				if (sumFound)
				{
					return true;
				}
			}
			return false;
		}
		static int FindMaxSum(int[] numbers)
		{
			int result = 0;
			foreach (int number in numbers)
			{
				result += number;
			}
			return result;
		}
		static bool SumExistsIterative(int[] numbers, int sum)
		{
			int maxSum = FindMaxSum(numbers);
			int[] possibleSums = new int[maxSum + 1];
			for (int i = 0; i < numbers.Length; i++)
			{
				for (int j = maxSum; j >= maxSum - numbers[i]; j--)
				{
					if (possibleSums[j] == 1 && j - numbers[i] >= 0)
					{
						if (sum == j || j - numbers[i] == sum)
						{
							return true;
						}
						possibleSums[j - numbers[i]] = 1;
					}
				}
				possibleSums[maxSum - numbers[i]] = 1;
			}
			return false;
		}
		static void Main(string[] args)
		{
			//Task: Given a set of positive numbers write program that checks if there is subset of numbers with sum = sum
			int sum, n;
			Console.WriteLine("Enter array length");
			n = int.Parse(Console.ReadLine());
			int[] numbers = new int[n];
			subsetSum = new int[n];
			Console.WriteLine("Enter array");
			for (int i = 0; i < n; i++)
			{
				numbers[i] = int.Parse(Console.ReadLine());
			}
			Console.WriteLine("Enter sum");
			sum = int.Parse(Console.ReadLine());
			Console.WriteLine("Is there a subset with sum = {0}? {1}", sum, SumExistsRecursive(numbers, 0, sum, 0, 0));
			Console.WriteLine("Is there a subset with sum = {0}? {1}", sum, SumExistsIterative(numbers, sum));
		}
	}
}
