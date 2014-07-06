using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_AllCombinations
{
	class Task5_AllCombinations
	{
		static string[] currentCombination = new string[100];
		static void PrintWords(string[] words)
		{
			foreach (string word in words)
			{
				Console.Write(word + " ");
			}
		}
		static void Combine(string[] words, int currentWord, int position, int k)
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
				Combine(words, i + 1, position + 1, k);
			}
		}
		static void Main(string[] args)
		{
			//Task: Display all posible subsets of given set of words
			int wordsCnt;
			Console.WriteLine("Enter the words count");
			wordsCnt = int.Parse(Console.ReadLine());
			string[] words = new string[wordsCnt];
			for (int i = 0; i < wordsCnt; i++)
			{
				words[i] = Console.ReadLine();
			}
			for (int i = 0; i <= wordsCnt; i++)
			{
				Combine(words, 0, 0, i);
			}
		}
	}
}
