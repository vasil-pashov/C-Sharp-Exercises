using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9_ZeroSum
{
	class Task9_ZeroSum
	{
		static void Main(string[] args)
		{
			//Task given set of numbers find those which sum is 0
			int[] num = new int[5];
			for (int i = 0; i < 5; i++)
			{
				num[i] = int.Parse(Console.ReadLine());
			}
			for (int i = 0; i < 5; i++)
			{
				for (int j = i + 1; j < 5; j++)
				{
					if (num[i] + num[j] == 0)
					{
						Console.WriteLine("{0} {1}", num[i], num[j]);
					}
					for (int p = j + 1; p < 5; p++)
					{
						if (num[i] + num[j] + num[p] == 0)
						{
							Console.WriteLine("{0} {1} {2}", num[i], num[j], num[p]);
						}
						for (int q = p + 1; q < 5; q++)
						{
							if (num[i] + num[j] + num[p] + num[q] == 0)
							{
								Console.WriteLine("{0} {1} {2} {3}", num[i], num[j], num[p], num[q]);
							}
						}
					}
				}
			}

		}
	}
}
