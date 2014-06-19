using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_LexicographicalOrder
{
	class Task3_LexicographicalOrder
	{
		static char[] CaseInsensitiveCompare(char[] arr1, char[] arr2)
		{
			int minLength = arr1.Length < arr2.Length ? arr1.Length : arr2.Length;
			char[] result = arr1.Length < arr2.Length ? arr1 : arr2;
			for (int i = 0; i < minLength; i++)
			{
				if (Char.ToLower(arr1[i]) < Char.ToLower(arr2[i]))
				{
					result = arr1;
				}
			}
			return result;
		}
		static char[] CaseSensitiveCompare(char[] arr1, char[] arr2)
		{
			int minLength = arr1.Length < arr2.Length ? arr1.Length : arr2.Length;
			char[] result = arr1.Length < arr2.Length ? arr1 : arr2;
			for (int i = 0; i < minLength; i++)
			{
				if (arr1[i] < arr2[i])
				{
					result = arr1;
				}
			}
			return result;
		}
		static void Main(string[] args)
		{
			//Task: Compare two char arrays lexicographically
			int n, m;
			Console.WriteLine("Length of the first array = ");
			n = int.Parse(Console.ReadLine());
			char[] arr = new char[n];
			Console.WriteLine("Enter the first array");
			for (int i = 0; i < n; i++)
			{
				arr[i] = char.Parse(Console.ReadLine());
			}
			Console.WriteLine("Length of the second array = ");
			m = int.Parse(Console.ReadLine());
			char[] arr2 = new char[m];
			Console.WriteLine("Enter the second array");
			for (int i = 0; i < m; i++)
			{
				arr2[i] = char.Parse(Console.ReadLine());
			}
			char[] caseSensitiveCompareResult = CaseSensitiveCompare(arr, arr2);
			char[] caseInsensitiveCompareResult = CaseInsensitiveCompare(arr, arr2);
			Console.WriteLine("Case insensitive compare result");
			for (int i = 0; i < caseInsensitiveCompareResult.Length; i++)
			{
				Console.WriteLine(caseInsensitiveCompareResult[i]);
			}
			Console.WriteLine("Case sensitive compare result");
			for (int i = 0; i < caseSensitiveCompareResult.Length; i++)
			{
				Console.WriteLine(caseSensitiveCompareResult[i]);
			}
		}
	}
}
