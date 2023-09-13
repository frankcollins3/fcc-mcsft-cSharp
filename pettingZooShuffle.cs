// this approach seems similar to reassigning pointer links in C

using System;

class Program
{
    static void Main()
    {  

    string[] pettingZoo = 
    {
        "alpacas", "capybaras", "chickens", "ducks", "emus", "geese", 
        "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws", 
        "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
    };



    RandomizeAnimals();
    // string[,] group = AssignGroup();
    Console.WriteLine("School A");
    // PrintGroup(group);

    void RandomizeAnimals() 
    {
        Random random = new Random();

        for (int i = 0; i < pettingZoo.Length; i++) 
        {
            int r = random.Next(i, pettingZoo.Length);

            string temp = pettingZoo[r];
            pettingZoo[r] = pettingZoo[i];
            pettingZoo[i] = temp;
        }
    }

    foreach(string animal in pettingZoo) 
    {
        Console.WriteLine(animal);
    }

    }
}


                // initial shuffle
/*
    void RandomizeAnimals() 
    {
    // Console.WriteLine("randomize animals");
    Random random = new Random();

    int i = 0;
    int r = random.Next(pettingZoo.Length);

    string temp = pettingZoo[i];
    pettingZoo[i] = pettingZoo[r];
    pettingZoo[r] = temp;
    }
*/

                // for loop
/*
    void RandomizeAnimals() 
    {
    
    Random random = new Random();

    for (int i = 0; i < pettingZoo.Length; i++) 
    {
        int r = random.Next(pettingZoo.Length);

        string temp = pettingZoo[i];
        pettingZoo[i] = pettingZoo[r];
        pettingZoo[r] = temp;
    }

    }
*/

                // 
/*
    void RandomizeAnimals() 
    {
    
    Random random = new Random();

    for (int i = 0; i < pettingZoo.Length; i++) 
    {        
        int r = random.Next(i, pettingZoo.Length);      // updated from int r = random.Next(pettingZoo.Length) to improve the distribution of randomly selected elements by updating range as [i}+1

        string temp = pettingZoo[i];
        pettingZoo[i] = pettingZoo[r];
        pettingZoo[r] = temp;
    }
    Now, as you iterate through the for loop, you update the range of the randomly selected index to exclude values less than i. 
    This is because indices at values less than i have already been swapped in previous iterations of the loop.

    }
*/

