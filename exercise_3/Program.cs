Console.Clear();
Console.Write("enter number: ");
int number = int.Parse(Console.ReadLine());
if(number % 2 == 1 )
{
    Console.WriteLine("нечетное число");
}
else
{
    Console.WriteLine("четное число");
}