using System;

namespace FirstConsoleProject
{
	class MainClass
	{
		public static void Main(string[] args) //this is a method called 'Main'. It is called when the program starts
		{
			double num01;
			double num02;

			Console.Write("Type a number to be divided ");
			num01 = Convert.ToDouble (Console.ReadLine());
			Console.Write("Type another number ");
			num02 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine(num01 + " divided by " + num02 + " gives the result " + num01 / num02);
			Console.ReadKey();
		}
	}
}
