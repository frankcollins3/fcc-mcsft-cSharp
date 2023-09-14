using System;

class Program {
    /* 
This code uses a names array and corresponding methods to display
greeting messages
*/
static void Main()
{

ArgumentException invalidArgumentException = new ArgumentException("ArgumentException: \t The 'GraphData' method received data outside the expected range");
throw invalidArgumentException;

// throw new FormatException("FormatException: \t Calculations in process XYZ have been cancelled due to invalid data Format");

string[][] userEnteredValues = new string[][]
{
        new string[] { "1", "two", "3"},
        new string[] { "0", "1", "2"}
};

foreach (string[] userEntries in userEnteredValues)
{
    try
    {
        BusinessProcess1(userEntries);
    }
    catch (Exception ex)
    {
        if (ex.StackTrace.Contains("BusinessProcess1") && (ex is FormatException))
        {
            Console.WriteLine($"oh look at the: \t {ex.StackTrace}");
            Console.WriteLine(ex.Message);
        }
    }
}

static void BusinessProcess1(String[] userEntries)
{
    int valueEntered;

    foreach (string userValue in userEntries)
    {
        try
        {
// "two" is what causes the error because it's not an integer and it tries parsing a string. Hence a format issue. a string isn't formatted to be Parse(param)
            valueEntered = int.Parse(userValue);

            // completes required calculations based on userValue
            // ...
        }
        catch (FormatException)
        {
            FormatException invalidFormatException = new FormatException("FormatException: User input values in 'BusinessProcess1' must be valid integers");
            throw invalidFormatException;
        }
    }
}

}

}



                    // Common Exception Types:
// ArgumentException or ArgumentNullException: Use these exception types when a method or constructor is called with an invalid argument value or null reference.
// InvalidOperationException: Use this exception type when the operating conditions of a method don't support the successful completion of a particular method call.
// NotSupportedException: Use this exception type when an operation or feature is not supported.
// IOException: Use this exception type when an input/output operation fails.
// FormatException: Use this exception type when the format of a string or data is incorrect.

                    // StackTrace convention.
// The Message property should explain the reason for the exception. 
// However, information that's sensitive, or that represents a security concern shouldn't be put in the message text.

// The StackTrace property is often used to track the origin of the exception. 
// string prop contains the name of methods on current call stack, together with the file name and line number in each method that's associated with the exception. 
// A StackTrace object is created automatically by the common language runtime (CLR) from the point of the throw statement.
// Exceptions must be thrown from the point where the stack trace should begin.

                    // when to throw an exception
// Methods should throw an exception whenever they can't complete their intended purpose. 
// The exception thrown should be based on the most specific exception available that fits the error conditions.
