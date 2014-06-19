using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_SequenceOfEqual
{
	class Task4_SequenceOfEqual
	{
		static void Main(string[] args)
		{
			//Task: Find the longes sequence of equal elements in array
			Console.WriteLine("Array size = ");
			int n = int.Parse(Console.ReadLine());
			Console.WriteLine("Input Array");
			int[] arr = new int[n];
			for (int i = 0; i < n; i++)
			{
				arr[i] = int.Parse(Console.ReadLine());
			}
			int maxLenght = 1, currentLength = 1, startIndex = 0;
			for (int i = 1; i < n; i++)
			{
				int prevElement = arr[i - 1], currentElement = arr[i];
				if (prevElement == currentElement)
				{
					currentLength++;
				}
				else
				{
					if (currentLength > maxLenght)
					{
						startIndex = i - currentLength;
						maxLenght = currentLength;
					}
					currentLength = 1;
				}
			}
			Console.Write("Length = {0} index = {1} Elements -> ", maxLenght, startIndex);
			for (int i = startIndex; i < startIndex + maxLenght; i++)
			{
				Console.Write(arr[i] + ", ");
			}
		}
	}
}
