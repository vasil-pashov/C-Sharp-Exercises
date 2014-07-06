using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8_SubsetSum
{
	class Task8_SubsetSum
	{
		static int[] subset;
		static void FindSubsets(int[] elements, int sum, int currentSum, int currentElementIndex, int subsetIndex)
		{
			if (currentSum == sum)
			{
				for (int i = 0; i < subsetIndex; i++)
				{
					Console.Write(subset[i] + " ");
				}
				Console.WriteLine();
				return;
			}
			for (int i = currentElementIndex; i < elements.Length; i++)
			{
				subset[subsetIndex] = elements[i];
				FindSubsets(elements, sum, currentSum + elements[i], i + 1, subsetIndex + 1);
			}
		}
		static void Main(string[] args)
		{
			//Task: Display all subsets that have sum = sum
			int sum, n;
			Console.WriteLine("Enter sum");
			sum = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter array size");
			n = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter array elements");
			int[] elements = new int[n];
			subset = new int[n];
			for (int i = 0; i < n; i++)
			{
				elements[i] = int.Parse(Console.ReadLine());
			}
			FindSubsets(elements, sum, 0, 0, 0);
		}
	}
}
