using System;

class Program
{
    static void Main()
    {   

    // void Update();

    // int[] GetEnemyCoordinates(string enemyId);
    // int[] GetDistanceFromHero(string enemyId);
    // int[] GetHeroCoordinates();

    // bool EnemyCanHitHero(string enemyId);
    // int GetEnemyDamageOutput(string enemyId);
    // void UpdateHeroHP(int damage);

    double total = 0;
    double minimumSpend = 30.00;

    double[] items = {15.97, 3.50, 12.25, 22.99, 10.98};
    double[] discounts = {0.30, 0.00, 0.10, 0.20, 0.50};

        for (int i = 0; i < items.Length; i++)
    {
        total += GetDiscountedPrice(i);
    }

        if (TotalMeetsMinimum())
    {
        total -= TotalMeetsMinimum() ? 5.00 : 0.00;
        // total -= 5.00;   // ternary or this line of code do the same thing. 
    }


    Console.WriteLine($"Total: ${total}");


        double GetDiscountedPrice(int itemIndex)
    {
    double result = items[itemIndex] * (1 - discounts[itemIndex]);
    return result;
    }

        bool TotalMeetsMinimum()
    {
    return total >= minimumSpend;
    }

        string FormatDecimal(double input)
    {
    return input.ToString().Substring(0, 5);
    }



    }
}
