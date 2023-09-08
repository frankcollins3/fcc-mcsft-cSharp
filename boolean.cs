using System;

class Program {
    static void Main()
    {
        // Console.WriteLine("a" == "A");
        // Console.WriteLine("b" == "B");
        // Console.WriteLine("c" == "C");

        // string value = "a";
        // Console.WriteLine($"are a equal ? {"a " == value}");

        // string value1 = " a";
        // string value2 = "A ";
        // Console.Write("\n");
        // Console.Write($"checking if they are equal: \t {value1.Trim().ToLower() == value2.Trim().ToLower()}");

        // string swampMsg = "the overweight frog hopped over the bog";
        // bool checkSwamp;

        // void checkSwampFunc()
        // {
        // if (swampMsg.Contains("frog")) {
        //     checkSwamp = true;
        // } else {
        //     checkSwamp = false;
        // }
        // }

        // checkSwampFunc();

        // void returnMsg()
        // {
        //     if (checkSwamp) {
        //         Console.WriteLine($"swamp: \t {checkSwamp}");
        //         if (!checkSwamp == false) {
        //             Console.WriteLine("saying the same thing twice");
        //         }
        //     } else {
        //         Console.WriteLine("No swamp!");
        //     }
        // }

        // returnMsg();

        // int daySales = 1001;
        // string discount = daySales > 1000 ? "10%" : "no discount";
        // Console.WriteLine($"She can't wait to save a discount of: \t {discount}");

        Random coinBoolean = new Random();
        int coinFlip = coinBoolean.Next(1, 10); // .Next(1,2) returned heads 5x in a row. changing to modular returned: "heads" -> "tails"
        string coin = coinFlip % 2 == 0 ? "heads" : "tails";
        Console.WriteLine($"heads or tails ? \t {coin}");
        
                string permission = "Admin|Manager";
        int level = 55;

        int suzy = 20;
        int steve = 61;
        int betty = 5;

        int[] levelsArray = new int[4];
        levelsArray[0] = 777;
        levelsArray[1] = suzy;
        levelsArray[2] = steve;
        levelsArray[3] = betty;

        string[] nameArray = new string[3];
        nameArray[0] = "suzy";
        nameArray[1] = "steve";
        nameArray[2] = "betty";    

        void checkLevel(int lvl, int index)
        {
            string employee = index == 1 ? "suzy" : index == 2 ? "steve" : "betty";
            if (lvl > 55) {
                Console.WriteLine($"{employee}: \t level: Super User Admin");
            } else if (lvl <= 55 && lvl > 20 ) {
                Console.WriteLine($"{employee}: \t is an Admin");
            } else if (lvl < 20) {
                Console.WriteLine($"{employee} does not have sufficient privileges");
            } else {
                Console.WriteLine("no employee found!");
            }
        }

        for (int i = 0; i < levelsArray.Length; i++) {
            checkLevel(levelsArray[i], i);
        }

    }
}  
