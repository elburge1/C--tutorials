using System;

namespace FirstConsoleProject
{
	class MainClass
	{
		public static void Main(string[] args) //this is a method called 'Main'. It is called when the program starts
		{
			int num01;
			int num02;

			Console.Write("Type a number to be multiplied");
			num01 = Convert.ToInt32 (Console.ReadLine());
			Console.Write("Type another number");
			num02 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine(num01 + " divided by " + num02 + " gives the result " + num01 / num02);
			Console.ReadKey();
		}
	}
}
