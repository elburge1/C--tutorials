using System;
using System.Collections.Generic;

namespace FirstConsoleProject
{
	class Animal
	{

		//class variables
		public static int count = 0;

		public string name;
		public int age;
		public float happiness;


		//class constructors

		public Animal(string _name, int _age, float _happiness)
		{
			name = _name;
			age = _age;
			happiness = _happiness;

			count++;
		}


		//class methods
		public void Print()
		{
			Console.WriteLine("name: " + name);
			Console.WriteLine("age: " + age);
			Console.WriteLine("happiness: " + happiness);
		}
	}

	class MainClass
	{
		public static void Main(string[] args) //this is a method called 'Main'. It is called when the program starts
		{
			//classes
			Animal dog = new Animal("Spotty", 6, 0.5f);
			dog.Print();

			Animal cat = new Animal("Mr. Beans", 3, 0.9f);
			cat.Print();

			Console.WriteLine("Number of animals: " + Animal.count);

			Console.ReadKey();
		}
	}
}
