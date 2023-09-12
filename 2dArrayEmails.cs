using System;

class Program
{
    static void Main()
    {   


    
        string[,] corporate = 
    {
        {"Robert", "Bavin"}, {"Simon", "Bright"},
        {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
        {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
    };

    string[,] external = 
    {
        {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
        {"Shay", "Lawrence"}, {"Daren", "Valdes"}
    };

    string externalDomain = "hayworth.com";

    for (int i = 0; i < corporate.GetLength(0); i++) 
    {

        string firstName = corporate[i, 0].Substring(0, 2).ToLower();
        string lastName = corporate[i, 1].ToLower();
        string email = $"{firstName}{lastName}@contoso.com";
        Console.WriteLine(email);
    }

    for (int i = 0; i < external.GetLength(0); i++) 
    {
        // display external email addresses
        string firstName = external[i, 0].Substring(0, 2).ToLower();
        string lastName = corporate[i, 1].ToLower();
        string email = $"{firstName}{lastName}@hayworth.com";
        Console.WriteLine(email);
    }

    }
}
