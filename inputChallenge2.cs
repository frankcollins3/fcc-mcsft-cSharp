using System;

class Program {
    static void Main()
    {

    restart:
    Console.WriteLine("Please type your job title into the input: \t admin \t manager \t user");
    // Console.WriteLine("Please Enter:" + "\t" "Administrator" + "\t" + "Manager" + "\t" + "User");
    string? inputJobTitle;
    // gather input to check if we will be looping or accepting the input.
        inputJobTitle = Console.ReadLine();
        Console.WriteLine($"human entered: \t {inputJobTitle}");
    while (inputJobTitle.Trim().ToLower() != "" && inputJobTitle.Trim().ToLower() != "admin" && inputJobTitle.Trim().ToLower() != "manager" && inputJobTitle.Trim().ToLower() != "user") 
    {        
        inputJobTitle = Console.ReadLine();
        Console.WriteLine($"in the loop. entered: \t {inputJobTitle}");

        // goto restart;        
    }

    Console.WriteLine($"Job Title: \t {inputJobTitle}");
    string restartString;
    Console.WriteLine("Enter yes to restart to beginning or any other character to exit");
    restartString = Console.ReadLine();
    Console.WriteLine($"Does the user want to restart? {restartString}");
    if (restartString == "yes") {
        goto restart;
    } else {
        Console.WriteLine("Bye! thx for playing!");
    }
}

}
