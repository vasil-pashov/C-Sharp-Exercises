using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_DefiningFloatingPointVariables
{
	class Task2_DefiningFloatingPointVariables
	{
		static void Main(string[] args)
		{
			/*Which of the values can be applied to: float, double, and decimal. Values: 34.567839023; 12.345; 8923.1234857; 3456.091124875956542151256683467 */
			//for 34.567839023
			double var1 = 34.567839023;
			decimal var2 = 34.567839023m;
			//for 12.345
			float var3 = 12.345f;
			double var4 = 12.234;
			decimal var5 = 12.345m;
			//for 8923.1234857
			float var6 = 8923.1234857f;
			double var7 = 8923.1234857;
			decimal var8 = 8923.1234857m;
			//for 3456.091124875956542151256683467
			double var9 = 3456.091124875956542151256683467;
		}
	}
}
