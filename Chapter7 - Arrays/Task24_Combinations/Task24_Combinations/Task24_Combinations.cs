using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task24_Combinations
{
	class Task24_Combinations
	{
		static int[] combinations = new int[100], used = new int[100];
		static void PrintCombinations(int n, int k, int index)
		{
			if (index == k)
			{
				for (int i = 0; i < index; i++)
				{
					Console.Write(combinations[i] + " ");
				}
				Console.WriteLine();
				return;
			}
			for (int i = 1; i <= n; i++)
			{
				if (index > 0 && combinations[index - 1] >= i)
				{
					continue;
				}
				if (used[i] == 0)
				{
					used[i] = 1;
					combinations[index] = i;
					PrintCombinations(n, k, index + 1);
					used[i] = 0;
				}
			}
		}
		static void Main(string[] args)
		{
			//Task: Read N and K print all combinations of K elements
			Console.WriteLine("Eter N and K");
			int n, k;
			n = int.Parse(Console.ReadLine());
			k = int.Parse(Console.ReadLine());
			PrintCombinations(n, k, 0);
		}
	}
}
