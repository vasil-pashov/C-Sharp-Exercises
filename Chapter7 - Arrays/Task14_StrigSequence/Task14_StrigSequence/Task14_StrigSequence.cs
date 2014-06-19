using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task14_StrigSequence
{
	class Task14_StrigSequence
	{
		static KeyValuePair<string, int> CountHorizontal(string[,] matrix)
		{
			string[,] copyMatrix =(string[,]) matrix.Clone();
			int max = 1;
			string mostCommon = copyMatrix[0, 0];
			for (int i = 0; i < copyMatrix.GetLength(0); i++)
			{
				
				
				for (int j = 1; j < copyMatrix.GetLength(1); j++)
				{
					int currentOccurence = 1;
					string currentElement = copyMatrix[i, j - 1];
					if (currentElement == null)
					{
						continue;
					}
					while (j < copyMatrix.GetLength(1) && currentElement == copyMatrix[i, j])
					{
						currentOccurence++;
						copyMatrix[i, j] = null;
						j++;
					}
					if (currentOccurence > max)
					{
						max = currentOccurence;
						mostCommon = currentElement;
					}
				}
			}
			return new KeyValuePair<string,int>(mostCommon, max);
		}
		static KeyValuePair<string, int> CountVertical(string[,] matrix)
		{
			string[,] copyMatrix = (string[,])matrix.Clone();
			int max = 0;
			string mostCommon = "";
			for(int j = 0; j < copyMatrix.GetLength(1); j++)
			{
				for (int i = 1; i < copyMatrix.GetLength(0); i++)
				{
					int currentOccurance = 1;
					string currentElement = copyMatrix[i - 1, j];
					if (currentElement == null)
					{
						continue;
					}
					while (i < copyMatrix.GetLength(0) && currentElement == copyMatrix[i, j])
					{
						currentOccurance++;
						copyMatrix[i, j] = null;
						i++;
					}
					if (currentOccurance > max)
					{
						max = currentOccurance;
						mostCommon = currentElement;
					}
				}
			}
			
			return new KeyValuePair<string, int>(mostCommon, max);
		}
		static KeyValuePair<string, int> CountDiagonalRight(string[,] matrix)
		{
			string[,] copyMatrix =(string[,]) matrix.Clone();
			string mostCommon = copyMatrix[0, 0];
			int max = 1;
			for (int i = 1; i < copyMatrix.GetLength(0); i++)
			{
				for (int j = 1; j < copyMatrix.GetLength(1); j++)
				{
					int currentI = i, currentJ = j, currentOccurance = 1;
					string currentElement = copyMatrix[i - 1, j - 1];
					if (currentElement == null)
					{
						continue;
					}

					while (currentI < copyMatrix.GetLength(0) && currentJ < copyMatrix.GetLength(1) && copyMatrix[currentI, currentJ] == currentElement)
					{
						currentOccurance++;
						currentI++;
						currentJ++;
					}
					if (currentOccurance > max)
					{
						max = currentOccurance;
						mostCommon = currentElement;
					}
				}
			}
			return new KeyValuePair<string, int>(mostCommon, max);
		}
		static KeyValuePair<string, int> CountDiagonalLeft(string[,] matrix)
		{
			string[,] copyMatrix = (string[,])matrix.Clone();
			string mostCommon = copyMatrix[0, 0];
			int max = 1;
			for (int i = 1; i < copyMatrix.GetLength(0); i++)
			{
				for (int j = 0; j < copyMatrix.GetLength(1) - 1; j++)
				{
					int currentI = i, currentJ = j, currentOccurance = 1;
					string currentElement = copyMatrix[i - 1, j + 1];
					if (currentElement == null)
					{
						continue;
					}

					while (currentI < copyMatrix.GetLength(0) && currentJ >= 0 && copyMatrix[currentI, currentJ] == currentElement)
					{
						currentOccurance++;
						currentI++;
						currentJ--;
					}
					if (currentOccurance > max)
					{
						max = currentOccurance;
						mostCommon = currentElement;
					}
				}
			}
			return new KeyValuePair<string, int>(mostCommon, max);
		}
		static KeyValuePair<string, int> ComparePairs(KeyValuePair<string, int> a, KeyValuePair<string, int> b)
		{
			return a.Value > b.Value ? a : b;
		}
		static void Main(string[] args)
		{
			//Task: Find the longest sequence of strings in matrix. It can be horizontal, vertical, or diagonal
			/*
			Example:
			------------------
			|ha |fifi |ho |hi|
			----------------
			|fo | ha  |hi |xx|
			------------------
			|xxx| ho  |ha |xx|
			------------------
			 Answer: ha
			 */
			string[,] matrix = { { "ha", "fifi", "ho", "hi" }, { "fo", "ha", "hi", "xx" }, {"xxx", "ho", "ha", "xx"} };
			KeyValuePair<string, int> mostCommon = ComparePairs(ComparePairs(CountVertical(matrix), CountHorizontal(matrix)), ComparePairs(CountDiagonalLeft(matrix), CountDiagonalRight(matrix)));
			Console.WriteLine("Longset sequence is sustained of \"{0}\" matched {1} times", mostCommon.Key, mostCommon.Value);
		}
	}
}
