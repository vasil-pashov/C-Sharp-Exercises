using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17_MergeSort
{
	class Task17_MergeSort
	{
		static void Merge(int[] inital, int[] result, int start, int end)
		{
			int mid = (start + end) / 2, leftPtr = start, rightPtr = mid, index = start;
			while (leftPtr < mid && rightPtr < end)
			{
				//Console.WriteLine("Start {0} End {1} LeftPtr {2} RiightPtr {3}", start, end, leftPtr, rightPtr);

				if (inital[leftPtr] <= inital[rightPtr])
				{
					result[index] = inital[leftPtr];
					leftPtr++;
				}
				else
				{
					result[index] = inital[rightPtr];
					rightPtr++;
				}
				index++;
			}
			while (leftPtr < mid)
			{
				result[index] = inital[leftPtr];
				leftPtr++;
				index++;
			}
			while (rightPtr < end)
			{
				result[index] = inital[rightPtr];
				rightPtr++;
				index++;
			}
			for (int i = start; i < end; i++)
			{
				//Console.Write(result[i] + " ");
				inital[i] = result[i];
			}
		}
		static void MergeSort(int[] initial, int[] result, int start, int end)
		{
			if (end - 2 < start)
			{
				return;
			}
			int mid = (start + end) / 2;
			
			MergeSort(initial, result, start, mid);
			MergeSort(initial, result, mid, end);
			Merge(initial, result, start, end);
		}
		static void Main(string[] args)
		{
			//Task: Write Merge Sort
			Console.WriteLine("Enter size of the array");
			int n = int.Parse(Console.ReadLine());
			int[] arr = new int[n];
			Console.WriteLine("Enter the array");
			for (int i = 0; i < n; i++)
			{
				arr[i] = int.Parse(Console.ReadLine());
			}
			int[] result = new int[n];
			MergeSort(arr, result, 0, arr.Length);
			for (int i = 0; i < arr.Length; i++)
			{
				Console.Write("{0} ", arr[i]);
			}
		}
	}
}
