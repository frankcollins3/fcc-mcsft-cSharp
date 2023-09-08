using System;

class Program {
    static void Main()
    {

    int heroHealth = 10;
    int monsterHealth = 10;

    void attack(string character) 
    {
        Random randomStr = new Random();
        int attackStr = randomStr.Next(0, 10);
        Console.WriteLine($"the attack did: \t {attackStr} damage");

        // hero is attacking the monster
        if (character.Contains("hero")) {
            monsterHealth -= attackStr;
            Console.WriteLine($"the monsters health bar is down to: \t {monsterHealth}");
        } else {
            heroHealth -= attackStr;
            Console.WriteLine($"our hero health bar now down to: \t {monsterHealth}");            
        // monster is attacking the hero.
        }
    }

    void alternateAttacks()
    {
        attack("hero");
        attack("monster");
    }

    do {
        alternateAttacks();
    }while(heroHealth > 0 || monsterHealth > 0);

    }   

}


