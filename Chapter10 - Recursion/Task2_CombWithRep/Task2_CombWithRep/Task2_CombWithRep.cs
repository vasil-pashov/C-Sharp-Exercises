using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_CombWithRep
{
	class Task2_CombWithRep
	{
		static void PrintArray(int[] array)
		{
			foreach (int element in array)
			{
				Console.Write(element + " ");
			}
		}
		static void CombineWithRepetition (int[] combinations, int position, int value, int n)
		{
			if (position == combinations.Length)
			{
				PrintArray(combinations);
				Console.WriteLine();
				return;
			}
			for (int i = value; i <= n; i++)
			{
				combinations[position] = i;
				CombineWithRepetition(combinations, position + 1, i, n);
			}
		}
		static void Main(string[] args)
		{
			//Task: Write recursve method that displays all posible combinations of n elements k-th class with repetition.
			int n, k;
			Console.WriteLine("Enter n");
			n = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter k");
			k = int.Parse(Console.ReadLine());
			int[] combinations = new int[k];
			CombineWithRepetition(combinations, 0, 1, n);
		}
	}
}
