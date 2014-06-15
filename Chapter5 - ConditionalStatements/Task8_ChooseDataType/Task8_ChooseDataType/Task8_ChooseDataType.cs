using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8_ChooseDataType
{
	class Task8_ChooseDataType
	{
		static void Main(string[] args)
		{
			//Task let the user choose data type if its int or double add 1 to tne number if its strind add '*' to the end
			Console.WriteLine("Choose 1 for int, 2 for double, 3 for string");
			int key = int.Parse(Console.ReadLine());
			switch (key)
			{
				case 1:
					{
						int value = int.Parse(Console.ReadLine());
						Console.WriteLine(value + 1);
					} break;
				case 2:
					{
						double value = double.Parse(Console.ReadLine());
						Console.WriteLine(value + 1);
					} break;
				case 3:
					{
						string value = Console.ReadLine();
						Console.WriteLine(value + '*');
					} break;
				default: Console.WriteLine("Unknown key"); break;
			}
		}
	}
}
