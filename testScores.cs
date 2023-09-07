using System;

class Program 
{
    static void Main() 
    {

    

    // this getGrade function takes (string: student) (int: grade) as params, and logs the string along with the A-F middle-school, high-school grading correspondent to number grade.

    static string getGrade(string student, int grade) 
    {
        if (grade >= 97 || grade <= 100) {
            return $"{student} got an A+";
            // return "A+";
        }
        else if (grade >= 93 || grade <= 96) {
            return $"{student} got an A";            
            // return "A";
        }
        else if (grade >= 90 || grade <= 92) {
            return $"{student} got an A-";            
            // return "A-";
        }   
        else if (grade >= 87 || grade <= 89) {
            return $"{student} got a B+";                        
            // return "B+";
        }   
        else if (grade >= 83 || grade <= 86) {
            return $"{student} got a B";                        
            // return "B";
        }
        else if (grade >= 80 || grade <= 82) {
            return $"{student} got a B-";                        
            // return "B-";
        }
        else if (grade >= 77 || grade <= 79) {
            return $"{student} got a C+";                        
            // return "C+";
        }   
        else if (grade >= 73 || grade <= 76) {
            return $"{student} got a C";                        
            // return "C";
        }
        else if (grade >= 70 || grade <= 72) {
            return $"{student} got a C-";                        
            // return "C-";
        }
        else if (grade >= 67 || grade <= 69) {
            return $"{student} got a D+";                        
            // return "D+";
        }
        else if (grade >= 63 || grade <= 66) {
            return $"{student} got a D";                        
            // return "D";
        }
        else if (grade >= 60 || grade <= 62) {
            return $"{student} got a D-";                        
            // return "D-";
        }
        else {
            return $"{student} got an F";                                    
            // return "F";
        }
    }

        
    
    int[] sophia = new int [5];
    int[] andrew = new int [5];
    int[] emma = new int [5];
    int[] logan = new int [5];

    // 2d matrix array 
    int[][] studentArrays = new int[4][];
    studentArrays[0] = sophia;
    studentArrays[1] = andrew;
    studentArrays[2] = emma;
    studentArrays[3] = logan;

    string[] studentNames = { "sophia", "andrew", "emma", "logan" };



    // use a for loop, limited by 5, the number of test scores, and randomly generate a value from 1, 99

    void populateStudent(int[] student )
    {
            Random studentTier = new Random();
            int abcStudent = studentTier.Next(1, 3);

        for (int i = 0; i < 5; i++) {

            Random randomGrade = new Random();
            // static Random randomGrade = new Random();
            int grade = randomGrade.Next(abcStudent == 1 ? 50 : abcStudent == 2 ? 70 : abcStudent == 3 ? 90 : 1, 99);
            Console.WriteLine($"{grade}");
            // this works for sophia
            // sophia[i] = grade;

            // param[i] because this would be performed iteratively over the 2d matrix array so every student[] needs to have populated test scores 
            student[i] = grade;
        }
    }

// this loops over the 2d matrix array and invokes the above void function populateStudent() with the student[] as params.
    void populateStudentArray()
    {
        foreach(int[] student in studentArrays)
        {
            populateStudent(student);
        }        
    }


    int studentTestAverage(int[] student) 
    {
        int average = 0;
        foreach(int num in student) 
        {
            average += num;
        }
        if (average > 1) {
            Console.WriteLine($"average is: {average / 5}"); 
            return average / 5;            
        } else {
            return 0;
        }
    }


    void checkGrades()
    {
        // populateStudent();
        populateStudentArray();

        // foreach(int[] student in studentArrays)
        // {
        //     studentTestAverage(student);
        // }

        for (int i = 0; i < studentArrays.Length; i++) {
            // Console.WriteLine(studentNames[i]);
            // studentTestAverage(studentArrays[i]);
            int testAverage = studentTestAverage(studentArrays[i]);
            string grade = getGrade(studentNames[i], testAverage);
            Console.WriteLine(grade);
        }


        Console.WriteLine($"sophia: \t {sophia}");

        Console.WriteLine($"sophia: \t [{string.Join(", ", sophia)}]");
        Console.WriteLine($"andrew: \t [{string.Join(", ", andrew)}]");
        Console.WriteLine($"emma: \t [{string.Join(", ", emma)}]");
        Console.WriteLine($"logan: \t [{string.Join(", ", logan)}]");
    }

    checkGrades();
    }
}

    // get grade average.

    // string studentTestAverage()

    // int studentTestAverage()
    // {
    // int average = 0; 
    //     foreach(int[] student in studentArrays)
    //     {
    //         foreach(int num in student) 
    //         {
    //             average += num;    
    //         }
    //     }    
    //     if (average > 1) {
    //         Console.WriteLine($"average is: {average / 5}"); 
    //         return average / 5;
    //     } else {
    //         Console.WriteLine("no average");
    //         return 0;
    //     }        
    // }
