    using System;

    class Program {

        static void Main()
        {

        // string data = "12345John Smith          5000  3  ";
        // 123455000  3 (starts at [5] = "J" && deletes 20 characters starting at "J" which .Removes() 20 characters, which is John Smith and most of the white space.)
        
        // string updatedData = data.Remove(5, 20);
        // Console.WriteLine(updatedData);

        // string data = "goodguy";
        // string updatedData = data.Remove(1, 3);
        // Console.WriteLine(updatedData);    
        // gguy (removes [1] = "o" && 3 total digits "ood" returning string characters: "gguy");

        // string message = "This--is--ex-amp-le--da-ta";
        // message = message.Replace("--", " ");
        // message = message.Replace("-", "");
        // Console.WriteLine(message);

        // string message2 = "This is crazy!!!!****!!!*";
        // message2 = message2.Replace("*", "!");           <!-- this takes the * asterisk and turns them into exclamation points! -->
        // message2 = message2.Replace("!", " ");             // this does not replace every asterisk and every exclamation mark -->
        // message2 = message2.Replace("*", " ");             
        // Console.WriteLine(message2);

        string quantity = "";
        const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";
        
        int openingDivLessThan = input.IndexOf("<");
        int openingDivGreaterThan = input.IndexOf(">");
        Console.WriteLine(openingDivLessThan);
        // quantity = input.Remove("<div>");
        quantity = input.Remove(openingDivLessThan, openingDivGreaterThan + 1);
        Console.WriteLine(input);
        Console.WriteLine(quantity);






        
        }
    }
