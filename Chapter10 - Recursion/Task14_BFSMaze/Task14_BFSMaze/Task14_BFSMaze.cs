using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task14_BFSMaze
{
	class Cell
	{
		int row, col;
		public Cell()
		{
			this.row = 0;
			this.col = 0;
		}
		public Cell(int row, int col)
		{
			this.row = row;
			this.col = col;
		}
		public int Row
		{
			get { return this.row; }
			set { this.row = value; }
		}
		public int Col
		{
			get { return this.col; }
			set { this.col = value; }
		}
		public static bool operator == (Cell a, Cell b)
		{
			if(a.Row == b.Row && a.Col == b.Col)
			{
				return true;
			}
			return false;
		}
		public static bool operator !=(Cell a, Cell b)
		{
			if (a.Row != b.Row || a.Col != b.Col)
			{
				return true;
			}
			return false;
		}
	}
	class Task14_BFSMaze
	{
		static bool[,] used;
		static Cell[,] predicessors;
		static void PrintPath(Cell startCell, Cell endCell)
		{
			Cell currentCell = new Cell(endCell.Row, endCell.Col);
			while (currentCell != startCell)
			{
				Console.WriteLine(currentCell.Row + " " + currentCell.Col);
				currentCell = predicessors[currentCell.Row, currentCell.Col];
			}
			Console.WriteLine(endCell.Row + " " + endCell.Col);
		}
		static void FindShortestPath(int[,] maze, Cell startCell, Cell endCell)
		{
			Queue<Cell> bfsQueue = new Queue<Cell>();
			bfsQueue.Enqueue(startCell);
			used[startCell.Row, startCell.Col] = true;
			while (bfsQueue.Count > 0)
			{
				Cell currentCell = bfsQueue.Dequeue();
				if (currentCell == endCell)
				{
					PrintPath(startCell, endCell);
					return;
				}
				//Go Down
				if (maze.GetLength(0) > currentCell.Row + 1 && used[currentCell.Row + 1, currentCell.Col] == false &&
					maze[currentCell.Row + 1, currentCell.Col] != 1)
				{
					bfsQueue.Enqueue(new Cell(currentCell.Row + 1, currentCell.Col));
					used[currentCell.Row + 1, currentCell.Col] = true;
					predicessors[currentCell.Row + 1, currentCell.Col] = currentCell;
				}
				//Go Up
				if (currentCell.Row - 1 >= 0 && used[currentCell.Row - 1, currentCell.Col] == false &&
					maze[currentCell.Row - 1, currentCell.Col] != 1)
				{
					bfsQueue.Enqueue(new Cell(currentCell.Row - 1, currentCell.Col));
					used[currentCell.Row - 1, currentCell.Col] = true;
					predicessors[currentCell.Row - 1, currentCell.Col] = currentCell;
				}
				//Go Right
				if (maze.GetLength(1) > currentCell.Col + 1 && used[currentCell.Row, currentCell.Col + 1] == false &&
					maze[currentCell.Row, currentCell.Col + 1] != 1)
				{
					bfsQueue.Enqueue(new Cell(currentCell.Row, currentCell.Col + 1));
					used[currentCell.Row, currentCell.Col + 1] = true;
					predicessors[currentCell.Row, currentCell.Col + 1] = currentCell;
				}
				//Go Left
				if (currentCell.Col - 1 >= 0 && used[currentCell.Row, currentCell.Col - 1] == false &&
					maze[currentCell.Row, currentCell.Col - 1] != 1)
				{
					bfsQueue.Enqueue(new Cell(currentCell.Row, currentCell.Col - 1));
					used[currentCell.Row, currentCell.Col - 1] = true;
					predicessors[currentCell.Row, currentCell.Col - 1] = currentCell;
				}
			}
		}
		static void PrintMaze(int[,] maze)
		{
			for (int i = 0; i < maze.GetLength(0); i++)
			{
				for (int j = 0; j < maze.GetLength(1); j++)
				{
					Console.Write(maze[i,j] + " ");
				}
				Console.WriteLine();
			}
		}
		static void Main(string[] args)
		{
			//Task: Implement BFS to find the shortest way between two cells in a maze
			int n, m;
			Cell startCell = new Cell(), endCell = new Cell();

			Console.WriteLine("Enter rows");
			n = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter cols");
			m = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter the maze");
			int[,] maze = new int[n, m];
			used = new bool[n, m];
			predicessors = new Cell[n, m];
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < m; j++)
				{
					maze[i, j] = int.Parse(Console.ReadLine());
				}
			}
			PrintMaze(maze);
			Console.WriteLine("Enter start row");
			startCell.Row = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter start col");
			startCell.Col = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter end row");
			endCell.Row = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter end col");
			endCell.Col = int.Parse(Console.ReadLine());
			FindShortestPath(maze, startCell, endCell);
		}
	}
}
