string[] dayOfWeek = new string[] { "sunday", "monday", "tuesday", "wednesday", "thursday", "friday", "saturday" };

Console.WriteLine("Days of the week:");
string userInput = Console.ReadLine().ToLower();

int i = 0;
while( i<dayOfWeek.Length)
{
    Console.WriteLine(dayOfWeek[i]);
    if(dayOfWeek[i] == userInput)
    {
        Console.WriteLine("Found it!");
        break;
    }
    i++;
}

Console.WriteLine("------------------------------");

for (int j = 0; j < dayOfWeek.Length; j++)
{
    //Console.WriteLine(dayOfWeek[j]);
    Console.WriteLine(dayOfWeek[j]+ "------ " + userInput);
    if (dayOfWeek[j] == userInput)
    {
        Console.WriteLine("Found it!");
        break;
    }
}

foreach (string day in dayOfWeek)
{
    Console.WriteLine(day);
    if (day == userInput)
    {
        Console.WriteLine("Found it!");
        break;
    }

}