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

		interface IDamageable
		{
			int durability { get; set;}

			void TakeDamage(int _amount);
		}

		class Sword : IItem, IDamageable
		{
			public string name { get; set;}
			public int goldValue { get; set;}

			public int durability { get; set; }

			public Sword(string _name)
			{
				name = _name;
				goldValue = 100;
				durability = 50;
			}

			public void Equip()
			{
				Console.WriteLine(name + " equipped");
			}
			public void Sell()
			{
				Console.WriteLine(name + " Sold for " + goldValue + " imaginary dollars.");
			}
			public void TakeDamage(int _dmg)
			{
				durability -= _dmg;
				Console.WriteLine(name + " damaged by " + _dmg + ". It now has a durability of " + durability); 
			}
		}

		class Axe : IItem, IDamageable
		{
			public string name { get; set; }
			public int goldValue { get; set; }

			public int durability { get; set; }

			public Axe(string _name)
			{
				name = _name;
				goldValue = 100;
				durability = 50;
			}

			public void Equip()
			{
				Console.WriteLine(name + " equipped");
			}
			public void Sell()
			{
				Console.WriteLine(name + " Sold for " + goldValue + " imaginary dollars.");
			}
			public void TakeDamage(int _dmg)
			{
				durability -= _dmg;
				Console.WriteLine(name + " damaged by " + _dmg + ". It now has a durability of " + durability);
			}
		}

		public static void Main(string[] args) //this is a method called 'Main'. It is called when the program starts
		{
			Sword sword = new Sword("Sword of Destiny");
			sword.Equip();
			sword.TakeDamage(20);
			sword.Sell();

			Axe axe = new Axe("Axe of justice");
			axe.Equip();
			axe.TakeDamage(10);
			axe.Sell();

			Console.ReadKey();
		}
	}
}
