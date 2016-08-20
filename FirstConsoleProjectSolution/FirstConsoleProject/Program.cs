using System;

namespace FirstConsoleProject
{
	class MainClass
	{
		public static void Main(string[] args) //this is a method called 'Main'. It is called when the program starts
		{
			GreetUser();

			Console.ReadKey();
		}

		public static void GreetUser()
		{
			Console.WriteLine("Hello world!");
		}
	}
}
