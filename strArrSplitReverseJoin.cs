    using System;

    class Program {

        // this app will feature callback functions that allow the user to decide which features of the app they will access based on input.
        
        // global variables so the callbacks have access to them.


        static void Main()
        {

        // string value = "abc123";
        // char[] valueArray = value.ToCharArray();
        // // Array.Reverse(valueArray)
        // string result = String.Join(",", valueArray);
        // // string result = new string(valueArray);
        // Console.WriteLine(result);

        // string[] items = result.Split(",");
        // foreach(string item in items)
        // {
        //     Console.Write($"{item} \t");
        //     // Console.WriteLine(item);
        // }


        //  This is a particularly difficult challenge. You will need to combine many of the concepts you learned in this exercise, including the use of the:
        //  Split(), ToCharArray(), Array.Reverse(), and String.Join(). 
        //  You'll also need to create multiple arrays, and at least one iteration statement.

        // string[] wordBucket = new string[];

        string pangram = "The quick brown fox jumps over the lazy dog";

        // first split the string so that the original str is an array of words.


        void reverseWord(string word) 
        {
            // already looping. the word is every iteration in the pangram string that is turned to a split array below. each word becomes it's own array.
            char[] valueArray = word.ToCharArray();
            //  reverse that word array so:                 'the', -> 'quick', -> 'brown' ... each word. which becomes the parameter.
            Array.Reverse(valueArray);
            // store the Conversion of array of characters back to a string after reversing. Type as a string of course.
            string result = string.Join("", valueArray);
            // Console.WriteLine($"reverse-word: \t {reverseWord}");

            // split the array again because we can't log a whole array (given my current xp & knowledge of arrays)
            string[] items = result.Split("");
            // loop over the array of strings so we can log each item.
            foreach(string item in items)
            {
                Console.Write($"{item} \t");
            }
        }

        // split the string so we can loop over every item in that string (which is now an array of strings)
        string[] splitPangram = pangram.Split(" ");
        foreach(string str in splitPangram)
        {            
            // invoke the callback function above.
            reverseWord(str);
        }

        }
    }

    // Can you remove null elements from an array?
    // If the Array.Resize() method doesn't remove empty elements from an array, is there another helper method that will do the job automatically? 
    // No. The best way to empty elements from an array would be to count the number of non-null elements by iterating through each item and increment a variable (a counter). 
    // Next, you would create a second array that is the size of the counter variable. Finally, you would loop through each element in the original array and copy non-null values into the new array.


    // Recap
    // Use the Clear() method to empty the values out of elements in the array.
    // Use the Resize() method to change the number of elements in the array, removing or adding elements from the end of the array.
    // New array elements and cleared elements are null, meaning they don't point to a value in memory.
