using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8_ConcatStringsAndCast
{
	class Task8_ConcatStringsAndCast
	{
		static void Main(string[] args)
		{
			//Task create string "Hello" and string "Worl" concat them and assing the value to object type then assign the object value to string
			string hello = "Hello";
			string world = "World";
			object concatResult = hello + " " + world;
			string helloWorld = (string)concatResult;
			Console.WriteLine(helloWorld);
		}
	}
}
