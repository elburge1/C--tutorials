using System;

namespace FirstConsoleProject
{
	class MainClass
	{
		public static void Main(string[] args) //this is a method called 'Main'. It is called when the program starts
		{
			Random numberGen = new Random();

			int numberOfAttempts = 0;
			int attempt = 0;

			while (attempt != 6)
			{
				attempt = numberGen.Next(1, 7);
				Console.WriteLine("Tom rolled: " + attempt + ".");
				numberOfAttempts++;
			}

			Console.WriteLine("It took tom " + numberOfAttempts + " attempts to roll a 6.");

			Console.ReadKey();
		}
	}
}
