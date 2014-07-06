using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12_LargestArea
{
	class Task12_LargestArea
	{
		static int area = 0;
		static void PrintMaze(int[,] maze)
		{
			for (int i = 0; i < maze.GetLength(0); i++)
			{
				for (int j = 0; j < maze.GetLength(1); j++)
				{
					Console.Write(maze[i, j] + " ");
				}
				Console.WriteLine();
			}
		}
		static void DFS(int[,] maze, int currentRow, int currentCol)
		{
			//Go Down
			if (currentRow + 1 < maze.GetLength(0) && maze[currentRow + 1, currentCol] == 0)
			{
				area++;
				maze[currentRow + 1, currentCol] = 1;
				DFS(maze, currentRow + 1, currentCol);
			}
			//Go Up
			if (currentRow - 1 >= 0 && maze[currentRow - 1, currentCol] == 0)
			{
				area++;
				maze[currentRow - 1, currentCol] = 1;
				DFS(maze, currentRow - 1, currentCol);
			}
			//Go Right
			if (currentCol + 1 < maze.GetLength(1) && maze[currentRow, currentCol + 1] == 0)
			{
				area++;
				maze[currentRow, currentCol + 1] = 1;
				DFS(maze, currentRow, currentCol + 1);
			}
			//Go Left
			if (currentCol - 1 >= 0 && maze[currentRow, currentCol - 1] == 0)
			{
				area++;
				maze[currentRow, currentCol - 1] = 1;
				DFS(maze, currentRow, currentCol - 1);
			}
		}
		static int FindLargestArea(int[,] maze)
		{
			int maxArea = 0;
			for (int i = 0; i < maze.GetLength(0); i++)
			{
				for (int j = 0; j < maze.GetLength(1); j++)
				{
					if (maze[i, j] == 0)
					{
						area = 0;
						DFS(maze, i, j);
						if (area > maxArea)
						{
							maxArea = area;
						}
					}
				}
			}
			return maxArea;
		}
		static void Main(string[] args)
		{
			//Task: Find the largest area of passable cells. 0 - passable, 1 - unpassable
			int n, m;
			Console.WriteLine("Enter rows");
			n = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter cols");
			m = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter the maze");
			int[,] maze = new int[n, m];
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < m; j++)
				{
					maze[i, j] = int.Parse(Console.ReadLine());
				}
			}
			PrintMaze(maze);
			Console.WriteLine("The max area is containe of {0} passable cells", FindLargestArea(maze));
		}
	}
}
