using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_AreIdentical
{
	class Task2_AreIdentical
	{
		static void Main(string[] args)
		{
			//Task: Read two arrays and check if they are identical
			Console.WriteLine("Input the lengths of the arrays then the arrays.");
			int n, m;
			n = int.Parse(Console.ReadLine());
			m = int.Parse(Console.ReadLine());
			if (m != n)
			{
				Console.WriteLine("Arrays have different lenght.");
			}
			else
			{
				int[] arr1, arr2;
				arr1 = new int[n];
				arr2 = new int[m];
				for (int i = 0; i < n; i++)
				{
					arr1[i] = int.Parse(Console.ReadLine());
				}
				for (int i = 0; i < m; i++)
				{
					arr2[i] = int.Parse(Console.ReadLine());
				}
				bool identical = true;
				for(int i = 0; i < arr1.Length; i++)
				{
					if (arr1[i] != arr2[i])
					{
						identical = false;
						break;
					}
				}
				if (identical)
				{
					Console.WriteLine("Arrays are identical.");
				}
				else
				{
					Console.WriteLine("Arrays are different.");
				}
			}
		}
	}
}
