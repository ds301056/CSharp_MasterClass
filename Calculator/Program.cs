// Prints out whatever is in side of ()
Console.WriteLine("Please enter a whole number:");

double myNumber = 0.0; // datatype variableName = initial value;
double myNumber2 = 0.0; // datatype variableName = initial value;
double sum = 0; // datatype variableName = initial value;
string userInput = Console.ReadLine(); // read as string 
myNumber = double.Parse(userInput); // convert string to int 


// can convert int tot double - cannot double to int
// double myNumber = 0.0; 




Console.WriteLine("Please enter another whole number:");
userInput = Console.ReadLine(); // read as string 
myNumber2 = double.Parse(userInput); // convert string to int

sum = myNumber + myNumber2; // add two numbers together to get the sum
Console.WriteLine("The result of " + myNumber + " and " + myNumber2 + " is " + sum); // display number


// string interpolation
Console.WriteLine($"The result of {myNumber} and {myNumber2} is {sum}");

Console.ReadKey();