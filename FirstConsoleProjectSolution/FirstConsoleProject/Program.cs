using System;
using System.Collections.Generic;

namespace FirstConsoleProject
{
	class MainClass
	{
		class Player
		{
			public int health = 100;
		}

		public static void Main(string[] args) //this is a method called 'Main'. It is called when the program starts
		{
			Player tom = new Player();
			Console.WriteLine(tom.health);
			tom.health = 40;
			Console.WriteLine(tom.health);

			Console.ReadKey();
		}
	}
}
