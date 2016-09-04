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
			}

			public void Damage(int _dmg)
			{
				_health -= _dmg;
			}
		}

		public static void Main(string[] args) //this is a method called 'Main'. It is called when the program starts
		{
			Player tom = new Player();
			tom.Damage(10);
			Console.WriteLine(tom.health);

			Console.ReadKey();
		}
	}
}
