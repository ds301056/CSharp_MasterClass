using System.ComponentModel;

namespace  ListsApp
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			
			// Declaring a list and initializing 
			List<string> colors =
			[
				// add colors to the list - strings 
				"red",
				"blue",
				"green",
				"red",
				"red",
				"red",
			]; // Empty list


			colors.Add("yellow"); // add yellow to the list


			Console.WriteLine("Current colors in the colors list: \n");

			// Accessing elements in the list
			foreach (string color in colors)
			{
				Console.WriteLine(color);
			}

			Console.WriteLine("\n");
			bool isDeletingSuccesful = colors.Remove("red"); // remove the first occurence of red from the list
			while (isDeletingSuccesful)
			{
				isDeletingSuccesful = colors.Remove("red");// delte red until no more red is found
				Console.WriteLine("remove sucessful: " + isDeletingSuccesful);
			}
			
			
			Console.WriteLine("current colors in the colors list after removing red: \n");


			// remove colors from the list 
			//colors.Remove("red");

			// add new line 
			
			Console.WriteLine("remove sucessful: " + isDeletingSuccesful);
			if (isDeletingSuccesful == false) {
			Console.WriteLine("No more red in the list");
			}// shoow bool value of the remove method
			Console.WriteLine("\n");



			foreach (string color in colors)
			{
				Console.WriteLine(color);
			}




			Console.ReadKey(); // Wait for user to press a key
		}
	}
}