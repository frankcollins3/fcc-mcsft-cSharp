string friend = "foe";
string greeting = "Greetings" + "\n" + friend;
Console.WriteLine(greeting);

string firstName = "Henry";
string lastName = "Miller";
string henryMiller = "\n\n" + firstName + " " + lastName + "!";
Console.WriteLine(henryMiller);

int friendNumber = 2;
string friend2 = "foe";
string greeting2 = $"Hello there: \t\t {friend2}\n You really are friend: \t #{friendNumber}";
Console.WriteLine(greeting2);

// can use multiple variables with different types in STRING INTERPOLATION
int version = 11;
string versionText = "Update to High Sierra";
Console.WriteLine($"{versionText} {version}");

// combine verbatim literals and string interpolation
string projectName = "Project-1";
Console.WriteLine($@"C:\Output\{projectName}\Data");

