using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8_SelectionSort
{
	class Task8_SelectionSort
	{
		static void SwapArrayElements(int[] array, int pos1, int pos2)
		{
			array[pos1] ^= array[pos2];
			array[pos2] ^= array[pos1];
			array[pos1] ^= array[pos2];
		}
		static int[] SelectionSort(int[] array)
		{
			for (int i = 0; i < array.Length - 1; i++)
			{
				int currentMinValue = array[i], currentMinPos = i;
				for (int j = i + 1; j < array.Length; j++)
				{
					if (array[j] < currentMinValue)
					{
						currentMinValue = array[j];
						currentMinPos = j;
					}
				}
				if (currentMinValue < array[i])
				{
					SwapArrayElements(array, i, currentMinPos);
				}
			}
			return array;
		}
		static void Main(string[] args)
		{
			//Task: Write SelectionSort
			Console.WriteLine("Array length = ");
			int n = int.Parse(Console.ReadLine());
			int[] array = new int[n];
			Console.WriteLine("Input the array");
			for (int i = 0; i < n; i++)
			{
				array[i] = int.Parse(Console.ReadLine());
			}
			array = SelectionSort(array);
			Console.WriteLine("Sorted array");
			foreach (int element in array)
			{
				Console.Write(element + " ");
			}
		}
	}
}
