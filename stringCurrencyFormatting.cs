    using System;

    class Program {

        static void Main()
        {

// Composite formatting uses numbered placeholders within a string. At run time, everything inside the braces is resolved to a value that is also passed in based on their position.
        // string first = "Goodbye";
        // string second = "Cruel World!";
        // string goodbye = string.Format("{0} {1}!", first, second);
        // Console.WriteLine(goodbye);
        // Console.WriteLine("{0} {0} {0}!", first, second);            // Goodbye Goodbye Goodbye!

        string[] pokemon = new string[3];
        pokemon[0] = "gastly";
        pokemon[1] = "haunter";
        pokemon[2] = "genghar";

        string ghostMsg = string.Format("{0} becomes {1}", pokemon[1], pokemon[2]);
        Console.WriteLine(ghostMsg);

        // formatting currency ($133.33) ($75.00)
        decimal price = 133.33m;
        int discount = 75;
        Console.WriteLine($"Price: {price:C} \t Discount: \t {discount:C}");
        // Price: 123,45 € (Save 50,00 €)

        }
    }
