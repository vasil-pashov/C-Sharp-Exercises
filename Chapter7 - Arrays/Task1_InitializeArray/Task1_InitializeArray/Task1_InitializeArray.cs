using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_InitializeArray
{
	class Task1_InitializeArray
	{
		static void Main(string[] args)
		{
			//Task: Initialize array with 20 elements. Set each element to be its index multiplied by 5
			int[] arr = new int[20];
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = i * 5;
			}
			for (int i = 0; i < arr.Length; i++)
			{
				Console.WriteLine("Index: {0} value: {1}",i, arr[i]);
			}
		}
	}
}
