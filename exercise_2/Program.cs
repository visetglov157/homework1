Console.Clear();
Console.Write("enter a: ");
int a = int.Parse(Console.ReadLine());
Console.Write("enter b: ");
int b = int.Parse(Console.ReadLine());
Console.Write("enter c: ");
int c = int.Parse(Console.ReadLine());
if (a > b)
{
    if (a > c)
    {
        Console.WriteLine("max number: " + a);
    }
    else
    {
        Console.WriteLine("max number: " + c);
    }
}

else if (b > c)
{
    Console.WriteLine("max number: " + b);
}
else
{
    Console.WriteLine("max number: " + c);
}


