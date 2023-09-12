using System;

class Program
{
    static void Main()
    {   

    // string input = "there are snakes at the zoo";
    string input = "is that a bear in the woods";

    Console.WriteLine(input);
    Console.WriteLine(ReverseSentence(input));

    string ReverseSentence(string input) 
    {
        string result = "";
        string[] words = input.Split(" ");
        foreach(string word in words) 
        {
            result += ReverseWord(word) + " ";
        }
        return result.Trim();
    }

    string ReverseWord(string word) 
    {
        string result = "";
        for (int i = word.Length - 1; i >= 0; i--) 
        {
            result += word[i];
        }
        return result;
    }

    }
}
