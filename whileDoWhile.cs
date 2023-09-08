  
// The flow of execution starts inside of the curly brace. 
// The code executes at least one time, then the Boolean expression next to the while keyword is evaluated. 
// If the Boolean expression returns true, the code block is executed again.

    Random randomVal = new Random();
    int current = 0; 
    int niner = 9;

    // do
    // {
    //     current = randomVal.Next(3, 9);
    //     Console.Write($"wave to the: \t {current}");     
    //     Console.Write("\n");
    // } while(current != 6);

    // do 
    // {
    //     niner--;
    //     Console.Write($"countdown: \t {niner}");
    //     Console.Write("\n");
    // }while(niner >= 6);

    // In certain cases, we want to short-circuit the remainder of the code in the code block and continue to the next iteration. We can do that using the continue statement.

    // do 
    // {
    //     current = randomVal.Next(3, 11);

    //     if (current >= 8) continue;
    //     Console.WriteLine(current);

    // }while(current != 7);

    while (current != 7) 
    {
        Console.WriteLine(current);
        current = randomVal.Next(3, 11);

    }
    // once 7 is reached the loop "jumps" out of the while { } block of code and executes down here, no longer within the iteration execution.
    Console.WriteLine($"last: \t {current}");
    }   
