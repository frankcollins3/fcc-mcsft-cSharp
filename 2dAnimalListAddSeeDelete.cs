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
        if (animals != null) 
        {
        Console.WriteLine("heres a pet:");
        foreach(string trait in animals) 
            
        {
            if (trait != null) 
            {
            Console.WriteLine(trait);
            } else 
            {
                // return;
                Console.WriteLine("\t");
            }
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
        ourAnimalsIndex++;        
    }

    void deletePet()    
    {
    string? nameOfPet;
    Console.WriteLine("Whats the name of the pet you want to delete?");
    nameOfPet = Console.ReadLine();

        for (int i = 0; i < ourAnimals.Length; i++) {
                   if (ourAnimals[i] != null && ourAnimals[i].Length > 5 && ourAnimals[i][5] == nameOfPet)
        {
            Console.WriteLine($"name: \t {nameOfPet}");
            ourAnimals[i] = null;
            // Possibly delete every endpoint besides name to mention the pet that was there.
            // In a full app, you could also keep the date it was deleted and no longer provide the name after a certain period.
        }
    }
    }

// In this updated version, before checking if ourAnimals[i][5] is equal to nameOfPet, it first checks if ourAnimals[i] is not null and whether it has at least 6 elements (to ensure there's an element at index 5). This should prevent the NullReferenceException from occurring when you attempt to access elements that may be null.
    void editPet() 
    {
        // age, personality description.
        string? nickname;
        Console.WriteLine("what is the name of the pet we will be updating?");
        nickname = Console.ReadLine();
        string? endpoint;
        Console.WriteLine("will you be editing: \t 'age' ? 'personality'?");
        endpoint = Console.ReadLine();
        string? updateText;
        Console.Write($"Welcome! Looks like You'll be editing {nickname}s \t {endpoint}. what will the new info be? \n");
        updateText = Console.ReadLine();
        for (int i = 0; i < ourAnimals.Length; i++) {
            if (ourAnimals[i] != null && ourAnimals[i].Length > 5) 
            {                
            if (ourAnimals[i][5] == nickname) {
                string[] editPet = ourAnimals[i];
                if (endpoint == "age") {
                    editPet[2] = updateText;
                } else if (endpoint == "personality") {
                    editPet[4] = updateText;
                }
            }
            }
        }
    }

    void enforceAgeAndPersonality()
    {
            Console.Write("running enforce function \n");
        for(int i = 0; i < ourAnimals.Length; i++) {
            if (ourAnimals[i] != null) {
            // if (ourAnimals[i] != null && ourAnimals[i].Length > 5) {

// ourAnimals[2] = new string[] {"3", "cat", "5", "standard housecat", "fun. snugglesome. careful: loves headphones / wires", "mystic"};
                string[] petIndex = ourAnimals[i];
                if (petIndex[2] == null || petIndex[2].Length < 1) {
                    Console.WriteLine($"We need to update: \t {petIndex[5]}s Age. Please update the age:");
                    string? ageUpdate;
                    ageUpdate = Console.ReadLine();
                }
                if (petIndex[4] == null || petIndex[4].Length < 4) {
                    Console.WriteLine($"We need to update: \t {petIndex[5]}s Personality. Please update the Personality:");
                    string? personalityUpdate;
                    personalityUpdate = Console.ReadLine();
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

            case "add":
                addPets();
                break;

            case "delete":
                deletePet();
                break;
            
            case "edit":
                editPet();
                break;
        }
        enforceAgeAndPersonality();
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
        Console.Write("'delete': \t give a pet a new home \n");
        Console.Write("'edit': \t update a pet's info \n");

        animalActions = Console.ReadLine();
        Console.WriteLine($"human entered: \t {animalActions}");
        // Console.Write("'see': \t show animals \n");
        evaluateInput(animalActions);
        // enforceAgeAndPersonality();


    }
    // Pet ID #.    // Pet species (cat or dog).        // Pet age (years).     // description of cat / dog characteristics
    // A description of the pet's personality.          // The pet's nickname.

    }
}
