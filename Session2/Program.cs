

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

//Console.Write("Enter a floating-point number:");
//float  num = float.Parse(Console.ReadLine());

//float operation = num + 0.1f;
//Console.WriteLine(operation.ToString("G9"));
//Console.WriteLine("Result of the operation: " + operation);

// float may store decimal values as approximate binary values, so small precision differences can sometimes occur.
#endregion

#region
// 4. Write C# program that Extract a substring from a given string. 

//string message = "Hello World!";  
//Console.WriteLine("the given string is " + message);
//Console.Write("Enter the chosen Word number:  ");

//int input = int.Parse(Console.ReadLine());

//if (input == 1)
//{
//    Console.WriteLine(message.Substring(0,5));
//}
//else if(input == 2)
//{
//    Console.WriteLine(message.Substring(6,5));

//}
//else
//{
//    Console.WriteLine("Invalid input");
//}
#endregion

#region
// 5. Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen 

//int number1 = 19;
//int number2 = number1;

//number2 = 10;
//Console.WriteLine(number1);
//Console.WriteLine(number2);

// Modifing the value of number2 does not affect number1 because they are value types and stored in different memory locations.
#endregion



#region
// 6. Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen 

//Student student1 = new Student();
//Student student2 = student1;

//student2.Name = "John";
//Console.WriteLine(student1.Name);
//Console.WriteLine(student2.Name);

// Modifying the object through student2 also affects student1 because They both reference the same object in memory.
#endregion

#region

// 7. Write C# program that take two string variables and print them as one variable  

//string firstText = "Hello";
//string secondText = "World";
//string combinedText = firstText + " " + secondText;
//Console.WriteLine(combinedText);

#endregion

#region

// 8. Which of the following statements is correct about the C#.NET code snippet given below? 

//int d = Convert.ToInt32(!(30 < 20));
//Console.WriteLine(d);

// Answer => (b) A value  1  will be assigned to  d

#endregion

#region

// 9. Which of the following is the correct output for the C# code given below? 

//Console.WriteLine(13 / 2 + " " + 13 % 2);

// Answer => (d) 6 1

#endregion


