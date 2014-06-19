using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task25_Matrices
{
	class Task25_Matrices
	{
		static void PrintFirst(int n)
		{
			int[,] matrix = new int[n, n];
			int value = 1;
			for (int j = n - 1; j >= 0; j--)
			{
				int rowIndex = n - 1, colIndex = j;
				while (rowIndex >= 0 && colIndex < n)
				{
					matrix[rowIndex, colIndex] = value;
					rowIndex--;
					colIndex++;
					value++;
				}
				if (j == 0)
				{
					for (int i = n - 2; i >= 0; i--)
					{
						rowIndex = i;
						colIndex = 0;
						while (rowIndex >= 0 && colIndex < n)
						{
							matrix[rowIndex, colIndex] = value;
							rowIndex--;
							colIndex++;
							value++;
						}
					}
				}
			}
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					Console.Write("{0, 3}", matrix[i, j]);
				}
				Console.WriteLine();
			}
		}
		static void PrintSecond(int n)
		{
			int[,] matrix = new int[n, n];
			int value = 1;
			for (int i = n - 1; i >= 0; i--)
			{
				int colIndex = 0, rowIndex = i;
				while (colIndex < n && rowIndex < n)
				{
					matrix[rowIndex, colIndex] = value;
					rowIndex++;
					colIndex++;
					value++;
				}
				if (i == 0)
				{
					for (int j = 1; j < n; j++)
					{
						rowIndex = 0;
						colIndex = j;
						while(rowIndex < n && colIndex < n)
						{
							matrix[rowIndex, colIndex] = value;
							colIndex++;
							rowIndex++;
							value++;
						}
					}
				}
			}
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					Console.Write("{0, 3}", matrix[i, j]);
				}
				Console.WriteLine();
			}
			
		}
		static void Main(string[] args)
		{
			//Task: Pass trough elements of matrix like below
			/*
			 * 16  15  13  10
			 * 14  12  9   6
			 * 11  8   5   3
			 * 7   4   2   1
			 * 
			 * and
			 * 
			 * 7  11  14  16
			 * 4  8   12  15
			 * 2  5   9   13
			 * 1  3   6   10
			 */
			PrintFirst(4);
			Console.WriteLine();
			PrintSecond(4);
		}
	}
}
