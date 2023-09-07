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
        


    }
}  
