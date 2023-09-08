using System;

class Program {
    static void Main()
    {

        string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
        string[] myString = myStrings[0].Split(".");
        // split the [0] index by the period.
        Console.WriteLine($"0: {myString[0]}, 1: {myString[1]}, 2: {myString[2]}");
        // extra variable for outer loop because the first argument will always be true. also check for boolean truthiness to continue looping. toggle false to stop looping.
        bool loop = true;
        do
        {
            int index = Array.IndexOf(myString, ".");
            // this sets loop to false if (index != -1);
            loop = (index != -1);

            foreach(string str in myString)
            {
                Console.WriteLine(str.TrimStart());
                // Console.WriteLine(str.Remove(".").TrimStart());
            }
            Console.WriteLine(myStrings[1]);


        }
        while(loop);
        // while(loop);
    }

}
