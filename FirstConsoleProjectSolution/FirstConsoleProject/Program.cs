using System;
using System.Collections.Generic;

namespace FirstConsoleProject
{
	class MainClass
	{
		class Animal
		{
			public string name;
			public int age;
			public float happiness;

			public void PrintBase()
			{
				Console.WriteLine("name: " + name);
				Console.WriteLine("age: " + age);
				Console.WriteLine("happiness: " + happiness);
			}
		}

		class Dog : Animal
		{
			public int spotCount;

			public void Bark()
			{
				Console.WriteLine("Woof");
				base.happiness += 0.1f;
			}
		}

		class Cat : Animal
		{
			public float cuteness;

			public void Meow()
			{
				Console.WriteLine("Meow");
			}
		}

		public static void Main(string[] args) //this is a method called 'Main'. It is called when the program starts
		{
			Dog spotty = new Dog();
			spotty.name = "Spotty";
			spotty.age = 4;
			spotty.happiness = 0.8f;
			spotty.spotCount = 25;
			spotty.PrintBase();
			spotty.Bark();
			spotty.PrintBase();

			Cat heisenberg = new Cat();
			heisenberg.name = "Heisenberg";
			heisenberg.age = 13;
			heisenberg.happiness = 0.3f;
			heisenberg.cuteness = 0.4f;
			heisenberg.PrintBase();
			heisenberg.Meow();

			Console.ReadKey();
		}
	}
}
