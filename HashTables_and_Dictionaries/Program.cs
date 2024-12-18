using System;
using System.Collections;

namespace Hashtables
{
	class Program
	{
		static void Main(string[] args)
		{
			// Create a new Hashtable to store Student objects
			// Hashtables store key-value pairs. 
			// Here, the key will be the student's ID (an integer), 
			// and the value will be the entire Student object.
			Hashtable studentsTable = new Hashtable();

			// Create some Student objects with ID, name, and GPA
			Student student1 = new Student(1, "Maria", 98);
			Student student2 = new Student(2, "John", 85);
			Student student3 = new Student(3, "Alex", 90);
			Student student4 = new Student(4, "Sara", 100);

			// Add the students to the Hashtable
			// The student's ID is used as the key, 
			// and the Student object itself is the value.
			studentsTable.Add(student1.Id, student1);
			studentsTable.Add(student2.Id, student2);
			studentsTable.Add(student3.Id, student3);
			studentsTable.Add(student4.Id, student4);


			// **Retrieve a student by their ID (assuming you know the ID)** 
			// This commented line retrieves student1 using their ID (1) as the key
			// Student retrievedStudent = (Student)studentsTable[1]; // This would retrieve student1

			// Another way to retrieve a student:
			int specificStudentId = student1.Id; // Get the ID from an existing student object
			Student storedStudent1 = (Student)studentsTable[specificStudentId]; // Cast retrieved value to Student

			// Here, we check if the key (specificStudentId) exists in the Hashtable before casting.
			// This prevents a potential error if the ID isn't found.
			if (studentsTable.ContainsKey(specificStudentId))
			{
				storedStudent1 = (Student)studentsTable[specificStudentId];
				Console.WriteLine("Student retrieved by ID: {0}, Name: {1}, GPA: {2}", storedStudent1.Id, storedStudent1.Name, storedStudent1.GPA);
			}
			else
			{
				Console.WriteLine("Student with ID {0} not found in the Hashtable", specificStudentId);
			}


			// **Retrieve all values from the Hashtable** 
			// There are two ways to do this:

			// 1. Looping through each key-value pair (DictionaryEntry) in the Hashtable
			foreach (DictionaryEntry entry in studentsTable)
			{
				// Cast the retrieved value (entry.Value) from the Hashtable to a Student object
				Student temp = (Student)entry.Value;

				// Access and print the student information from the temporary Student object
				Console.WriteLine("Student ID: {0}", temp.Id);
				Console.WriteLine("Student Name: {0}", temp.Name);
				Console.WriteLine("Student GPA: {0}", temp.GPA);
				Console.WriteLine(); // Print an empty line for better formatting
			}


			// 2. Looping directly through the Values collection of the Hashtable
			foreach (Student value in studentsTable.Values)
			{
				// Access and print the student information directly from the Student object
				Console.WriteLine("Student ID: {0}", value.Id);
				Console.WriteLine("Student Name: {0}", value.Name);
				Console.WriteLine("Student GPA: {0}", value.GPA);
				Console.WriteLine(); // Print an empty line for better formatting
			}

			// Print the retrieved student information (assuming successful retrieval)
			Console.WriteLine("Student retrieved by ID: {0}, Name: {1}, GPA: {2}", storedStudent1.Id, storedStudent1.Name, storedStudent1.GPA);
		}
	}

	class Student
	{
		// Properties to store the student's information
		public int Id { get; set; }    // Student's ID
		public string Name { get; set; }  // Student's name
		public float GPA { get; set; }   // Student's GPA

		// Constructor to initialize a Student object
		public Student(int id, string name, float GPA)
		{
			this.Id = id;
			this.Name = name;
			this.GPA = GPA;
		}
	}
}