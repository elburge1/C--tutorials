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
			int width = 20;
			int height = 20;

			int[,] grid = new int[width, height];

			for (int x = 0; x < width; x++)
			{
				for (int y = 0; y < height; y++)
				{
					grid[x, y] = x + y;
					Console.Write(grid[x, y]);
				}
				Console.WriteLine();
			}
		}
	}
}
