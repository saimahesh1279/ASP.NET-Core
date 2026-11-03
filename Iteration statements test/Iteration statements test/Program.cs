Console.WriteLine("enter the starting point:");
int start = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the end point:");
int end = Convert.ToInt32(Console.ReadLine());



 
int big;
int small;


if(start > end)
{
    big = start;
    small = end;
}
else
{
    big = end;
    small = start;
}


for (int i= small; i<=big;  i++)
{
    for(int j =1; j<=10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j}");
    }
}
