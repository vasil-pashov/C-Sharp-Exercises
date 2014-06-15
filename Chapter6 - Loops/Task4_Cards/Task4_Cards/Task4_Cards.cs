using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_Cards
{
	class Task4_Cards
	{
		
		static void Main(string[] args)
		{
			//Task: Print out a deck of cards
			char[] cards = { '2', '3', '4', '5', '6', '7', '8', '9', 'J', 'Q', 'K', 'A' };
			for (int i = 3; i <= 6; i++)
			{
				foreach(char card in cards)
				{
					Console.WriteLine((char)i + " " + card);
				}
			}
		}
	}
}
