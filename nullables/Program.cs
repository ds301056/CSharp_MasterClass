namespace Nullables
{
	internal class Program
	{
		private static void Main(string[] args)
		{

			int? age = null; // int? is shorthand for Nullable<int>

			if(age.HasValue) age = age.Value;

			Console.ReadKey();
		}

	}
}