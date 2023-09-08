using System;

class Program {
    static void Main()
    {

    //  { i = 0: initializer }       { i < 9: the "condition" }      { i++ :     the iterator }
    for (int i = 0; i < 9; i++) {
        Console.WriteLine($"index: \t {i}");
    }

    // decrement code specified by -= 3 
    for (int i = 9; i >= 3; i -= 3) {
        Console.WriteLine($"decrement index: \t {i}");
    }

    // break statement
    for (int i = 0; i < 11; i++) {
        Console.WriteLine(i);
        if (i == 7) break;
    }

    // string[] burgers = { "whopper", "daves double", "baconator", "big mac" };
    // int b = burgers.Length - 1;
    // for (int i = burgers.Length - 1;  i > 0; i--) {
    // // for (b; b >= 0; b--) {
    //     Console.Write(burgers[i]);
    //     Console.Write("\t");
    // }

    string[] names = { "henry", "becca", "johnny", "sal" };

    // updating the value of an index item while in the loop. have to do this at the index.             NOT:    if (names == "becca") names = "rebecca"; has to be names[i]!!!!
    for (int i = 0; i < names.Length; i++) 
    {
        //  1 liner. no brackets. if it increases readability... do it!
        if (names[i] == "becca") names[i] = "rebecca";
    }

        // don't forget the use of var.
    foreach(var name in names) 
    {
        Console.WriteLine(name);
    }
    

    }

}
