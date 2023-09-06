using System;

class Program
{
    static Random dice = new Random();
    static int roll1 = dice.Next(1, 7);
    static int roll2 = dice.Next(1, 7);
    static int roll3 = dice.Next(1, 7);

    // Removed unused variables
    // int bonusPoints;
    // bool win;
    // bool lose;

    static int checkDoubleBonus()
    {
        if (roll1 == roll2 || roll1 == roll3 || roll2 == roll3)
        {
            return 2;
        }
        else
        {
            return 0;
        }
    }

    static int checkTripleBonus()
    {
        if (roll1 == roll2 && roll1 == roll3)
        {
            return 6;
        }
        else
        {
            return 0;
        }
    }

    static int PlayGame()
    {
        int doubles = checkDoubleBonus();
        int triples = checkTripleBonus();
        int gameCheck = doubles + triples + roll1 + roll2 + roll3;

        if (gameCheck >= 15)
        {
            Console.WriteLine($"You Win! roll1: {roll1} roll2: {roll2} roll3: {roll3} ----> doubles: {doubles} triples: {triples}");
        }
        else
        {
            Console.WriteLine($"You Lose! roll1: {roll1} roll2: {roll2} roll3: {roll3} ----> doubles: {doubles} triples: {triples}");
        }

        // The return statement should be the last statement in the method
        return gameCheck;
    }

    static void Main()
    {
        PlayGame();
    }
}
