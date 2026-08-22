
#region
// 1. Write a program that allows the user to enter a number then print it. 

//Console.Write("Enter a number: ");
//int number = int.Parse(Console.ReadLine());
//Console.WriteLine("You entered: " + number);

#endregion

#region

// 2. Write C# program that Convert a string to an integer, but the string contains non-numeric characters. And mention what will happen   

Console.WriteLine("Enter a string:");
try
{
    int input = int.Parse(Console.ReadLine());
    Console.WriteLine(input);
}
catch(FormatException)
{
    Console.WriteLine("Input string is not a valid integer.");
}

#endregion