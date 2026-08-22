

#region
// 1. Write a program that allows the user to enter a number then print it. 

//Console.Write("Enter a number: ");
//int number = int.Parse(Console.ReadLine());
//Console.WriteLine("You entered: " + number);

#endregion

#region

// 2. Write C# program that Convert a string to an integer, but the string contains non-numeric characters. And mention what will happen   

//Console.WriteLine("Enter a string:");
//try
//{
//    int input = int.Parse(Console.ReadLine());
//    Console.WriteLine(input);
//}
//catch(FormatException)
//{
//    Console.WriteLine("Input string is not a valid integer.");
//}

// In this case, if the user enters a string that contains non-numeric characters, the program will throw a FormatException and display the message "Input string is not a valid integer."

#endregion



#region
// 3. Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen 

Console.Write("Enter a floating-point number:");
float  num = float.Parse(Console.ReadLine());

float operation = num + 0.1f;
Console.WriteLine(operation.ToString("G9"));
Console.WriteLine("Result of the operation: " + operation);

// float may store decimal values as approximate binary values, so small precision differences can sometimes occur.
#endregion