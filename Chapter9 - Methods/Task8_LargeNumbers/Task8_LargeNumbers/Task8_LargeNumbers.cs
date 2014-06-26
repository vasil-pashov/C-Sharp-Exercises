using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8_LargeNumbers
{
	class Task8_LargeNumbers
	{
		static int[] ConvertToArray(string stringNumber)
		{
			int[] arrayNumber = new int[stringNumber.Length];
			for (int i = stringNumber.Length - 1; i >= 0; i--)
			{
				if (Char.IsDigit(stringNumber[i]))
				{
					arrayNumber[stringNumber.Length - i - 1] = stringNumber[i] - '0';
				}
				else
				{
					throw new Exception("Input is not valid number");
				}
			}
			return arrayNumber;
		}
		static int[] SumLongNumbers(int[] first, int[] second)
		{
			int largerLength = first.Length > second.Length ? first.Length : second.Length;
			int[] result = new int[largerLength + 1];
			int toAdd = 0, currentSum = 0;
			for (int i = 0; i < largerLength; i++)
			{
				currentSum = 0;
				if (first.Length > i)
				{
					currentSum += first[i];
				}
				if (second.Length > i)
				{
					currentSum += second[i];
				}
				currentSum += toAdd;
				result[i] = currentSum % 10;
				toAdd = currentSum > 9 ? 1 : 0;
			}
			if (toAdd != 0)
			{
				result[largerLength] = toAdd;
			}
			return result;
		}
		static void PrintLongNumber(int[] number)
		{
			int startIndex = number.Length - 1;
			while (number[startIndex] == 0)
			{
				startIndex--;
			}
			for (int i = startIndex; i >= 0; i--)
			{
				Console.Write(number[i]);
			}
			Console.WriteLine();
		}
		static void Main(string[] args)
		{
			//Task: Write method that finds the sum of two numbers represented as array of its digis. The last digit is with index 0
			string a, b;
			Console.WriteLine("Enter first number");
			a = Console.ReadLine();
			Console.WriteLine("Enter second number");
			b = Console.ReadLine();
			int[] fistNumber = ConvertToArray(a), secondNumber = ConvertToArray(b), sum = SumLongNumbers(fistNumber, secondNumber);
			PrintLongNumber(sum);

		}
	}
}
