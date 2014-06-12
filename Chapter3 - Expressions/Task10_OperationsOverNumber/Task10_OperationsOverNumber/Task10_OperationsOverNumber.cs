using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10_OperationsOverNumber
{
	class Task10_OperationsOverNumber
	{
		static int SumDigits(int number)
		{
			int result = 0;
			while (number > 0)
			{
				result += number % 10;
				number /= 10;
			}
			return result;
		}
		public static int PrintRightToLeft(int number)
		{
			int result = 0;
			while (number > 0)
			{
				result *= 10;
				result += number % 10;
				number /= 10;
			}
			return result;
		}
		public static int PutLastDigitInFront(int number)
		{
			int digits = 0, temp = number, result = 1, lastDigit = number % 10;
			while (temp > 0)
			{
				digits++;
				result *= 10;
				temp /= 10;
			}
			result /= 10;
			result *= lastDigit;
			result += number / 10;
			return result;
			
		}
		public static int SwapSecondAndThirdDigit(int number)
		{
			int[] n = new int[100];
			int i = 0, result = 0;
			while (number > 0)
			{
				n[i] = number % 10;
				number /= 10;
				i++;
			}
			int temp = n[1];
			n[1] = n[2];
			n[2] = temp;
			for (int j = i - 1; j >= 0; j--)
			{
				result += n[j];
				result *= 10;
			}
			result /= 10;
			return result;
		}
		static void Main(string[] args)
		{
			//Task write function that sums the digit in a number, prins it from right to left, puts its last digit in front, swaps the third and the secind digit
			Console.WriteLine(SwapSecondAndThirdDigit(2011));
		}
	}
}
