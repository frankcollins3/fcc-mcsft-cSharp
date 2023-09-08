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
        // Console.WriteLine($"the attack did: \t {attackStr} damage");

        // hero is attacking the monster
        if (character.Contains("hero")) {
// if the monsterHealth - attackStr makes the monsterHealth less than 0, than reassign monsterHealth value to be 0. if not, just decrement monsterHealth by attackStr (randomvalue)
            monsterHealth = (monsterHealth - attackStr < 0) ? 0 : (monsterHealth -= attackStr);
            // monsterHealth = (monsterHealth -= attackStr < 0) ? 0 : -= attackStr;
            // monsterHealth -= attackStr;
            Console.WriteLine($"the monsters health bar is down to: \t {monsterHealth} after being hit for: \t {attackStr}");
        } else {
            heroHealth = (heroHealth - attackStr < 0) ? 0 : (heroHealth -= attackStr);
            // heroHealth -= attackStr;
            Console.WriteLine($"our hero health bar now down to: \t {monsterHealth} since the monster hit a: \t {attackStr} ");            
        // monster is attacking the hero.
        }
    }

    void alternateAttacks()
    {   
        // named somewhat poorly. the hero is the one doing the attacking in the first invocation of attack() could look like it's saying attack the hero.
        if (monsterHealth > 0) attack("hero");
        if (heroHealth > 0) attack("monster");
        // attack("hero");
        // attack("monster");
    }

    do {
        alternateAttacks();
    }while(heroHealth > 0 || monsterHealth > 0);

    }   

}
