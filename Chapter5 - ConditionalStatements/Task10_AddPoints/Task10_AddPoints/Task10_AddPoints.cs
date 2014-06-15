using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10_AddPoints
{
	class Task10_AddPoints
	{
		static void Main(string[] args)
		{
			//Task add points to a player. If his points are [1; 3] *= 10, [4; 6] *= 100 [7;9] *=1000 else print error
			int points = int.Parse(Console.ReadLine());
			if (points >= 1 && points <= 3)
			{
				Console.WriteLine(points * 10);
			}
			else if (points >= 4 && points <= 6)
			{
				Console.WriteLine(points * 100);
			}
			else if (points >= 7 && points <= 9)
			{
				Console.WriteLine(points * 1000);
			}
			else
			{
				Console.WriteLine("Invalid points");
			}
		}
	}
}
