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

    // Random level = new Random();
    // int randomLevel = level.Next(0, 4);
    // Console.WriteLine($"randomLevel: \t {randomLevel}");

    // string title = "";

    // switch(randomLevel)
    // {
    //     case 1:
    //     title = "Junior Associate";
    //     break;

    //     case 2:
    //     title = "Senior Associate";
    //     break;

    //     case 3:
    //     title = "Manager";
    //     break;

    //     case 4: 
    //     title = "Senior Manager";
    //     break;

    //     default:
    //     title = "Waterboy";
    //     break;
    // }

    // Console.WriteLine($"Not another person being promoted to {title}!!");

        string sku = "02-WH-S";
// splitting the sku string which types it as an array of strings separated by dashes in this cas.e
string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

switch(product[0]) 
{
    case "01":
    type = "Sweat Shirt";
    break;
    case "02":
    type = "T-Shirt";
    break;
    case "03":
    type = "Sweat Pants";
    break;
}

switch(product[1])
{
    case "BL":
    color = "Black";
    break;
    case "MN":
    color = "Maroon";
    break;
    case "WH":
    color = "White";
    break;
}

switch(product[2])
{
    case "S":
    size = "Small";
    break;
    case "M":
    size = "Medium";
    break;
    case "L":
    size = "Large";
    break;
}
    Console.WriteLine($"Guys here's our new product: \t {type} {color} {size}");

    }
}
