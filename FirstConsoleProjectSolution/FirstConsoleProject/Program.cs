using System;

namespace FirstConsoleProject
{
	class MainClass
	{
		public static void Main(string[] args) //this is a method called 'Main'. It is called when the program starts
		{
			int i = 1;
			while (i <= 10)
			{
				Console.WriteLine(i);
				i++;
			}
			Console.ReadKey();
		}
	}
}
