using System;

namespace FirstConsoleProject
{
	class MainClass
	{
		public static void Main(string[] args) //this is a method called 'Main'. It is called when the program starts
		{
			string[] names = new string[3]
			{
				"Tom", "Mark", "Matt"
			};

			foreach (string name in names)
			{
				Console.WriteLine(name);
			}

			Console.ReadKey();
		}
	}
}
