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

// int invoiceNumber = 1201;
        // decimal productShares = 25.4568m;
        // decimal subtotal = 2750.00m;
        // decimal taxPercentage = .15825m;
        // decimal total = 3185.19m;

        // Console.WriteLine($"Invoice Number: {invoiceNumber}");
        // Console.WriteLine($"   Shares: {productShares:N3} Product");
        // Console.WriteLine($"     Sub Total: {subtotal:C}");
        // Console.WriteLine($"           Tax: {taxPercentage:P2}");
        // Console.WriteLine($"     Total Billed: {total:C}");
