using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_IsLargerThanNeighbours
{
	class Task5_IsLargerThanNeighbours
	{
		static bool CheckIsLargerThanNeighbours(int[] array, int position)
		{
			if (position < 0 || position >= array.Length)
			{
				throw new Exception("Invalid position");
			}
			bool isLargerThanLeft = true, isLargerThanRight = true;
			if (position > 0)
			{
				if (array[position] <= array[position - 1])
				{
					isLargerThanLeft = false;
				}
			}
			if (position < array.Length - 1)
			{
				if (array[position] <= array[position + 1])
				{
					isLargerThanRight = false;
				}
			}
			return isLargerThanLeft && isLargerThanRight;
		}
		static void Main(string[] args)
		{
			//Write method that checks if the number on given positiob is larger that the elements to the left and right of it
			Console.WriteLine("Enter array size");
			int n, position;
			n = int.Parse(Console.ReadLine());
			int[] array = new int[n];
			Console.WriteLine("Enter the array");
			for (int i = 0; i < n; i++)
			{
				array[i] = int.Parse(Console.ReadLine());
			}
			Console.WriteLine("Enter the position to check");
			position = int.Parse(Console.ReadLine());
			bool isLarger = CheckIsLargerThanNeighbours(array, position);
			Console.WriteLine("Is the element at position {0} larger than its neighbours {1}", position, isLarger);
		}
	}
}
