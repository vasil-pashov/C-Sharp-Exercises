using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_WordComb
{
	class Task4_WordComb
	{
		static void PrintWords(string[] words)
		{
			foreach(string word in words)
			{
				Console.Write(word + " ");
			}
		}
		static void Combine(string[] currentCombination, string[] words, int currentWord, int position, int k)
		{
			if (position == k)
			{
				PrintWords(currentCombination);
				Console.WriteLine();
				return;
			}
			for (int i = currentWord; i < words.Length; i++)
			{
				currentCombination[position] = words[i];
				Combine(currentCombination, words, i + 1, position + 1, k);
			}
		}
		static void Main(string[] args)
		{
			//Task: Write recursive function that displays sustained of k words.
			int wordsCnt, k;
			Console.WriteLine("Enter number of words");
			wordsCnt = int.Parse(Console.ReadLine());
			string[] words = new string[wordsCnt];
			Console.WriteLine("Enter words");
			for (int i = 0; i < wordsCnt; i++)
			{
				words[i] = Console.ReadLine();
			}
			Console.WriteLine("Enter subset size");
			k = int.Parse(Console.ReadLine());
			string[] currentCombination = new string[k];
			Combine(currentCombination, words, 0, 0, k);
		}
	}
}
