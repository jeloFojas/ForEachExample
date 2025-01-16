﻿namespace ForEachExample
{
	internal class Program
	{
		static void Main(string[] args)
		{
			char choice;

			do
			{
				string[] students = {"FLORENDO",
								"SANTILLAN",
								"TORRES",
								"PANGYARIHAN",
								"GANOTICE",
								"DAPROZA",
								"CORTEZ",
								"VENTENILLA",
								"LANOY"};
				Console.Write("Type the name to be search: ");
				string search = Console.ReadLine();

				foreach (string student in students)
				{
					if (student == search)
					{
						Console.WriteLine($"There is a name in the file {student}");
						break;
					} 
					
				}
				Console.Write("Do you want to search another name [Y / N]: ");
				choice = Convert.ToChar(Console.ReadLine());
			} while (choice == 'Y' || choice == 'y');
			

			Console.ReadLine();
		}
	}
}
