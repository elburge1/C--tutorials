﻿using System;
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
		}

		class Dog : Animal
		{
			public string breed;

			public Dog(string _name, int _age, float _happiness, string _breed)
			{
				name = _name;
				age = _age;
				happiness = _happiness;
				breed = _breed;
			}

			public void Print()
			{
				Console.WriteLine("Name: " + name);
				Console.WriteLine("Age: " + age);
				Console.WriteLine("Happiness: " + happiness);

				Console.WriteLine("Breed: " + breed);
			}
		}
		public static void Main(string[] args) //this is a method called 'Main'. It is called when the program starts
		{
			Dog hulk = new Dog("Hulk", 2, 0.7f, "Boxer");
			hulk.Print();

			Console.ReadKey();
		}
	}
}
