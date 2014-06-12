using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_CorrectFloatingPoitnEvaluations
{
	class Task3_CorrectFloatingPoitnEvaluations
	{
		static void Main(string[] args)
		{
			/*Task: Write a program that makes correct evaluations with precision 0.000001*/
			decimal a;
			decimal b;
			int code;
			Console.WriteLine("Type a,b and a code for the evaluations");
			Console.WriteLine(@"Codes 1 for +, 2 for -, 3 for *, 4 for /");
			a = decimal.Parse(Console.ReadLine());
			b = decimal.Parse(Console.ReadLine());
			code = int.Parse(Console.ReadLine());
			switch (code)
			{
				case 1:
				{
					Console.WriteLine(Math.Round(a + b, 6));
				} break;
				case 2:
				{
					Console.WriteLine(Math.Round(a - b, 6));
				} break;
				case 3:
				{
					Console.WriteLine(Math.Round(a * b, 6));
				} break;
				case 4:
				{
					Console.WriteLine(Math.Round(a / b, 6));
				} break;
			}
		}
	}
}
