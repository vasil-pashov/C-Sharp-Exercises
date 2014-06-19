using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_LongestIncreasingSequence
{
	class Task5_LongestIncreasingSequence
	{
		static void Main(string[] args)
		{
			//Find the longest increasing sequence of consecutive elements in array
			Console.WriteLine("Size of the array = ");
			int n = int.Parse(Console.ReadLine());
			int[] arr = new int[n];
			Console.WriteLine("Enter the array");
			for (int i = 0; i < n; i++)
			{
				arr[i] = int.Parse(Console.ReadLine());
			}
			int maxLength = 1, currentLength = 1, startIndex = 0;
			for (int i = 1; i < n; i++)
			{
				if (arr[i] > arr[i - 1])
				{
					currentLength++;
				}
				else
				{
					if (maxLength < currentLength)
					{
						maxLength = currentLength;
						startIndex = i - currentLength;
					}
					currentLength = 1;
				}
			}
			Console.Write("Length of the sequence {0} starting from index {1} Sequence ->", maxLength, startIndex);
			for (int i = startIndex; i < startIndex + maxLength; i++)
			{
				Console.Write(arr[i] + ", ");
			}
		}
	}
}
