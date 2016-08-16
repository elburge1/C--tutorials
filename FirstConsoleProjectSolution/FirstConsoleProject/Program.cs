using System;

namespace FirstConsoleProject
{
	class MainClass
	{
		public static void Main(string[] args) //this is a method called 'Main'. It is called when the program starts
		{
			Console.WriteLine("How old are you?");
			int age = Convert.ToInt32(Console.ReadLine());
			if (age < 18)
			{
				Console.WriteLine("That's too bad. You will have to wait a couple of years.");
			}
			else if (age == 18)
			{
				Console.WriteLine("Phew! Barely made it!");
			}
			else {
				Console.WriteLine("You are allowed to enter!");
			}
			Console.ReadKey();
		}
	}
}
