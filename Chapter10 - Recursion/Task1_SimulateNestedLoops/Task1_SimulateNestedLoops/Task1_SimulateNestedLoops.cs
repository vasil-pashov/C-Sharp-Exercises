using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_SimulateNestedLoops
{
	class Task1_SimulateNestedLoops
	{
		static void PrintArray(int[] arr)
		{
			foreach (int element in arr)
			{
				Console.Write(element + " ");
			}
		}
		static void SimulateNestedLoops(int[] arr, int position)
		{
			if (position == arr.Length)
			{
				PrintArray(arr);
				Console.WriteLine();
				return;
			}
			for (int i = 1; i <= arr.Length; i++)
			{
				arr[position] = i;
				SimulateNestedLoops(arr, position + 1);
			}
		}
		static void Main(string[] args)
		{
			//Task: Write recursive method that acts live n nested loops
			Console.WriteLine("Enter n");
			int n = int.Parse(Console.ReadLine());
			int[] arr = new int[n];
			SimulateNestedLoops(arr, 0);
		}
	}
}
