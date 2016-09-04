using System;
using System.Collections.Generic;

namespace FirstConsoleProject
{
	class MainClass
	{
		class Player
		{
			private int _health = 100;
			public int health 
			{ 
				get
				{
					return _health;
				}

				set
				{
					_health = value;
				}
			}
		}

		public static void Main(string[] args) //this is a method called 'Main'. It is called when the program starts
		{
			Player tom = new Player();
			Console.WriteLine(tom.health);
			tom.health = 10;
			Console.WriteLine(tom.health);

			Console.ReadKey();
		}
	}
}
