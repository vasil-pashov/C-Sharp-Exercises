using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_Permutations
{
	class Task7_Permutations
	{
		static int[] permutations;
		static bool[] used;
		static void PrintArray(int[] array)
		{
			foreach (int element in array)
			{
				Console.Write(element + " ");
			}
			Console.WriteLine();
		}
		static void Permute(int position)
		{
			if (position == permutations.Length)
			{
				PrintArray(permutations);
				return;
			}
			for (int i = 1; i <= permutations.Length; i++)
			{
				if (used[i] == false)
				{
					used[i] = true;
					permutations[position] = i;
					Permute(position + 1);
					used[i] = false;
				}
			}
		}
		static void Main(string[] args)
		{
			//Task: Print all permutations of elements [1; n]
			Console.WriteLine("Enter n");
			int n = int.Parse(Console.ReadLine());
			permutations = new int[n];
			used = new bool[n + 1];
			Permute(0);
		}
	}
}
