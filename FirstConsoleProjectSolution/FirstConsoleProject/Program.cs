using System;

namespace FirstConsoleProject
{
	class MainClass
	{
		public static void Main(string[] args) //this is a method called 'Main'. It is called when the program starts
		{
			int num01 = 5;
			int num02 = 6;
			Console.Write("What is " + num01 + " plus " + num02 + "? ");
			int answer = Convert.ToInt32(Console.ReadLine());

			if (answer == num01 + num02)
			{
				Console.WriteLine("That's correct. Good job!");
			}
			else {
				Console.WriteLine("WRONG DUMMY!");
			}
		}
	}
}
