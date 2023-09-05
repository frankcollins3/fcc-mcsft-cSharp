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

#### CHALLENGE 1:
string projectName = "ACME";
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

// english output (no intermediate variables) --->
Console.WriteLine("View English Output");
Console.WriteLine($@"c:\Exercise\{projectName}\data.txt");

// russian output: 
Console.WriteLine($"\n{russianMessage}");
Console.WriteLine($@"c:\Exercise\{projectName}\ru-RU\data.txt");

string bobby = "Bob";
int luckyThree = 3;
// decimal threeThrees = 33.3m;
// float threeThrees = 33.3F;
double threeThrees = 33.3;

Console.WriteLine($"Hello, {bobby}! You have {luckyThree} in your inbox. The temperature is {threeThrees} celcius");

