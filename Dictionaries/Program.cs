namespace Dictionaries
{
	internal class Program
	{
		static void Main(string[] args)
		{


			// key - value 

			// key is int, value is string
			Dictionary<int, string> employees = new Dictionary<int, string>();

			// Adding items to a dictionary
			employees.Add(101, "John Doe");
			employees.Add(102, "Jane Doe");
			employees.Add(103, "Alice Smith");
			employees.Add(104, "jake Crandle");

			// Accessing items in a dictionary
			string name = employees[101];
			Console.WriteLine(name);

			employees[102] = "Bob Smith";

			// Removing items from a dictionary
			employees.Remove(101);

			// Iterating over a dictionary
			foreach (KeyValuePair<int, string> employee in employees)
			{
				Console.WriteLine($"ID: {employee.Key}, Name: {employee.Value}");
			}
		}
	}
}