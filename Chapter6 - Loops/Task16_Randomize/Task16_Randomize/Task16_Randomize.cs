using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task16_Randomize
{
	class Task16_Randomize
	{
		static void Swap(ref int a, ref int b)
		{
			a ^= b;
			b ^= a;
			a ^= b;
		}
		static void Main(string[] args)
		{
			//Task: Print the numbers form 1 to n in random order
			int n = int.Parse(Console.ReadLine());
			int[] numbers = new int[n + 1];
			for (int i = 1; i <= n; i++)
			{
				numbers[i] = i;
			}
			Random rnd = new Random(new DateTime().Millisecond);
			for (int i = 1; i <= n; i++)
			{
				Swap(ref numbers[rnd.Next(0, n + 1)], ref numbers[rnd.Next(0, n + 1)]);
			}
			for (int i = 1; i <= n; i++)
			{
				Console.WriteLine(numbers[i]);
			}
		}
	}
}
