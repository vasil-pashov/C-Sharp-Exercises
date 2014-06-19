using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9_MaxConsecutiveSum
{
	class Task9_MaxConsecutiveSum
	{
		static void Main(string[] args)
		{
			//Task find the maxum sum of consecutive elements
			Console.WriteLine("Array length = ");
			int n, maxSum = int.MinValue, endIndex = 0;
			n = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter array");
			int[] array = new int[n], sums = new int[n];
			for (int i = 0; i < n; i++)
			{
				array[i] = int.Parse(Console.ReadLine());
			}
			sums[0] = array[0];
			for (int i = 1; i < n; i++)
			{
				sums[i] = Math.Max(sums[i - 1] + array[i], array[i]);
			}
			for (int i = 0; i < n; i++)
			{
				if (sums[i] > maxSum)
				{
					maxSum = sums[i];
					endIndex = i;
				}
			}
			Console.Write("Max sum = {0}. Elements -> ", maxSum);
			for (int i = endIndex; maxSum > 0; i--)
			{
				Console.Write(array[i] + " ");
				maxSum -= array[i];
			}
		}
	}
}
