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
		}

		class Dog : Animal
		{


			public void Print()
			{
				Console.WriteLine("Name: " + name);
				Console.WriteLine("Age: " + age);
				Console.WriteLine("Happiness: " + happiness);
			}
		}
		public static void Main(string[] args) //this is a method called 'Main'. It is called when the program starts
		{
			Console.ReadKey();
		}
	}
}
