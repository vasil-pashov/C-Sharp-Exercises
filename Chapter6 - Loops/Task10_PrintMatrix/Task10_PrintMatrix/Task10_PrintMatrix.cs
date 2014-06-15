using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10_PrintMatrix
{
	class Task10_PrintMatrix
	{
		static void Main(string[] args)
		{
			/* Task: Print matrix like the given for any n. n = 4
					1 2 3 4
					2 3 4 5
					3 4 5 6
					4 5 6 7
			 */
			int n = int.Parse(Console.ReadLine());
			for (int i = 1; i <= n; i++)
			{
				for (int j = i; j < i + n; j++)
				{
					Console.Write(j + " ");
				}
				Console.WriteLine();
			}
		}
	}
}
