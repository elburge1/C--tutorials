using System;
using System.Collections.Generic;

namespace FirstConsoleProject
{
	class MainClass
	{
		public static void Main(string[] args) //this is a method called 'Main'. It is called when the program starts
		{
			List<int> numbers = new List<int>();

			numbers.Add(13);
			numbers.Add(4);
			numbers.Add(25);

			numbers.Remove(4);

			for (int i = 0; i < numbers.Count; i++)
			{
				Console.WriteLine(numbers[i]);
			}

			Console.ReadKey();
		}
	}
}
