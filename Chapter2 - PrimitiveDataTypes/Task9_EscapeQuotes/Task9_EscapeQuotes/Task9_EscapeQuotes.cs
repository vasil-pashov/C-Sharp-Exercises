using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9_EscapeQuotes
{
	class Task9_EscapeQuotes
	{
		static void Main(string[] args)
		{
			//Task create 2 string vars and assign "The "use" of quotations causes difficulties." to them use quote string and escaping
			string quoted = @"The ""use"" of quotations causes difficulties.";
			string escaped = "The \"use\" of quotations causes difficulties.";
			Console.WriteLine(quoted);
			Console.WriteLine(escaped);
		}
	}
}
