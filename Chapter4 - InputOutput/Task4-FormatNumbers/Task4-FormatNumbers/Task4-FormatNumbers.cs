using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_FormatNumbers
{
	class Task4_FormatNumbers
	{
		static void Main(string[] args)
		{
			//Task output three numbers in three columns colums are 10 signs wide, the numbers are left aligned. First number is in hex, second positive float, third negative float. Last two should have signs after the decimal mark.
			Console.WriteLine("{0, -10:X}{1, -10:F2}{2, -10:F2}", 123, 123.123123, -123,234234);
		}
	}
}
