using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10_AllPathsMatrix
{
	class Task10_AllPathsMatrix
	{
		static char[] path;
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
		static void FindAllPaths(int[,] maze, int row, int col, int endRow, int endCol, int step)
		{
			if (row == endRow && col == endCol)
			{
				for (int i = 0; i < step; i++)
				{
					Console.Write(path[i] + " ");
				}
				Console.WriteLine();
				return;
			}
			//Go Down
			if (row + 1 < maze.GetLength(0) && maze[row + 1, col] == 0)
			{
				path[step] = 'D';
				maze[row + 1, col] = 1;
				FindAllPaths(maze, row + 1, col, endRow, endCol, step + 1);
				maze[row + 1, col] = 0;
			}
			//Go Up
			if (row - 1 >= 0 && maze[row - 1, col] == 0)
			{
				path[step] = 'U';
				maze[row - 1, col] = 1;
				FindAllPaths(maze, row - 1, col, endRow, endCol, step + 1);
				maze[row - 1, col] = 0;
			}
			//Go Right
			if (col + 1 < maze.GetLength(1) && maze[row, col + 1] == 0)
			{
				path[step] = 'R';
				maze[row, col + 1] = 1;
				FindAllPaths(maze, row, col + 1, endRow, endCol, step + 1);
				maze[row, col + 1] = 0;
			}
			//Go Left
			if (col - 1 >= 0 && maze[row, col - 1] == 0)
			{
				path[step] = 'L';
				maze[row, col - 1] = 1;
				FindAllPaths(maze, row, col - 1, endRow, endCol, step + 1);
				maze[row, col - 1] = 0;
			}
			
		}
		static void Main(string[] args)
		{
			//Task: Given a maze write program that finds all paths between two cells
			int n, m, startRow, startCol, endRow, endCol;
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
			Console.WriteLine("Rows and cols starting from 1");
			Console.WriteLine("Enter start row");
			startRow = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter start col");
			startCol = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter end row");
			endRow = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter end col");
			endCol = int.Parse(Console.ReadLine());
			path = new char[m * n];
			FindAllPaths(maze, startRow - 1, startCol - 1, endRow - 1, endCol - 1, 0);
		}
	}
}
