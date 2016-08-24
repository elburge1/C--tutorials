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

			Console.WriteLine(numbers[2]);

			Console.ReadKey();
		}
	}
}
