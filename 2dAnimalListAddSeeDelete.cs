// this is basically the ${company} take home assignment for C but without structs and linked lists.
// recursively show_list(), addToList(), deleteFromList(), based on *pointer being y (n or any other character invalidates while block and ends the program);

using System;

class Program {

    // this app will feature callback functions that allow the user to decide which features of the app they will access based on input.
    
    // global variables so the callbacks have access to them.


    static void Main()
    {

    string[][] ourAnimals = new string[20][];    
    ourAnimals[0] = new string[] {"1", "cat", "7", "stubby, gray tabby with snowboot feet", "lazy, fussy, playful, explorative", "xena"};
    ourAnimals[1] = new string[] {"2", "sharpei-cockerspaniel", "8", "sharpei in the face. cockerspaniel ears.", "protective couch potato that loves ripping toys", "loki"};
    ourAnimals[2] = new string[] {"3", "cat", "5", "standard housecat", "fun. snugglesome. careful: loves headphones / wires", "mystic"};

    void showPets()
    {
    foreach(string[] animals in ourAnimals)
    {
        Console.WriteLine("heres a pet:");
        foreach(string trait in animals) 
        {
            if (trait != null) {
            Console.WriteLine(trait);
            }
        }
    }
    }

    void evaluateInput(string input)
    {
        switch(input)
        {
            case "see":
                showPets();
                break;

            // case "add"
            // addPets();
            // break:
        }
    }
    
    // programRestart:
    string? animalActions;
    bool loop = true;

    while(loop)
    {   
        loopRestart:
        Console.WriteLine("Welcome to Well Vetted! How can we Help You? Enter into the input:");
        Console.Write("'see': \t show animals \n");

        animalActions = Console.ReadLine();
        Console.WriteLine($"human entered: \t {animalActions}");
        // Console.Write("'see': \t show animals \n");
        evaluateInput(animalActions);


    }
    // Pet ID #.    // Pet species (cat or dog).        // Pet age (years).     // description of cat / dog characteristics
    // A description of the pet's personality.          // The pet's nickname.

    }
   

}
