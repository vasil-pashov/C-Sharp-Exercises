using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task23_Variations
{
	class Task23_Variations
	{
		static int[] variations = new int[100];
		static void PirntVariations(int n, int k, int index)
		{
			if (index == k)
			{
				for(int i = 0; i < k; i++)
				{
					Console.Write(variations[i] + " ");
				}
				Console.WriteLine();
				return;
			}
			for (int i = 1; i <= n; i++)
			{
				variations[index] = i;
				PirntVariations(n, k, index + 1);
			}
		}
		static void Main(string[] args)
		{
			//Task: Read N and K print all variations of K elements [1; N]
			Console.WriteLine("Enter N and K");
			int n, k;
			n = int.Parse(Console.ReadLine());
			k = int.Parse(Console.ReadLine());
			PirntVariations(n, k, 0);
		}
	}
}
