﻿using System;

namespace FirstConsoleProject
{
	class MainClass
	{
		public static void Main(string[] args) //this is a method called 'Main'. It is called when the program starts
		{
			int[] numbers = new int[5];
			numbers[0] = 12;
			numbers[1] = 3;
			numbers[2] = 5;

			for (int i = 0; i < numbers.Length; i++)
			{
				Console.Write(numbers[i]);
			}

			Console.ReadKey();
		}
	}
}
