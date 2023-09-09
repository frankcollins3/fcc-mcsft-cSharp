// better as .md file. nothing but a bunch of notes. 
using System;

class Program {

    // this app will feature callback functions that allow the user to decide which features of the app they will access based on input.
    
    // global variables so the callbacks have access to them.


    static void Main()
    {

        // Console.WriteLine("");
        // Console.WriteLine("Unsigned integral types:");

        // Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
        // Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
        // Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
        // Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

        Console.WriteLine("");
        Console.WriteLine("Floating point types:");
        Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
        Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
        Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");

        // reference types: whenever you see the "new" keyword, its pointing to a reference type. Also strings are reference types.
        

    }
}

// A floating-point type is a simple value data type that can hold fractional numbers.
// Choosing the right floating-point type for your application requires you to consider more than just the maximum and minimum values that it can hold. 
// You must also consider how many values can be preserved after the decimal, how the numbers are stored, and how their internal storage affects the outcome of math operations.
// Floating-point values can sometimes be represented using "E notation" when the numbers grow especially large.
// There's a fundamental difference in how the compiler and runtime handle decimal as opposed to float or double, especially when determining how much accuracy is necessary from math operations.


//          value:                  "stack"
// A value type variable stores its values directly in an area of storage called the stack. 
// The stack is memory allocated to the code that is currently running on the CPU (also known as the stack frame, or activation frame). 
// When the stack frame has finished executing, the values in the stack are removed.

//         reference:              "heap"
// A reference type variable stores its values in a separate memory region called the heap. 
// The heap is a memory area that is shared across many applications running on the operating system at the same time. 
// The .NET Runtime communicates with the operating system to determine what memory addresses are available, and requests an address where it can store the value. 


//                  data:
                    // int[] data;
// defines a variable that can hold a value of type int array.
// At this point, data is merely a variable that could hold a reference, or rather, a memory address of a value in the heap. 
// Because it's not pointing to a memory address, it's called a null reference.

                    // int[] data;
                    // data = new int[3];
// The new keyword informs .NET Runtime to create an instance of int array, and then coordinate with the operating system to store the array sized for three int values in memory. 
// The .NET Runtime complies, and returns a memory address of the new int array. 
// Finally, the memory address is stored in the variable data. The int array's elements default to the value 0, because that is the default value of an int.

                    //  strings
// The string data type is also a reference type. You might be wondering why a new operator wasn't used when declaring a string.
// This is purely a convenience afforded by the designers of C#. Because the string data type is used so frequently, you can use this format:


//                  what data type for what situation?

// int for most whole numbers
// decimal for numbers representing money
// bool for true or false values
// string for alphanumeric value
// Choose specialty complex types for special situations
// Don't reinvent data types if one or more data type already exists for a given purpose. The following examples identify where a specific .NET data types can be useful:

// byte: working with encoded data that comes from other computer systems or using different character sets.
// double: working with geometric or scientific purposes. double is used frequently when building games involving motion.
// System.DateTime for a specific date and time value.
// System.TimeSpan for a span of years / months / days / hours / minutes / seconds / milliseconds.
