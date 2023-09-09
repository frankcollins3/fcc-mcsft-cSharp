using System;

class Program {

    // this app will feature callback functions that allow the user to decide which features of the app they will access based on input.
    
    // global variables so the callbacks have access to them.


    static void Main()
    {

    // int result = first + second;
    // int first = 2;
    // string second = "4";
    // string result = first + second;
    // Console.WriteLine(result);

    // string result concatenates the values. The compiler does what it is understood to be a safer conversion.
    // int result returns error. it's an unsafe data type conversion.

    //     int myInt = 3;
    // Console.WriteLine($"int: {myInt}");

    // decimal myDecimal = myInt;
    // Console.WriteLine($"decimal: {myDecimal}");

    // int can be added to a decimal because decimal stores more data than an int.

    // decimal myDecimal = 3.14;
    // Console.WriteLine($"decimal: \t {myDecimal}");

    // use the casting() operator to change the decimal type to be an int and store that data and changed type in a new variable named myInt;
    // int myInt = (int)myDecimal;
    // Console.WriteLine($"int: \t {myInt}");

    // int num1 = 5;
    // int num2 = 7;
    // string msg = num1.ToString() + num2.ToString();
    // Console.Write($"heres the message: \t {msg} \n");


    // string first = "5";
    // string second = "7";
    // int sum = int.Parse(first) + int.Parse(second);
    // Console.Write($"sum: \t {sum} \n");

    // string value1 = "5";
    // string value2 = "7";
    // int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
    // Console.WriteLine(result);

    // int value = (int)1.5m; // casting truncates
    // Console.WriteLine(value);   // truncates as in the value = 1. It truncates the .5 off -> its a narrowing conversion that results in data loss.

    // int value2 = Convert.ToInt32(1.5m); // converting rounds up
    // Console.WriteLine(value2);  // output is 2 its a widening conversion that results in more data / precision.

    // string value = "102";
    // int result = 0;
    // if (int.TryParse(value, out result)) {
    //     Console.WriteLine($"result: \t {result}");
    // } else {
    //     Console.WriteLine("Failure to store number");
    // }

//     string value = "102";
    // int result = 0;
    // if (int.TryParse(value, out result))
    // {
    //     Console.WriteLine($"Measurement: {result}");
    // }
    // else
    // {
    //     Console.WriteLine("Unable to report the measurement.");
    // }
        
    // string[] values = { "12.3", "45", "ABC", "11", "DEF" };
    // decimal total = 0; 
    // string concatStr = "";

    // foreach(var val in values) {
    //     decimal num; 
    //     if (decimal.TryParse(val, out num)) {
    //         total += num;
    //     } else {
    //         concatStr += val;
    //     }
    // }
    // Console.WriteLine(concatStr);
    // Console.WriteLine(total);

    int value1 = 12;
    decimal value2 = 6.2m;
    float value3 = 4.3f;

    int result1 = value1 / 6; 
    decimal result2 = value2 / 3.5m;
    float result3 = value3 / 9.75f;

    // The Convert class is best for converting the fractional decimal numbers into whole integer numbers
    // Convert.ToInt32() rounds up the way you would expect.
    int result1 = Convert.ToInt32((decimal)value1 / value2);
    Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

    decimal result2 = value2 / (decimal)value3;
    Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

    float result3 = value3 / value1;
    Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");

    // Divide value1 by value2, display the result as an int: 2
    // Divide value2 by value3, display the result as a decimal: 1.4418604651162790697674418605
    // Divide value3 by value1, display the result as a float: 0.3583333



    }
}

//                              widening or narrowing conversion:
// The term narrowing conversion means that you're attempting to convert a value from a data type that can hold more information to a data type that can hold less information. 
// In this case, you may lose information such as precision (that is, the number of values after the decimal point) 
// int myInt = (int)myDecimal; ------>  change decimal to int. decimal holds more data so is safer as explained above.


//                              ToString();
// Every data type variable has a ToString() method. What the ToString() method does depends on how it's implemented on a given type.
//  However, on most primitives, it performs a widening conversion. 
