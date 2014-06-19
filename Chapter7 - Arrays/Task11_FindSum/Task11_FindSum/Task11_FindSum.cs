using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11_FindSum
{
	class Task11_FindSum
	{
		static int GetStartIndex(int[] array, int sum)
		{
			int startIndex = int.MinValue;
			for (int i = 0; i < array.Length; i++)
			{
				int currentSum = 0;
				for (int j = i; j < array.Length && currentSum < sum; j++)
				{
					currentSum += array[j];
				}
				if (currentSum == sum)
				{
					startIndex = i;
					break;
				}
			}
			return startIndex;
		}
		static void PrintElements(int[] array, int sum, int startIndex)
		{
			int currentSum = 0;
			for (int i = startIndex; currentSum != sum; i++)
			{
				Console.Write(array[i] + " ");
				currentSum += array[i];
			}
		}
		static void Main(string[] args)
		{
			//Task: Find sequence of consecutive elements that give a sum
			int n, sum; 
			Console.WriteLine("Enter array size");
			n = int.Parse(Console.ReadLine());
			int[] array = new int[n];
			Console.WriteLine("Enter the array");
			for (int i = 0; i < n; i++)
			{
				array[i] = int.Parse(Console.ReadLine());
			}
			Console.WriteLine("Enter sum");
			sum = int.Parse(Console.ReadLine());
			int startIndex = GetStartIndex(array, sum);
			if (startIndex == int.MinValue)
			{
				Console.WriteLine("There are no consecutive elements that sum up to {0}", sum);
			}
			else
			{
				Console.Write("Elements that sum up to {0} are ", sum);
				PrintElements(array, sum, startIndex);
			}
		}
	}
}
