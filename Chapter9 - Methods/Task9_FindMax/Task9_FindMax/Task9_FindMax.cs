using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9_FindMax
{
	class Task9_FindMax
	{
		static int FindMaxIndex(int[] array, int from, int to)
		{
			int max = array[from], index = from;
			for (int i = from + 1; i <= to; i++)
			{
				if (max < array[i])
				{
					max = array[i];
					index = i;
				}
			}
			return index;
		}
		static void Swap(int[] array, int index1, int index2)
		{
			int temp = array[index1];
			array[index1] = array[index2];
			array[index2] = temp;
		}
		static void SortDescending(int[] array)
		{
			for (int i = 0; i < array.Length; i++)
			{
				int maxIndex = FindMaxIndex(array, i, array.Length - 1);
				Swap(array, i, maxIndex);
			}
		}
		static void SortAscending(int[] array)
		{
			for (int i = array.Length - 1; i >= 0; i--)
			{
				int maxIndex = FindMaxIndex(array, 0, i);
				Swap(array, i, maxIndex);
			}
		}
		static void PrintArray(int[] array)
		{
			foreach (int element in array)
			{
				Console.Write(element + " ");
			}
			Console.WriteLine();
		}
		static void Main(string[] args)
		{
			//Task: Write method that finds the largest element of an array is some range. Use it to create sorting function.
			Console.WriteLine("Enter array size");
			int n = int.Parse(Console.ReadLine());
			int[] array = new int[n];
			Console.WriteLine("Enter array");
			for (int i = 0; i < n; i++)
			{
				array[i] = int.Parse(Console.ReadLine());
			}
			SortAscending(array);
			PrintArray(array);
			SortDescending(array);
			PrintArray(array);
		}
	}
}
