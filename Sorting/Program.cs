using System;
using System.Collections.Generic;

namespace ListsApp
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			// 1. Create and display an unsorted list of integers
			List<int> numbers = new List<int> { 10, 5, 15, 3, 9, 25, 18 };
			Console.WriteLine("Unsorted list:");
			foreach (int number in numbers)
			{
				Console.WriteLine(number);
			}


			bool hasLargeNumber = numbers.Any(x => x> 20); // Returns true if any element in the list satisfies the condition

			if (hasLargeNumber)
			{
				Console.WriteLine("The list contains a number greater than 20.");
			}
			else
			{
				Console.WriteLine("The list does not contain a number greater than 20.");

			}


				// 2. Define Predicate delegates (using both lambda expressions and method references)
				Predicate<int> isGreaterThanTenLambda = x => x > 10;

			// Predicate delegate that takes an integer and returns a boolean
			Predicate<int> isLessThanTenLambda = x => x < 10;

			Predicate<int> isGreaterThanTenMethod = IsGreaterThanTen; // Using the method reference

			Console.Write("\n"); // Add a new line for spacing

			// 3. Use FindAll with lambda expressions
			List<int> higherThanTenLambda = numbers.FindAll(isGreaterThanTenLambda);
			// display the list of Findall
			// return list of number 10 or higher 
			Console.WriteLine("All numbers greater than ten (using lambda):");
			foreach (int number in higherThanTenLambda)
			{
				Console.WriteLine(number);
			}

			Console.Write("\n");

			List<int> lessThanTenLambda = numbers.FindAll(isLessThanTenLambda);
			Console.WriteLine("All numbers less than ten (using lambda):");
			foreach (int number in lessThanTenLambda)
			{
				Console.WriteLine(number);
			}

			// 4. Use FindAll with a method reference
			List<int> higherThanTenMethod = numbers.FindAll(isGreaterThanTenMethod);
			Console.WriteLine("\nAll numbers greater than ten (using method reference):");
			foreach (int number in higherThanTenMethod)
			{
				Console.WriteLine(number);
			}

			// 5. Sort and display the sorted list
			numbers.Sort(); // Sort the list
			Console.Write("\n");
			Console.WriteLine("Sorted list:");
			// display the sorted numbers
			foreach (int number in numbers)
			{
				Console.WriteLine(number);
			}

			// lambda expression consists of input parameters (x) => expression (x * x)
			// 1. Parameters 
			// 2. Lambda operator => 
			// 3. Expression

			// Parameters are written on the left side of the lambda operator =>
			// The expression is written on the right side of the lambda operator =>
			// The lambda expression x => x * x reads as “x goes to x times x.”

			// lambda is for a single line of code - simpler than a method but cannot be reused

			// x => x * x
			static int Squaring(int num1)
			{
				return num1 * num1;
			}

			/*
             In C# a delegate is a pointer or a reference to a method.
             It allows you to pass methods as arguements to other methods,
             store them in variables and call them later. 

             This is useful when you want your code to be flexible and able to handle different 
             behaviors that aren't predetermined at compile time.
             */

			Console.ReadKey();
		}

		// Method for the Predicate delegate (moved outside Main)
		public static bool IsGreaterThanTen(int x) // Method that returns a boolean
		{
			return x > 10; // Return true if x is greater than 10
		}
	}
}