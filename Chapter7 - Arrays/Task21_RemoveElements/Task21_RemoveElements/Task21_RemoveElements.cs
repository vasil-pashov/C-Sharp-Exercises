using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task21_RemoveElements
{
	class Task21_RemoveElements
	{
		static void FindLIS(int[] arr)
		{
			int[] d = new int[arr.Length], predicessor = new int[arr.Length];
			for (int i = 0; i < arr.Length; i++)
			{
				d[i] = 1;
			}
			for (int i = 0; i < arr.Length; i++)
			{
				for (int j = i - 1; j >= 0; j--)
				{
					if (arr[i] >= arr[j] && d[j] + 1 > d[i])
					{
						d[i] = d[j] + 1;
						predicessor[i] = j;
					}
				}
			}
			PrintSorted(arr, d, predicessor);
		}
		static void PrintSorted(int[] arr, int[] d,  int[] predicessor)
		{
			List<int> sorted = new List<int>();
			int maxLength = 1, index = 0;
			for (int i = 0; i < d.Length; i++)
			{
				if (d[i] > maxLength)
				{
					index = i;
					maxLength = d[i];
				}
			}
			Console.Write("Length of the sequence {0} sequence -> ", maxLength);
			sorted.Insert(0, arr[index]);
			while (predicessor[index] != 0)
			{
				sorted.Insert(0, arr[predicessor[index]]);
				index = predicessor[index];
			}
			foreach (int el in sorted)
			{
				Console.Write(el + " ");
			}
		}
		static void Main(string[] args)
		{
			//Task: Remove minimal amount of elements from the array to get sorted array. {6, 1, 4, 3, 0, 3, 6, 4, 5} -> {1, 3, 3, 4, 5}
			Console.WriteLine("The lenght of the array = ");
			int n;
			n = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter the array");
			int[] arr = new int[n];
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = int.Parse(Console.ReadLine());
			}
			FindLIS(arr);
		}
	}
}
