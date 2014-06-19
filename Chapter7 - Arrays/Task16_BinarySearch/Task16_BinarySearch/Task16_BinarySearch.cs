using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task16_BinarySearch
{
	class Task16_BinarySearch
	{
		static int BinarySearch(int[] arr, int item)
		{
			int index = -1, start = 0, end = arr.Length, mid = (start + end) / 2;
			while (start != mid)
			{
				if (arr[mid] == item)
				{
					return mid;
				}
				if (item < arr[mid])
				{
					end = mid;
				}
				else
				{
					start = mid;
				}
				mid = (start + end) / 2;
			}
			return index;
		}
		static void Main(string[] args)
		{
			//Task: Implement binary search
			Console.WriteLine("Enter the size of the array");
			int n = int.Parse(Console.ReadLine());
			int[] arr = new int[n];
			Console.WriteLine("Enter the array");
			for (int i = 0; i < n; i++)
			{
				arr[i] = int.Parse(Console.ReadLine());
			}
			//Array must be sorted
			Array.Sort(arr);
			int binarySearchIndex = BinarySearch(arr, 71);
			if (binarySearchIndex == -1)
			{
				Console.WriteLine("NO such element in the array.");
			}
			else
			{
				Console.WriteLine("The element index is {0}", binarySearchIndex);
			}
		}
	}
}
