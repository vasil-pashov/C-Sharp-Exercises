using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_IsThirdBitOne
{
	class Task4_IsThirdBitOne
	{
		static void Main(string[] args)
		{
			int num = int.Parse(Console.ReadLine());
			bool isThirdBitOne = (num & 8) == 8 ? true : false;
			Console.WriteLine("Is the tird bit of {0} one {1}", num, isThirdBitOne);
		}
	}
}
