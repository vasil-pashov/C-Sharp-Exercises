using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_LongestIncreasingSubsequence
{
	class Task6_LongestIncreasingSubsequence
	{
		static void Main(string[] args)
		{
			//Task: Find the longest increasing subsequence (don't have to be consecutive)
			Console.WriteLine("The lenght of the array = ");
			int n, maxLength = 1, index = 0;
			n = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter the array");
			int[] arr = new int[n], d = new int[n], predicessor = new int[n];
			for (int i = 0; i < n; i++)
			{
				arr[i] = int.Parse(Console.ReadLine());
				d[i] = 1;
			}
			for (int i = 0; i < n; i++)
			{
				for (int j = i - 1; j >= 0; j--)
				{
					if (arr[i] >= arr[j] && d[j] + 1 > d[i])
					{
						d[i] = d[j] + 1;
						predicessor[i] = j;
					}
				}
			}
			for (int i = 0; i < n; i++)
			{
				if (d[i] > maxLength)
				{
					index = i;
					maxLength = d[i];
				}
			}
			Console.Write("Length of the sequence {0} sequence ->", maxLength);
			Console.Write(arr[index] + " ");
			while (predicessor[index] != 0)
			{
				Console.Write(arr[predicessor[index]] + " ");
				index = predicessor[index];
			}
		}
	}
}
