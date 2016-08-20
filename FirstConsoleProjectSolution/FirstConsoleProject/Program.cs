using System;

namespace FirstConsoleProject
{
	class MainClass
	{
		public static void Main(string[] args) //this is a method called 'Main'. It is called when the program starts
		{
			Add(4, 8);
			Console.ReadKey();
		}

		public static void Add(int num01, int num02)
		{
			Console.WriteLine(num01 + num02);
		}
	}
}
