using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_Print1ToN
{
	class Task1_Print1ToN
	{
		static void Main(string[] args)
		{
			//Task: Print the numbers form 1 to N. 
			int n = int.Parse(Console.ReadLine());
			for (int i = 1; i < n; i++)
			{
				Console.WriteLine(i);
			}
		}
	}
}
