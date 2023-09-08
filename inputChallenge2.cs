using System;

class Program {
    static void Main()
    {

    // restart:
    Console.WriteLine("Please type your job title into the input: \t Administrator \t Manger \t User");
    // Console.WriteLine("Please Enter:" + "\t" "Administrator" + "\t" + "Manager" + "\t" + "User");
    string? inputJobTitle;
    // gather input to check if we will be looping or accepting the input.
        inputJobTitle = Console.ReadLine();
        Console.WriteLine($"human entered: \t {inputJobTitle}");
    while (inputJobTitle != "" && inputJobTitle != "Administrator" && inputJobTitle != "Manager" && inputJobTitle != "User") 
    {        
        inputJobTitle = Console.ReadLine();
        Console.WriteLine($"in the loop. entered: \t {inputJobTitle}");

        // goto restart;        
    }

    Console.WriteLine($"Job Title: \t {inputJobTitle}");
    char restartString;
    Console.WriteLine("Enter y to restart to beginning or any other character to exit");
    restartString = Console.ReadLine();
    Console.WriteLine($"Does the user want to rre")
    
}

}
