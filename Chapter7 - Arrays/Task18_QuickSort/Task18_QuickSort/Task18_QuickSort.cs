using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task18_QuickSort
{
	class Task18_QuickSort
	{
		static void Swap(int[] arr, int pos1, int pos2)
		{
			int temp = arr[pos1];
			arr[pos1] = arr[pos2];
			arr[pos2] = temp;
		}
		static int Align(int[] arr, int start, int end)
		{
			int mid = (start + end) / 2, leftIndex = start, rightIndex = end, pivot = arr[mid];
			while (rightIndex > leftIndex)
			{
				while (leftIndex < end && arr[leftIndex] < pivot)
				{
					leftIndex++;
				}
				while (rightIndex > start && arr[rightIndex] > pivot)
				{
					rightIndex--;
				}
				Swap(arr, leftIndex, rightIndex);
				while(arr[leftIndex] == arr[rightIndex] && rightIndex > start)
				{
					rightIndex--;
				}
			}
			return leftIndex;
		}
		static void QuickSort(int[] arr, int start, int end)
		{
			if (start >= end)
				return;
			int mid = Align(arr, start, end);
			QuickSort(arr, start, mid);
			QuickSort(arr, mid + 1, end);
		}
		static void Main(string[] args)
		{
			//Task: Write quick sort
			Console.WriteLine("Enter the length of the array");
			int n = int.Parse(Console.ReadLine());
			int[] arr = new int[n];
			Console.WriteLine("Enter array");
			for (int i = 0; i < n; i++)
			{
				arr[i] = int.Parse(Console.ReadLine());
			}
			QuickSort(arr, 0, n - 1);
			foreach (int el in arr)
			{
				Console.Write(el + " ");
			}
		}
	}
}
