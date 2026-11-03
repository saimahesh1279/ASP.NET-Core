#region if

//Console.WriteLine("Enter a number:");

//int number = int.Parse(Console.ReadLine());

//if(number > 0)
//{
//    Console.WriteLine("the number is positive number");
//}


//Console.WriteLine("number is not positive number");
#endregion

#region If else

//Console.WriteLine("Enter a number:");

//int number = int.Parse(Console.ReadLine());

//if (number > 0)
//{
//    Console.WriteLine("the number is positive number");
//} else
//{
//    Console.WriteLine("number is Negative number");
//}


//Console.WriteLine("number is not positive number");
#endregion

#region else if

Console.WriteLine("Enter a number:");

int number = int.Parse(Console.ReadLine());

if (number > 0)
{
    Console.WriteLine("the number is positive number");
}
else if (number < 0)
{
    Console.WriteLine("number is Negative number");
}
else if (number == 0)
{
    Console.WriteLine("number is zero");
}
else
{
    Console.WriteLine("entered data is not a number");
}
#endregion