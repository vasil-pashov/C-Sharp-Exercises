using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11_Print1ToN
{
	class Task11_Print1ToN
	{
		static void Main(string[] args)
		{
			//Task input a number - n. The output the numbers in interval [1;n] each on new line
			int n = int.Parse(Console.ReadLine());
			for (int i = 1; i <= n; i++)
			{
				Console.WriteLine(i);
			}
		}
	}
}
