using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_MoonGravity
{
	class Task7_MoonGravity
	{
		static void Main(string[] args)
		{
			//Task the Moon gravity is 17% of the Earths find the weight of a person on the Moon given his weight on the Earth
			float weight = float.Parse(Console.ReadLine());
			float moonWeight = weight * 0.17f;
			Console.WriteLine("The weight on the Moon is {0}", moonWeight);
		}
	}
}
