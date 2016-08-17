using System;

namespace FirstConsoleProject
{
	class MainClass
	{
		public static void Main(string[] args) //this is a method called 'Main'. It is called when the program starts
		{
			for (int i = 0; i <= 100; i++)
			{
				if (i % 2 == 0)
				{
					Console.WriteLine(i);
				}
			}
			Console.ReadKey();
		}
	}
}
