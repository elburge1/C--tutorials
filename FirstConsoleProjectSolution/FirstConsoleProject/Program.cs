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

		interface IPartofquest
		{
			void TurnIn();
		}

		class Sword : IItem, IDamageable, IPartofquest
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
			public void TurnIn()
			{
				Console.WriteLine(name + " turned in!");
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

			//create an inventory
			IItem[] inventory = new IItem[2];
			inventory[0] = sword;
			inventory[1] = axe;

			//Loop through to turn in quest items
			for (int i = 0; i < inventory.Length; i++)
			{
				IPartofquest questItem = inventory[i] as IPartofquest;
				if (questItem != null)
				{
					questItem.TurnIn();
				}
			}

			Console.ReadKey();
		}
	}
}
