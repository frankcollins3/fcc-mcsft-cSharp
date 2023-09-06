using System;

class Program {

    static Random random = new Random();
    
    // random.Next(12) 1 parameter means it's constrained by picking random number to be less than 12 So [0-11]
    static int daysUntilExpired = random.Next(12); 
    static int discountPercentage = 0;

    // without renew message to allow ternary declared string to determine that message.
    static string lessThanTenMsg = "Your subscription will expire soon!";
    static string lessThanFiveMsg = $"Your subscription expires in {daysUntilExpired} days.";
    static string oneMoreDayMsg = "Your subscription expires within a Day!";
    // static string lessThanTenMsg = "Your subscription will expire soon! Renew Now!";
    // static string lessThanFiveMsg = $"Your subscription expires in {daysUntilExpired} days Renew now and save 10%!";
    // static string oneMoreDayMsg = "Your subscription expires within a Day! Renew now and save 20%!";

    static string expiredMsg = "Your subscription has expired!";

    static string renewalMsg = 
    (daysUntilExpired > 1 && daysUntilExpired <=5) ? "Renew Now!" : 
    (daysUntilExpired == 1) ? "Renew now and Save 20%!" :
    "Your subscription has ended!";

    // string lessThanFiveMsg = "Your subscription expires in  days" Renew now and save 10%!"

    static string checkExpired() 
    {
        if (daysUntilExpired <= 10) 
        {
            return lessThanTenMsg;
        } else if (daysUntilExpired > 1 && daysUntilExpired <= 5) {            
            return lessThanFiveMsg;
        } else if (daysUntilExpired == 1) {
            return oneMoreDayMsg;
        } else if (daysUntilExpired == 0) {
            return expiredMsg;
        } else {
            return "else";
        }
        
    }

    static void Main() 
    {
        string msg = checkExpired();
        Console.WriteLine(discountPercentage);
        Console.WriteLine($"daysUntilExpired: {daysUntilExpired}");
        Console.WriteLine($"Msg: {msg} Renew: {renewalMsg}");
    }


}
