using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_WriteName
{
	class Task1_WriteName
	{
		static void SayHello(string name)
		{
			Console.WriteLine("Hello {0}", name);
		}
		static void Main(string[] args)
		{
			//Task: Write method that prints out - "Hello <name>".
			SayHello("Pesho");
		}
	}
}
