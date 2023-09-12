using System;

class Program
{
    static void Main()
    {   

    double usd = 23.73;
    int vnd = UsdToVnd(usd);

    Console.WriteLine($"${usd} USD = ${vnd} VND");
    Console.WriteLine($"${vnd} VND = ${VndToUsd(vnd)} USD");

    int UsdToVnd(double usd) 
    {
        int rate = 23500;
        return (int) (rate * usd);
        // return int (rate * usd)          // without the cast we get a:           Cannot implicitly convert type 'double' to 'int'.  ...      error.
    }

    double VndToUsd(int vnd) 
    {
        double rate = 23500;
        return vnd / rate;
    }

    }
}
