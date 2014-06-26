using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_NumberOccurrence
{
	class Task4_NumberOccurrence
	{
		static int CountNumberOccurrences(int[] array, int number)
		{
			int occurrences = 0;
			foreach (int element in array)
			{
				if (element == number)
				{
					occurrences++;
				}
			}
			return occurrences;
		}
		static void Main(string[] args)
		{
			//Task: Write method that returns the occurrences of a number in array
			Console.WriteLine("Enter array size");
			int n, number;
			n = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter array");
			int[] array = new int[n];
			for (int i = 0; i < n; i++)
			{
				array[i] = int.Parse(Console.ReadLine());
			}
			Console.WriteLine("Enter the number to check");
			number = int.Parse(Console.ReadLine());
			Console.WriteLine("The array contains number {0} {1} times", number, CountNumberOccurrences(array, number));
		}
	}
}
