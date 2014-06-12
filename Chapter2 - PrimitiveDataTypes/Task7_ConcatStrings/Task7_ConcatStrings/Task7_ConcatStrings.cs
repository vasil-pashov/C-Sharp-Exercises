using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_ConcatStrings
{
	class Task7_ConcatStrings
	{
		static void Main(string[] args)
		{
			//Task create string "Hello" and string "Worl" concat them and assing the value to object type
			string hello = "Hello";
			string world = "World";
			object concatResult = hello + " " + world;
			Console.WriteLine(concatResult);
		}
	}
}
