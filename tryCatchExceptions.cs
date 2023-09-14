using System;

class Program {
    /* 
This code uses a names array and corresponding methods to display
greeting messages
*/
static void Main()
{

// double float1 = 3000.0;
// double float2 = 0.0;
// int number1 = 3000;
// int number2 = 0;

// Console.WriteLine(float1 / float2);
//     try 
// {
// Console.WriteLine(number1 / number2);
// }
//     catch 
// {
// Console.WriteLine("cant catch me off guard yet!");
// }
// Console.WriteLine("Exit program");

try
{
    Process1();
}
catch
{
    Console.WriteLine("An exception has occurred");
}

Console.WriteLine("Exit program");

static void Process1()
{
    try {
    WriteMessage();
    }
    catch {
    ErrorMessage();
    }
}

static void WriteMessage()
{
    double float1 = 3000.0;
    double float2 = 0.0;
    int number1 = 3000;
    int number2 = 0;

    Console.WriteLine(float1 / float2);
    Console.WriteLine(number1 / number2);
}

static void ErrorMessage()
{
    Console.WriteLine("weve got an error");
}


}
/* 
This code uses a names array and corresponding methods to display
greeting messages
*/
}

//  VS code. uses the launch.json file to configure the debugger. if you use C# console application, it's likely that VScode generates a launch.json file with all needed debug code


// The launch.json file includes one or more launch configurations in the configurations list. The launch configurations use attributes to support different debugging scenarios. The following attributes are mandatory for every launch configuration:
// name: The reader-friendly name assigned to the launch configuration.
// type: The type of debugger to use for the launch configuration.
// request: The request type of the launch configuration.

// ArrayTypeMismatchException: Thrown when an array can't store a given element because the actual type of the element is incompatible with the actual type of the array.
// DivideByZeroException: Thrown when an attempt is made to divide an integral value by zero.
// FormatException: Thrown when the format of an argument is invalid.
// IndexOutOfRangeException: Thrown when an attempt is made to index an array when the index is less than zero or outside the bounds of the array.
// InvalidCastException: Thrown when an explicit conversion from a base type to an interface or to a derived type fails at runtime.
// NullReferenceException: Thrown when an attempt is made to reference an object whose value is null.
// OverflowException: Thrown when an arithmetic operation in a checked context overflows.


            // errors and exception objects
//  exception objects caught by your C# application are instances of an exception class
