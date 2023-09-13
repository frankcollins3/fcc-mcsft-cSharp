using System;

class Program
{
    static void Main()
    {  

    Random random = new Random();
    string? playStr;
    bool play = true;

    
    int wins = 0; 
    int losses = 0; 
    int streak = 0; 

        void AskToPlay()
        {
        Console.WriteLine("Would you like to play? (y/n)");

        playStr = Console.ReadLine();
            if (playStr.ToLower() == "n") {
        play = false;
        }
        }
    doOver:

    while (play) 
    {
        AskToPlay();

        int target = random.Next(0, 6);
        int diceRoll = random.Next(0, 6);
        Console.WriteLine($"You must Roll greater than: \t {target} to win!");
            if (diceRoll > target) 
        {
            wins += 1;
            Console.WriteLine($"Human won: \t {wins} times!");
            streak += 1;
        } 
            else if (diceRoll < target) 
        {
                if (streak > 0) 
            {
            Console.WriteLine("back to start!");    
            streak = 0; 
            losses += 1;
            }
        } 
            else 
        {
            Console.WriteLine("Tie game! Do-Over!");
            goto doOver;
        }

    }

    // if (ShouldPlay()) 
    // {
    //     PlayGame();
    // }

    // void PlayGame() 
    // {
    //     var play = true;

    //     while (play) 
    //     {
    //         var target;
    //         var roll;

    //         Console.WriteLine($"Roll a number greater than {target} to win!");
    //         Console.WriteLine($"You rolled a {roll}");
    //         // Console.WriteLine(WinOrLose());
    //         Console.WriteLine("\nPlay again? (Y/N)");

    //         play = ShouldPlay();
    //     }
    // }

    }
}
