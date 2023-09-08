class Program {

int.TryParse(); // convert a string value to an integer


// splitting the sku string which types it as an array of strings separated by dashes in this cas.e
static void stringSplit()
{
    string sku = "02-WH-S";
    string[] product = sku.Split('-');      // split the string at the dashes which leaves array: ["02", "WH", "S"];
}

static void gatherUserInput()
{
    string? readResult;
    do
    {
        Console.WriteLine("Enter a string:");
        readResult = Console.ReadLine();
    } while (readResult.Length < 5);

    }   

}
