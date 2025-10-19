
var userInput = Console.ReadLine();

// default data type when we take input from user:
Console.WriteLine("Default data type of user input is: " + userInput.GetType()); // Output: System.String

// Working with data type string:
string stringData=" this is an introduction to C#, say hello world using c#";

// Operations on string data type using Library functions:

// Find length of string:
int lengthOfString = stringData.Length;
Console.WriteLine("Length of string is: " + lengthOfString);