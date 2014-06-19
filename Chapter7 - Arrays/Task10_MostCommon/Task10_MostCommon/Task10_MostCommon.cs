using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10_MostCommon
{
	class Task10_MostCommon
	{
		static KeyValuePair<int, int> MostCommonPositive(int[] array)
		{
			//Works only for positive numbers
			int[] times = new int[array.Length];
			int mostCommon = 0, count = 0;
			for (int i = 0; i < array.Length; i++)
			{
				times[array[i]]++;
				if (times[array[i]] > count)
				{
					mostCommon = array[i];
					count = times[array[i]];
				}
			}

			return new KeyValuePair<int, int>(mostCommon, count);
		}
		static KeyValuePair<int, int> MostCommon(int[] array)
		{
			Array.Sort(array);
			int mostCommon = array[0], maxCount = 1;
			for (int i = 1; i < array.Length; i++)
			{
				int currentCount = 1;
				while (array[i] == array[i - 1])
				{
					currentCount++;
					i++;
				}
				if (currentCount > maxCount)
				{
					maxCount = currentCount;
					mostCommon = array[i - 1];
				}
			}
			return new KeyValuePair<int,int>(mostCommon, maxCount);
		}
		static void Main(string[] args)
		{
			//Task: Find the most common element in array
			Console.WriteLine("Length of the array");
			int n = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter the array");
			int[] array = new int[n];
			for (int i = 0; i < n; i++)
			{
				array[i] = int.Parse(Console.ReadLine());
			}
			KeyValuePair<int, int> mostCommonElement = MostCommon(array);
			Console.WriteLine("The most common element is {0} matched {1} times", mostCommonElement.Key, mostCommonElement.Value);
		}
	}
}
