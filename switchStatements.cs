using System;

class Program {
    static void Main()
    {

                // fruit in this case is the "Switch expression" the word that follows the switch statement
    // switch(fruit)
    // {
                // each "switch section" is defined by a case pattern
                // "case patterns" are constructed with the case keyword and a following value.
    //     case "watermelon":
    //     Console.WriteLine("cut up some watermelon please!");
    //     break;

    //     case "apple":
    //     Console.WriteLine("an apple a day...");
    //     break;

    //     case "orange":
    //     Console.WriteLine("you glad I didnt say...");
    //     break;

    //     case "banana":
    //     Console.WriteLine("This is bananas");
    //     break;
    // }

    Random level = new Random();
    int randomLevel = level.Next(0, 4);
    Console.WriteLine($"randomLevel: \t {randomLevel}");

    string title = "";

    switch(randomLevel)
    {
        case 1:
        title = "Junior Associate";
        break;

        case 2:
        title = "Senior Associate";
        break;

        case 3:
        title = "Manager";
        break;

        case 4: 
        title = "Senior Manager";
        break;

        default:
        title = "Waterboy";
        break;
    }

    Console.WriteLine($"Not another person being promoted to {title}!!");

    }
}
