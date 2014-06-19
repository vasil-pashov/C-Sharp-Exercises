using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task15_LetterIndex
{
	class Task15_LetterIndex
	{
		static void Main(string[] args)
		{
			//Task: Enter a word then show the alphabetical index of each letter
			Console.WriteLine("Word");
			string word = Console.ReadLine();
			for (int i = 0; i < word.Length; i++)
			{
				char letter = word[i];
				int index = ((int)letter.ToString().ToLower()[0] - (int)'a') + 1;
				Console.WriteLine("The letter is {0} its index is {1}", letter, index);
			}
		}
	}
}
