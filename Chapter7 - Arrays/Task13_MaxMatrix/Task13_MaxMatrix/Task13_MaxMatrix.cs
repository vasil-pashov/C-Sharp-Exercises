using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13_MaxMatrix
{
	class Task13_MaxMatrix
	{
		static int GetSubmatrixValue(int[,] matrix, int i, int j, int subN, int subM)
		{
			int submatrixValue = 0;
			for (int p = i; p < i + 3; p++)
			{
				for (int q = j; q < j + 3; q++)
				{
					submatrixValue += matrix[p, q];
				}
			}
			return submatrixValue;
		}
		static void Main(string[] args)
		{
			//Task: Find the max submatrix 3x3 of a matrix N x M
			Console.WriteLine("Enter rows and cols");
			int n, m;
			n = int.Parse(Console.ReadLine());
			m = int.Parse(Console.ReadLine());
			int[,] matrix = new int[n,m];
			Console.WriteLine("Enter matrix");
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < m; j++)
				{
					matrix[i, j] = int.Parse(Console.ReadLine());
				}
			}
			int maxSum = int.MinValue, maxI = 0, maxJ = 0;
			for (int i = 0; i < matrix.GetLength(0) - 2; i++)
			{
				for (int j = 0; j < matrix.GetLength(1) - 2; j++)
				{
					//Console.WriteLine(i + " " + j );
					int subMatrixValue = GetSubmatrixValue(matrix, i, j, 3, 3);
					if (subMatrixValue > maxSum)
					{
						maxSum = subMatrixValue;
						maxI = i;
						maxJ = j;
					}
				}
			}
			Console.WriteLine("The matrix is");
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < m; j++)
					Console.Write("{0, -4}",matrix[i, j]);
				Console.WriteLine();
			}
			Console.WriteLine("The max submatrix value is {0}. Starting from [{1}; {2}]", maxSum, maxI, maxJ);
		}
	}
}
