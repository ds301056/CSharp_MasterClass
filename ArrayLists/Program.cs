﻿// <auto-generated/>
using System;
using System.Collections;
using System.Collections.Generic;



namespace ArrayListC
{
	class Program
	{
		static void Main(string[] args)
		{
			//Declare an ArrayList - Legacy collection
			ArrayList myArrayList = new ArrayList(); // undefined amount of objects 


			// initialize with size 
			ArrayList myArrayList2 = new ArrayList(100);

			// add objects to the ArrayList
			myArrayList.Add(25);
			myArrayList.Add("Hello");
			myArrayList.Add(3.14);
			myArrayList.Add(13);
			myArrayList.Add(25.3);
			myArrayList.Add(true);
			myArrayList.Add(13);

			// display the list 
			foreach (var item in myArrayList)
			{
				Console.WriteLine(item);
			}

			Console.WriteLine();
			Console.WriteLine("Count: " + myArrayList.Count);
			Console.WriteLine();

			// delete element with specific value form the ArrayList
			myArrayList.Remove(13);
			// delete element at specific index
			myArrayList.RemoveAt(0);
			Console.WriteLine("deleted element at index 0");
			Console.WriteLine("Count: " + myArrayList.Count);

			// delte range of elements from the ArrayList
			myArrayList.RemoveRange(1, 3);
			Console.WriteLine("Count after removing by range (1-3): " + myArrayList.Count);
			Console.WriteLine();
			Console.WriteLine("array lists after deletions: ");
			// display the list 
			foreach (var item in myArrayList)
			{
				Console.WriteLine(item);
			}

		}
	}
}