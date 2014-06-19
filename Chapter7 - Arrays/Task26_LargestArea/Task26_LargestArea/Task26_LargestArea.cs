using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task26_LargestArea
{
	class Task26_LargestArea
	{
		static int count = 0;
		static void BFS(int[,] matrix, int i, int j)
		{
			int element = matrix[i, j];
			//Console.WriteLine(i + " " + j + " " + element);
			matrix[i, j] = int.MinValue;
			count++;
			if (i > 0 && matrix[i - 1, j] == element)
			{
				BFS(matrix, i - 1, j);
			}
			if (j > 0 && matrix[i, j - 1] == element)
			{
				BFS(matrix, i, j - 1);
			}
			if (i < matrix.GetLength(0) - 1 && matrix[i + 1, j] == element)
			{
				BFS(matrix, i + 1, j);
			}
			if (j < matrix.GetLength(1) - 1 && matrix[i, j + 1] == element)
			{
				BFS(matrix, i, j + 1);
			}
		}
		static int IterateMatrix(int[,] matrix)
		{
			int maxCount = 0;
			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					count = 0;
					if (matrix[i, j] != int.MinValue)
					{
						//Console.WriteLine("-------------------");
						BFS(matrix, i, j);
						if (count > maxCount)
						{
							maxCount = count;
						}
					}
				}
			}
			return maxCount;
		}
		static void Main(string[] args)
		{
			//Task: Find the largest area in matrix sustained of equal elements
			Console.WriteLine("Enter rows and columns");
			int n, m;
			n = int.Parse(Console.ReadLine());
			m = int.Parse(Console.ReadLine());
			int[,] matrix = new int[n, m];
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < m; j++)
				{
					matrix[i, j] = int.Parse(Console.ReadLine());
				}
			}
			Console.WriteLine( IterateMatrix(matrix) );
		}
	}
}
