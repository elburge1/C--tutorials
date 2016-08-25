using System;
using System.Collections.Generic;

namespace FirstConsoleProject
{
	class Animal
	{
		public string name = "Spotty";
		public int age = 6;
		public float happiness = 0.5f;
	}

	class MainClass
	{
		public static void Main(string[] args) //this is a method called 'Main'. It is called when the program starts
		{
			//classes
			Animal dog = new Animal();
			Console.WriteLine(dog.name);

			Console.ReadKey();
		}
	}
}
