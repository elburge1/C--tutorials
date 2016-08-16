using System;

namespace FirstConsoleProject
{
	class MainClass
	{
		public static void Main(string[] args) //this is a method called 'Main'. It is called when the program starts
		{
			Random numbergenerator = new Random();

			int num01 = numbergenerator.Next(1, 11);
			int num02 = numbergenerator.Next(1, 11);

			Console.Write("What is " + num01 + " plus " + num02 + "? ");
			int answer = Convert.ToInt32(Console.ReadLine());

			if (answer == num01 + num02)
			{
				Console.WriteLine("That's correct. Good job!");
			}
			else {
				int responseindex = numbergenerator.Next(1, 4);

				switch (responseindex)
				{
					case 1:
						Console.WriteLine("WRONG DUMMY!");
						break;
					case 2:
						Console.WriteLine("You tried");
						break;
					default:
						Console.WriteLine("You can do better than that!");
						break;
				}

			}
		}
	}
}
