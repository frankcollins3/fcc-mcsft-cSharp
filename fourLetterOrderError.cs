    using System;

    class Program {

        static void Main()
        {

        foreach(string str in splitOrders) 
        {
            Console.Write($"{str} \n");
            if (str.Length != 4) {
                Console.Write($"{str} - error \n");
            }
        }
          
        }
    }


/*
my example is closer to this one than the last algo even though both solved w/ success:

string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] items = orderStream.Split(',');
Array.Sort(items);

foreach (var item in items)
{
    if (item.Length == 4)
    {
        Console.WriteLine(item);
    }
    else
    {
        Console.WriteLine(item + "\t- Error");
    }
}


*/
