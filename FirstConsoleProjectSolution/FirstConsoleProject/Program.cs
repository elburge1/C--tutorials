﻿using System;
using System.Collections.Generic;

namespace FirstConsoleProject
{
	class MainClass
	{
		public static void Main(string[] args) //this is a method called 'Main'. It is called when the program starts
		{
			DateTime curTime = DateTime.Now;
			Console.WriteLine(curTime);

			Console.ReadKey();
		}
	}
}
