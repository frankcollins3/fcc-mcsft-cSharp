using System;

class Program {
    /* 
This code uses a names array and corresponding methods to display
greeting messages
*/
static void Main()
{

try
{
    Process1();
}
catch
{
    Console.WriteLine("An exception has occurred");
}


static void Process1()
{
    try {
    WriteMessage();
    }
    catch (Exception ex) {
    ErrorMessage(ex);
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

static void ErrorMessage(Exception err)
{
    Console.WriteLine($"weve got an error: {err.Message}");

    Console.WriteLine($"source {err.Source}");  // TestProject (name of file)
    Console.WriteLine($"TargetSite {err.TargetSite}");  // Name of method that throws the error:        source Void <Main>g__WriteMessage|0_1()
    Console.WriteLine($"Data {err.Data}");  // Name of method that throws the error:        source Void <Main>g__WriteMessage|0_1()
    Console.WriteLine($"HelpLink: \t  {err.HelpLink}");  // Name of method that throws the error:        source Void <Main>g__WriteMessage|0_1()
    Console.WriteLine($"HResult: \t  {err.HResult}");  // Name of method that throws the error:        source Void <Main>g__WriteMessage|0_1()
    Console.WriteLine($"InnerException: \t  {err.InnerException}");  // Name of method that throws the error:        source Void <Main>g__WriteMessage|0_1()
    // Console.WriteLine($"StackTrace: \t  {err.StackTrace}");  // Name of method that throws the error:        source Void <Main>g__WriteMessage|0_1()


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

            // properties of an exception class
// Data: The Data property holds arbitrary data in key-value pairs.
// HelpLink: The HelpLink property can be used to hold a URL (or URN) to a help file that provides extensive information about the cause of an exception.
// HResult: The HResult property can be used to access to a coded numerical value that's assigned to a specific exception.
// InnerException: The InnerException property can be used to create and preserve a series of exceptions during exception handling.
// Message: The Message property provides details about the cause of an exception.
// Source: The Source property can be used to access the name of the application or the object that causes the error.
// StackTrace: The StackTrace property contains a stack trace that can be used to determine where an error occurred.
// TargetSite: The TargetSite property can be used to get the method that throws the current exception.
