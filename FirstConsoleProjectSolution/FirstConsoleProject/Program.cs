using System;

namespace FirstConsoleProject
{
	class MainClass
	{
		public static void Main(string[] args) //this is a method called 'Main'. It is called when the program starts
		{
			int result = Add(4, 8);
			Console.WriteLine(result);
			Console.ReadKey();
		}

		public static int Add(int num01, int num02)
		{
			return num01 + num02;
		}
	}
}
