using System;

class Program
{
    static void Main()
    {   

    // string[] students = {"Jenna", "Ayesha", "Carlos", "Viktor"};

    // DisplayStudents(students);
    // DisplayStudents(new string[] {"Robert","Vanya"});

    // void DisplayStudents(string[] students) 
    // {
    //     foreach (string student in students) 
    //     {
    //         Console.Write($"{student}, ");
    //     }
    //     Console.WriteLine();
    // }

    PrintCircleArea(21);
    PrintCircleCircumference(20);

    void PrintCircleArea(int radius)
    {
        double pi = 3.14159;
        double area = pi * (radius * radius);
        Console.WriteLine($"Area = {area}");
    }
    
    void PrintCircleCircumference(int radius)
    {
        double pi = 3.14159;
        double circumference = 2 * pi * radius;
        Console.WriteLine($"Circumference = {circumference}");
    }

    }
}
