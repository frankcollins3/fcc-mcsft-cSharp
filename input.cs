using System;

class Program {
    static void Main()
    {

        // # # # challenge # 1: 
            Console.WriteLine("please enter / keep entering integer input between 5 && 10");
    int number = 0;
    string? readInput;
    bool repeat = true;
    do
    {
        Console.Write("int: \n");
        bool validNumber = false;
        readInput = Console.ReadLine();       
        validNumber = int.TryParse(readInput, out number);

        if (number % 2 == 0) {
            Console.WriteLine($"nice odd number: \t {number}");
            if (number > 5 && number < 10) repeat = false;
        } else {
        Console.WriteLine($"number: \t {number} readInput: \t {readInput} validNumber: \t {validNumber}");
            if (number > 5 && number < 10) repeat = false;
        }
    } while(repeat == true); 

    }   

    }   

}


    string? readResult;
    // do
    // {
    //     Console.WriteLine("Enter a string:");
    //     readResult = Console.ReadLine();
    // } while (readResult.Contains("frog"));
    // cool frog () => tree frog () => frag grenade {break};

    // int numericValue = 0;
    // do
    // {
    // Console.WriteLine("enter number please!");
    // readResult = Console.ReadLine();    
    // // int numericValue = 0;            // if numericValue is declared here the { while block } won't have access to it.
    // bool validNumber = false;
    // validNumber = int.TryParse(readResult, out numericValue);
    // Console.WriteLine($"numericValue: \t {numericValue}. validNumber: \t {validNumber}");
    // } while (numericValue < 777);

    
        // If the string value assigned to readResult represents a valid integer, the value will be assigned to the integer variable named numericValue, 
        // and true will be assigned to the Boolean variable named validNumber. 
        // If the value assigned to readResult does not represent a valid integer, validNumber will be assigned a value of false. 
        // For example, if readResult is equal to "7", the value 7 will be assigned to numericValue.
