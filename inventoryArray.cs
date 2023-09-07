using System;

class Program 
{
    static void Main() 
    {

                    // uninitialized array with reassignment
        // string[] fraudulentOrderIDs = new string[3];
        // fraudulentOrderIDs[0] = "A123";
        // fraudulentOrderIDs[1] = "B456";
        // fraudulentOrderIDs[2] = "C789";

                    // initialized array with values.
        // string[] fraudulentOrderIds = { "A777", "B999", "C1111" };

        // fraudulentOrderIDs[3] = "D000";
        // Console.WriteLine(fraudulentOrderIDs[0]);

        // Console.WriteLine($"length: {fraudulentOrderIds.Length} firstValue: {fraudulentOrderIds[0]}");

        // string[] pokemon = { "gastly", "haunter", "genghar" };

        // foreach (string poke in pokemon) 
        // {   
        //     Console.WriteLine($"ghost pokemon: {poke}");
        // }

                // simple array 
        // int[] inventory = { 200, 400, 750, 175, 250 };
        // int sum = 0; 

        // void loopAndPush() 
        // {
        //     foreach (int items in inventory) 
        //     {
        //         Console.WriteLine($"item: {items}");
        //         sum += items;
        //     }
        // }

        // void getSum()
        // {
        //     Console.WriteLine($"nice weve got some {sum} items");
        // }

        // loopAndPush();
        // getSum();

        // string[] inventory = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };
        
        // foreach(string i in inventory)
        // {
        //     if (i.StartsWith("B")) {
        //         Console.WriteLine($"Starts with B: {i}");
        //     }
        // }

        
        string str = "the overweight frog hopped over the bog";
        // turns the string into:           ['t', 'h', 'e', 'o', 'v', 'e', 'r', {...rest_of_str} ];
        char[] charMsg = str.ToCharArray();
        // reverse the message.
        Array.Reverse(charMsg);
        int x = 0;

        // loop and increment x by 1 everytime the letter o is encountered during iteration.
        foreach(char i in charMsg) { if (i == 'o') { x++; } }

        // reassign reversed string 
        string new_message = new string(charMsg);
        Console.WriteLine(new_message);
        Console.WriteLine($"o appears: \t {x} times! ");

    }
}
