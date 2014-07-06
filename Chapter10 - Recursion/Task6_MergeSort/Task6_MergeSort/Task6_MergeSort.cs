using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_MergeSort
{
	class Task6_MergeSort
	{
		static int[] result;
		static void PrintArray(int[] array)
		{
			foreach (int element in array)
			{
				Console.Write(element + " ");
			}
			Console.WriteLine();
		}
		static void Merge(int[] initial, int left, int right)
		{
			int leftPtr = left, mid = (left + right) / 2, rightPtr = mid, index = left;
			while (leftPtr < mid && rightPtr < right)
			{
				if (initial[leftPtr] <= initial[rightPtr])
				{
					result[index] = initial[leftPtr];
					leftPtr++;
				}
				else
				{
					result[index] = initial[rightPtr];
					rightPtr++;
				}
				index++;
			}
			while (leftPtr < mid)
			{
				result[index] = initial[leftPtr];
				leftPtr++;
				index++;
			}
			while (rightPtr < right)
			{
				result[index] = initial[rightPtr];
				rightPtr++;
				index++;
			}
			for (int i = left; i < right; i++)
			{
				initial[i] = result[i];
			}
		}
		static void MergeSort(int[] array, int left, int right)
		{
			if (right - left < 2)
			{
				return;
			}
			int middle = (left + right) / 2;
			MergeSort(array, left, middle);
			MergeSort(array, middle, right);
			Merge(array, left, right);

		}
		static void Main(string[] args)
		{
			//Task: Write recursive implementation on merge sort
			Console.WriteLine("Enter array length");
			int n = int.Parse(Console.ReadLine());
			int[] array = new int[n];
			Console.WriteLine("Enter the array");
			for (int i = 0; i < n; i++)
			{
				array[i] = int.Parse(Console.ReadLine());
			}
			result = new int[n];
			MergeSort(array, 0, array.Length);
			PrintArray(array);
		}
	}
}
