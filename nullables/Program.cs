namespace Nullables
{
	internal class Program
	{
		private static void Main(string[] args)
		{

			int? age = null; // int? is shorthand for Nullable<int>
			int myAge = 35;

			if (age.HasValue)
			{
				int sum = age.Value + myAge;
				Console.WriteLine("Age is: " + sum);
			}
			else
			{
				

				Console.WriteLine("Age is not set");

			}


				Console.ReadKey();
		}

	}
}