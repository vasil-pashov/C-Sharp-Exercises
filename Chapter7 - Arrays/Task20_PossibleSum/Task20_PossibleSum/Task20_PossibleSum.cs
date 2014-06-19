using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task20_PossibleSum
{
	class Task20_PossibleSum
	{
		static void PrintElements(int[] pred, int sum)
		{
			Console.WriteLine(sum + " " + pred[sum]);
		}
		static bool IsPosibleSum(int[] arr, int sum)
		{
			int maxSum = 0;
			for (int i = 0; i < arr.Length; i++)
			{
				maxSum += arr[i];
			}
			Array.Sort(arr);
			int[] possibleSums = new int[maxSum + 1];
			possibleSums[maxSum] = 1;
			for (int i = 0; i < arr.Length; i++)
			{
				int element = arr[i], range = maxSum - element;
				for (int j = maxSum; j > range; j--)
				{
					if (possibleSums[j] == 1 && j - element >= 0)
					{
						possibleSums[j - element] = 1;
						if (j - element == sum)
						{
							return true;
						}
					}
				}
			}
			return false;
		}
		static void Main(string[] args)
		{
			//Task: Enter N positive numbers and Sum. Print the elements that give this sum or print that its impossible.
			Console.WriteLine("Enter size of the array");
			int n, sum;
			n = int.Parse(Console.ReadLine());
			int[] arr = new int[n];
			Console.WriteLine("Enter array");
			for (int i = 0; i < n; i++)
			{
				arr[i] = int.Parse(Console.ReadLine());
			}
			Console.WriteLine("Enter sum");
			sum = int.Parse(Console.ReadLine());
			Console.WriteLine(IsPosibleSum(arr, sum) == true? "Possible":"Impossible");
		}
	}
}
