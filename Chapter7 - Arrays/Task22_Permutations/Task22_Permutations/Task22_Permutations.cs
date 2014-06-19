using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task22_Permutations
{
	class Task22_Permutations
	{
		static int[] permutation = new int[100], used = new int[100];
		static void PrintPermutations(int n, int index)
		{
			if (index == n )
			{
				for (int i = 0; i < n; i++)
				{
					Console.Write(permutation[i] + " ");
				}
				Console.WriteLine();
				return;
			}
			for (int i = 1; i <= n; i++)
			{
				if (used[i] == 0)
				{
					used[i] = 1;
					permutation[index] = i;
					PrintPermutations(n, index + 1);
					used[i] = 0;
				}
			}
		}
		static void Main(string[] args)
		{
			//Task: Print all permutations to from 1 to N
			Console.WriteLine("Enter N");
			int n = int.Parse(Console.ReadLine());
			PrintPermutations(n, 0);
		}
	}
}
