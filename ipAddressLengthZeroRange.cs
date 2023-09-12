using System;

class Program
{
    static void Main()
    {
        bool ValidateRange(string ip)
        {
            bool validRange = true;
            string[] address = ip.Split(".");
            foreach (string number in address)
            {
                if (int.Parse(number) > 255)
                {
                    validRange = false;
                    break; // Exit the loop when an invalid number is found
                }
            }
            return validRange;
        }


        bool ValidateZeroes(string ip) 
    {
        bool validZeroes = true;
    string[] address = ip.Split(".");

    foreach (string number in address) 
    {
        if (number.Length > 1 && number.StartsWith("0")) 
        {
            validZeroes = false;
            break;
        }
    }

    return validZeroes;
    // validZeroes = true;
    }

    bool ValidateLength(string ip) 
{
    bool lengthGood = true;
    string[] address = ip.Split(".");
    // validLength = address.Length == 4;
    if (ip.Length <= 4) {
        lengthGood = false;
    }
    return lengthGood;
    // validLength = address.Length == 4;
    // if (ip)
}

    bool rangeGood = ValidateRange("1.4.5.3");
    bool noZeroes = ValidateZeroes("1.4.5.3");
    bool lengthGood = ValidateLength("1.4.5.3");
    Console.WriteLine($"Is the range good?:\t {rangeGood} Zeroes good?:\t {noZeroes}. length?:\t {lengthGood}");
    }
}
