using System;
using System.Collections;

namespace Hashtables
{
	class Program
	{
		static void Main(string[] args)
		{
			// Create a new Hashtable. 
			// Hashtables store key-value pairs. In this case, the key will be the student's ID, and the value will be the Student object itself.
			Hashtable studentsTable = new Hashtable();

			// Create some Student objects
			Student student1 = new Student(1, "Maria", 98);
			Student student2 = new Student(2, "John", 85);
			Student student3 = new Student(3, "Alex", 90);
			Student student4 = new Student(4, "Sara", 100);

			// Add the students to the Hashtable. 
			// The student's ID is used as the key, and the Student object is the value.
			studentsTable.Add(student1.Id, student1);
			studentsTable.Add(student2.Id, student2);
			studentsTable.Add(student3.Id, student3);
			studentsTable.Add(student4.Id, student4);

			// You can access a student using their ID as the key:
			// Student retrievedStudent = (Student)studentsTable[1]; // This would retrieve student1

			Console.WriteLine("Hello World!");
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