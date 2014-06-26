using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11_FuncMenu
{
	class Task11_FuncMenu
	{
		static int ReverseNumber(int initial)
		{
			if (initial < 0)
			{
				throw new Exception("The number shouldn't be negative");
			}
			int reversed = 0;
			while (initial > 0)
			{
				reversed += initial % 10;
				initial /= 10;
				reversed *= 10;
			}
			return reversed / 10;
		}
		static double ComputeAverage(int[] array)
		{
			if (array.Length == 0)
			{
				throw new Exception("The array must not be empty");
			}
			double average = 0;
			for (int i = 0; i < array.Length; i++)
			{
				average += array[i];
			}
			return average / array.Length;
		}
		static double SolveEquation(double a, double b)
		{
			if (a == 0)
			{
				throw new Exception("a must not be zero");
			}
			return -b / a;
		}
		static void PerformAction(int action)
		{
			switch (action)
			{
				case 0: return;
				case 1:
				{
					Console.WriteLine("Enter a number");
					int n = int.Parse(Console.ReadLine());
					int revesed = ReverseNumber(n);
					Console.WriteLine(revesed);
				} break;
				case 2:
				{
					Console.WriteLine("Enter array lenght");
					int n = int.Parse(Console.ReadLine());
					int[] array = new int[n];
					Console.WriteLine("Enter array");
					for (int i = 0; i < n; i++)
					{
						array[i] = int.Parse(Console.ReadLine());
					}
					double average = ComputeAverage(array);
					Console.WriteLine(average);
				} break;
				case 3:
				{
					Console.WriteLine("Enter a and b for equation: a * x + b = 0");
					double a, b;
					a = double.Parse(Console.ReadLine());
					b = double.Parse(Console.ReadLine());
					double x = SolveEquation(a, b);
					Console.WriteLine(x);
				} break;
				default: throw new Exception("Invalid action");
			}
		}
		static void Main(string[] args)
		{
			/*Task: Write methods that:
			  - Reverses a number
			  - Coputes the average value of array
			  - Solves the equation - a * x + b = 0
			 * Make data verification
			  - The number should be >= 0
			  - The array must contain at least 1 number
			  - a should not be 0
			 * Make a menu that gives the usert the choose action
			 * */
			Console.WriteLine("Please choose action");
			Console.WriteLine("0 - exit");
			Console.WriteLine("1 - Reverse number");
			Console.WriteLine("2 - Compute average");
			Console.WriteLine("3 - Solve equation: a * x  + b = 0");
			int action;
			do
			{
				action = int.Parse(Console.ReadLine());
				PerformAction(action);
				Console.WriteLine("Choose again");
			}
			while(action != 0);
		}
	}
}
