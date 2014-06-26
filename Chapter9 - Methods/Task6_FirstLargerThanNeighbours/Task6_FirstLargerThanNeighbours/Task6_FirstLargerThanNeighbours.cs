using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_FirstLargerThanNeighbours
{
	class Task6_FirstLargerThanNeighbours
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
		static int FindFirstLargerThanNeighbours(int[] array)
		{
			for (int i = 0; i < array.Length; i++)
			{
				if (CheckIsLargerThanNeighbours(array, i))
				{
					return i;
				}
			}
			return -1;
		}
		static void Main(string[] args)
		{
			//Task: Find the first element which is larger than its left and right neighbours in array
			int n;
			Console.WriteLine("Enter array size");
			n = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter array");
			int[] array = new int[n];
			for(int i = 0; i < n; i++)
			{
				array[i] = int.Parse(Console.ReadLine());
			}
			int index = FindFirstLargerThanNeighbours(array);
			if (index == -1)
			{
				Console.WriteLine("There is no element that is larger than both of its neighbours");
			}
			else
			{
				Console.WriteLine("The index of the element is {0}", index);
			}
		}
	}
}
