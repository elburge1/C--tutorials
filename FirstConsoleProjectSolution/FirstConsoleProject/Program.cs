using System;
using System.Collections.Generic;

namespace FirstConsoleProject
{
	class MainClass
	{
		public static void Main(string[] args) //this is a method called 'Main'. It is called when the program starts
		{
			//Multi-dimensional arrays
			createGrid();

			Console.ReadKey();
		}

		public static void createGrid()
		{
			int width = 5;
			int height = 5;

			int[,] grid = new int[width, height];
			grid[2, 3] = 5;

			for (int x = 0; x < width; x++)
			{
				for (int y = 0; y < height; y++)
				{
					Console.Write(grid[x, y] + ", ");
				}
				Console.WriteLine();
			}
		}
	}
}
