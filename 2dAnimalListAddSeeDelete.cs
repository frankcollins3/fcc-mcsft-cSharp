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
            } else {
                // return;
                Console.WriteLine("\t");
            }
        }
    }
    }

    int getOurAnimalsLength()
    {   
        int totalPets = 0;
        foreach(string[] pets in ourAnimals)
        {
            if (pets != null) totalPets++;
        }
        return totalPets;
    }

    int ourAnimalsIndex = 0;

    void addPets()
    {
        // ourAnimals.Length + 1

        // Console.WriteLine("test");
        startover:
        string? species;
        string? age;
        string? features;
        string? personality;
        string? nickname;

        string? restart;
        Console.WriteLine("Please Enter cat or what kind of dog you have");
        species = Console.ReadLine();
        Console.WriteLine("How old is your pet?");
        age = Console.ReadLine();

        Console.WriteLine("What are the physical features of your pet?");
        features = Console.ReadLine();

        Console.WriteLine("Whats your pet's personality?");
        personality = Console.ReadLine();

        Console.WriteLine("What's your pet's name?");
        nickname = Console.ReadLine();

        Console.WriteLine($"{species} \t {age} \t {features} \t {personality} \t {nickname}");

        int totalPets = getOurAnimalsLength();

        Console.WriteLine($"totalPets: {totalPets}");

        ourAnimals[3] = new string[] {ourAnimals.Length.ToString(), species, age, features, personality, nickname};
        // ourAnimals[totalPets] = new string[] {ourAnimals.Length.ToString(), species, age, features, personality, nickname};
        
        // ourAnimals[ourAnimalsIndex] = new string[] {ourAnimals.Length.ToString(), species, age, features, personality, nickname};

        // iterate index for next pet.
        ourAnimalsIndex++;
        // ourAnimals[ourAnimals.length - 1] = new string[] {ourAnimals.length, species, age, features, personality, nickname};

        // Console.WriteLine("Is this correct? No to restart. Yes or any other character to add pet to our happy place!");

        // restart = Console.ReadLine();

        // if (restart == 'no') { 
        //     goto startover;
        // } else {
        // }
    }



    void evaluateInput(string input)
    {
        switch(input)
        {
            case "see":
                showPets();
                break;

            case "add":
                addPets();
                break;
        }
    }
    
    // programRestart:
    string? animalActions;
    bool loop = true;

    while(loop)
    {   
        Console.Write("\n \n");
        loopRestart:
        Console.WriteLine("Welcome to Well Vetted! How can we Help You? Enter into the input:");
        Console.Write("'see': \t show animals \n");
        Console.Write("'add': \t add your pet to our home \n");

        animalActions = Console.ReadLine();
        Console.WriteLine($"human entered: \t {animalActions}");
        // Console.Write("'see': \t show animals \n");
        evaluateInput(animalActions);


    }
    // Pet ID #.    // Pet species (cat or dog).        // Pet age (years).     // description of cat / dog characteristics
    // A description of the pet's personality.          // The pet's nickname.

    }
}
