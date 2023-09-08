using System;

class Program {
    static void Main()
    {

    string? readResult;
    // do
    // {
    //     Console.WriteLine("Enter a string:");
    //     readResult = Console.ReadLine();
    // } while (readResult.Contains("frog"));
    // cool frog () => tree frog () => frag grenade {break};

    int numericValue = 0;
    do
    {
    Console.WriteLine("enter number please!");
    readResult = Console.ReadLine();    
    // int numericValue = 0;            // if numericValue is declared here the { while block } won't have access to it.
    bool validNumber = false;
    validNumber = int.TryParse(readResult, out numericValue);
    Console.WriteLine($"numericValue: \t {numericValue}. validNumber: \t {validNumber}");
    } while (numericValue < 777);

    
        // If the string value assigned to readResult represents a valid integer, the value will be assigned to the integer variable named numericValue, 
        // and true will be assigned to the Boolean variable named validNumber. 
        // If the value assigned to readResult does not represent a valid integer, validNumber will be assigned a value of false. 
        // For example, if readResult is equal to "7", the value 7 will be assigned to numericValue.

    }   

}


