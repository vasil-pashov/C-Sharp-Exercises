using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task18_Spiral
{
	class Task18_Spiral
	{
		static void Main(string[] args)
		{
			/*Task: Print numbers in spiral like this
			 * 1 2 3 4
			 * 12 13 14 5
			 * 11 16 15 6
			 * 10 9 8 7
			 */
			int n = int.Parse(Console.ReadLine());
			int[,] matrix = new int[n + 1, n + 1];
			int val = 1, i = 0, j = 0;
			while (val <= n * n)
			{
				for (; j < n; j++, val++)
				{
					if (matrix[i, j] == 0)
					{
						matrix[i, j] = val;
					}
					else
					{
						break;
					}
				}
				j--;
				i++;
				for (; i < n; i++, val++)
				{
					if (matrix[i, j] == 0)
					{
						matrix[i, j] = val;
					}
					else
					{
						break;
					}
				}
				i--;
				j--;
				for (; j >= 0; j--, val++)
				{
					if (matrix[i, j] == 0)
					{
						matrix[i, j] = val;
					}
					else
					{
						break;
					}
				}
				i--;
				j++;
				for (; i >= 0; i--, val++)
				{
					if (matrix[i, j] == 0)
					{
						matrix[i, j] = val;
					}
					else
					{
						break;
					}
				}
				j++;
				i++;
				//break;
			}

			for (int p = 0; p < n; p++)
			{
				for (int q = 0; q < n; q++)
				{
					Console.Write("{0,-6}", matrix[p,q]);
				}
				Console.WriteLine();
			}
		}
	}
}
