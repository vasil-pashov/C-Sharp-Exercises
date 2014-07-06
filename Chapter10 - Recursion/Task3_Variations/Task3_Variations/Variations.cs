using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_Variations
{
	class Variations
	{
		static void PrintArray(int[] array)
		{
			foreach(int element in array)
			{
				Console.Write(element + " ");
			}
		}
		static void Variate(int[] elements, int position, int n)
		{
			if (position == elements.Length)
			{
				PrintArray(elements);
				Console.WriteLine();
				return;
			}
			for (int i = 1; i <= n; i++)
			{
				elements[position] = i;
				Variate(elements, position + 1, n);
			}
		}
		static void Main(string[] args)
		{
			//Task: Write recursive method that prints all variations of n elements k-th class
			int n, k;
			Console.WriteLine("Enter n");
			n = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter k");
			k = int.Parse(Console.ReadLine());
			int[] variations = new int[k];
			Variate(variations, 0, n);
		}
	}
}
