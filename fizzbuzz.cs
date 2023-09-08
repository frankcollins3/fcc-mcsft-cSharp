using System;

class Program {
    static void Main()
    {

    for (int i = 0; i < 100; i++) 
    {
        if (i % 3 == 0) {
            Console.Write($"Fizz: \t {i}");
        }
        if (i % 5 == 0) {
            Console.Write($"Buzz: \t {i}");
        }
        if (i % 3 == 0 && i % 5 == 0) {
            Console.Write($"FizzBuzz: \t {i}");
        }
        Console.Write("\n");
    }
    

    }

}

// before break statement:
// Fizz: 	 0Buzz: 	 0FizzBuzz: 	 0


// Fizz: 	 3

// Buzz: 	 5
// Fizz: 	 6


// Fizz: 	 9
// Buzz: 	 10

// Fizz: 	 12


// Fizz: 	 15Buzz: 	 15FizzBuzz: 	 15


// Fizz: 	 18

// Buzz: 	 20
// Fizz: 	 21


// Fizz: 	 24
// Buzz: 	 25

// Fizz: 	 27


// Fizz: 	 30Buzz: 	 30FizzBuzz: 	 30


// Fizz: 	 33

// Buzz: 	 35
// Fizz: 	 36


// Fizz: 	 39
// Buzz: 	 40

// Fizz: 	 42


// Fizz: 	 45Buzz: 	 45FizzBuzz: 	 45


// Fizz: 	 48

// Buzz: 	 50
// Fizz: 	 51


// Fizz: 	 54
// Buzz: 	 55

// Fizz: 	 57


// Fizz: 	 60Buzz: 	 60FizzBuzz: 	 60


// Fizz: 	 63

// Buzz: 	 65
// Fizz: 	 66


// Fizz: 	 69
// Buzz: 	 70

// Fizz: 	 72


// Fizz: 	 75Buzz: 	 75FizzBuzz: 	 75


// Fizz: 	 78

// Buzz: 	 80
// Fizz: 	 81


// Fizz: 	 84
// Buzz: 	 85

// Fizz: 	 87


// Fizz: 	 90Buzz: 	 90FizzBuzz: 	 90


// Fizz: 	 93

// Buzz: 	 95
// Fizz: 	 96


// Fizz: 	 99
