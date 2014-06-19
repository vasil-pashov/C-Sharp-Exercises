using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12_PrintMatrixes
{
	class Task12_PrintMatrices
	{
		static void PrintMatrix(int[,] matrix)
		{
			for (int i = 0; i <  matrix.GetLength(0); i++)
			{
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					Console.Write("{0, -3}", matrix[i, j]);
				}
				Console.WriteLine();
			}
		}
		static void A(int n)
		{
			int[,] matrix = new int[n, n];
			int value = 1;
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					matrix[j, i] = value;
					value++;
				}
			}
			PrintMatrix(matrix);
		}
		static void B(int n)
		{
			int[,] matrix = new int[n, n];
			int value = 1;
			for (int i = 0; i < n; i++)
			{
				if (i % 2 == 0)
				{
					for (int j = 0; j < n; j++)
					{
						matrix[j, i] = value;
						value++;
					}
				}
				else
				{
					for (int j = n - 1; j >= 0; j--)
					{
						matrix[j, i] = value;
						value++;
					}
				}
			}
			PrintMatrix(matrix);
		}
		static void C(int n)
		{
			int[,] matrix = new int[n, n];
			//lower triangle
			matrix[n - 1, 0] = 1;
			int addValue = 1, startAdd = 2, upperAdd = n;
			for (int i = n - 2; i >= 0; i--)
			{
				matrix[i, 0] = matrix[i + 1, 0] + addValue;
				addValue++;
			}
			for (int i = n - 1; i >= 0; i--)
			{
				addValue = startAdd;
				startAdd++;
				for (int j = 1; j < n; j++)
				{
					if (j <= i)
					{
						matrix[i, j] = matrix[i, j - 1] + addValue;
						addValue++;
					}
					else
					{
							matrix[i, j] = matrix[i, j - 1] + upperAdd;
							upperAdd--;
					}
				}
				upperAdd = n;
			}
			PrintMatrix(matrix);
		}
		static void D(int n)
		{
			int[,] matrix = new int[n, n];
			int value = 1, i = 0, j = 0;
			while (value <= n * n)
			{
				while (i < n && matrix[i, j] == 0)
				{
					matrix[i, j] = value;
					value++;
					i++;
				}
				i--;
				j++;
				while (j < n && matrix[i, j] == 0)
				{
					matrix[i, j] = value;
					value++;
					j++;
				}
				j--;
				i--;
				while (i >= 0 && matrix[i, j] == 0)
				{
					matrix[i, j] = value;
					value++;
					i--;
				}
				i++;
				j--;
				while (j >= 0 && matrix[i, j] == 0)
				{
					matrix[i, j] = value;
					value++;
					j--;
				}
				i++;
				j++;
			}
			PrintMatrix(matrix);

		}
		static void Main(string[] args)
		{
			/*Task print matrices such as those below
		a)
			 1  5  9  13
			 2  6  10 14
			 3  7  11 15
			 4  8  12 16
		b) 
			 1  8  9   16
			 2  7  10  15
			 3  6  11  14
			 4  5  12  13
		 c)
			 7  11  14  16
			 4  8   12  15
			 2  5   9   13
			 1  3   6   10
		 d)*
			 1  12  11  10
			 2  13  16  9
			 3  14  15  8
			 4  5   6   7
			 */
			//A(4);
			//B(4);
			//C(4);
			//D(4);
		}
	}
}
