using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task15_DFSOnDriveC
{
	class Task15_DFSOnDriveC
	{
		static void TraverseDirectories(string currentDirctory, int lvl)
		{
			try
			{
				for (int i = 0; i < lvl; i++)
				{
					Console.Write(" ");
				}
				Console.Write(currentDirctory + "\n");
				foreach (string directory in Directory.GetDirectories(currentDirctory))
				{

					TraverseDirectories(directory, lvl + 1);
				}
			}
			catch (UnauthorizedAccessException)
			{
			}
		}
		static void Main(string[] args)
		{
			//Task: Recursively travers all directories on drive C
			TraverseDirectories("C:\\", 0);
		}
	}
}
