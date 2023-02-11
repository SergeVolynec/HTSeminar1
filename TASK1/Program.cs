Console.Write("Enter first number: ");
int FirstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter second number: ");
int SecondNumber = Convert.ToInt32(Console.ReadLine());


if (FirstNumber != SecondNumber)
{
    if (FirstNumber > SecondNumber)
    {
        Console.WriteLine("First number is larger.");
    }
    else
    {
        Console.WriteLine("Second number is larger.");
    }
}
else
{
    Console.WriteLine("First number equals second number.");
}