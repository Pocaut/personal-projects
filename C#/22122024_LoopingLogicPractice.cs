string? userInput;
int value;
bool validEntry = false;

Console.WriteLine ("Enter an integer between 5 and 10");

while (validEntry == false)
{
    userInput = Console.ReadLine();
    validEntry = int.TryParse(userInput, out value);
    if ((value >= 5) && value <= 10)
        break;
    else
        Console.WriteLine("Input rejected. Enter an integer between 5 and 10");
        validEntry = false;
}

Console.WriteLine("Input accepted.");

string? role;
bool validRole = false;
Console.WriteLine("What is your role? (Administrator, Manager, User)");

while(validRole == false)
{
    role = Console.ReadLine();
    switch (role.Trim().ToLower())
    {
        case "administrator":
            Console.WriteLine("Administrator role accepted.");
            validRole = true;
            break;
        case "manager":
            Console.WriteLine("Manager role accepted.");
            validRole = true;
            break;
        case "user":
            Console.WriteLine("User role accepted.");
            validRole = true;
            break;
        default:
            Console.WriteLine("Role rejected.");
            break;
    }
}


string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringsCount = myStrings.Length;

string myString = "";
int periodLocation = 0;

for (int i = 0; i < stringsCount; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");

    string mySentence;

    while (periodLocation != -1)
    {

        mySentence = myString.Remove(periodLocation);

        myString = myString.Substring(periodLocation + 1);

        myString = myString.TrimStart();

        periodLocation = myString.IndexOf(".");

        Console.WriteLine(mySentence);
    }
 
    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}