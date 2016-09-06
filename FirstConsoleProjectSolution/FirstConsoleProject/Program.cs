using System;
using System.Collections.Generic;

namespace FirstConsoleProject
{
	class MainClass
	{
		interface IItem
		{
			string name { get; set; }
			int goldValue { get; set; }

			void Equip();
			void Sell();
		}

		class Sword
		{
			public string name { get; set;}
			public int goldValue { get; set;}

			public Sword(string _name)
			{
				name = _name;
				goldValue = 100;
			}
		}

		public static void Main(string[] args) //this is a method called 'Main'. It is called when the program starts
		{


			Console.ReadKey();
		}
	}
}
