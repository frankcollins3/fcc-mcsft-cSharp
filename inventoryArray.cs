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

        int[] inventory = { 200, 400, 750, 175, 250 };
        int sum = 0; 

        void loopAndPush() 
        {
            foreach (int items in inventory) 
            {
                Console.WriteLine($"item: {items}");
                sum += items;
            }
        }

        void getSum()
        {
            Console.WriteLine($"nice weve got some {sum} items");
        }

        loopAndPush();
        getSum();


    }
}
