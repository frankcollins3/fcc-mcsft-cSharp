    using System;

    class Program {

        static void Main()
        {


        string kickflip = "kickflip";
        string shuvit = "pop shuvit";
        string treflip = string.Format("A 360 flip is technically 2: {0}s and a {1}", shuvit, kickflip);
        Console.WriteLine(treflip);

// In C#, an overloaded method is another version of a method with different or extra arguments that modify the functionality of the method slightly,
// as is the case with the overloaded version of the PadLeft() method.
        string input = "pad this";
        // Console.WriteLine(input.PadLeft(11);
        // Console.WriteLine(input.PadLeft(33), '-');
        // Console.WriteLine(input.PadLeft(33), '-');

        // Console.WriteLine(input.PadLeft(12, '-'));
        // Console.WriteLine(input.PadRight(12, '-'));

        Console.WriteLine(input.PadLeft(33, '*'));
        // Console.WriteLine(input.PadLeft(33, ':)'));          // lol.

    // Dear Ms. Barros,
    // As a customer of our Magic Yield offering we are excited to tell you about a new financial product that would dramatically increase your return.

    // Currently, you own 2,975,000.00 shares at a return of 12.75 %.

    // Our new product, Glorious Future offers a return of 13.13 %.  Given your current volume, your potential profit would be ¤63,000,000.00.

    // Here's a quick comparison:

    // Magic Yield         12.75 %   $55,000,000.00      
    // Glorious Future     13.13 %   $63,000,000.00




        string customerName = "Ms. Barros";

        string currentProduct = "Magic Yield";
        int currentShares = 2975000;
        decimal currentReturn = 0.1275m;
        decimal currentProfit = 55000000.0m;

        string newProduct = "Glorious Future";
        decimal newReturn = 0.13125m;
        decimal newProfit = 63000000.0m;

        // Your logic here

        Console.WriteLine("Here's a quick comparison:\n");

    // mine
    Console.WriteLine($"Dear {customerName},");
    Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return");
    Console.WriteLine($"Currently, you own {currentShares:C} shares at a return of {currentReturn:N2}");
    Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn}. Given your current volume, your potential profit would be {newProfit}");

    // Console.WriteLine($"Dear {customerName},");
    // Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
    // Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P}.\n");
    // Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P}.  Given your current volume, your potential profit would be {newProfit:C}.\n");

    // Console.WriteLine("Here's a quick comparison:\n");

    // string comparisonMessage = "";

    // comparisonMessage = currentProduct.PadRight(20);
    // comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
    // comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(20);

    // comparisonMessage += "\n";
    // comparisonMessage += newProduct.PadRight(20);
    // comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
    // comparisonMessage += String.Format("{0:C}", newProfit).PadRight(20);

    // Console.WriteLine(comparisonMessage);


        // string comparisonMessage = "";



        }
    }
