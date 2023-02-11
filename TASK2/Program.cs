Console.Write("Enter first number: ");
int FirstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter second number: ");
int SecondNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter third number: ");
int ThirdNumber = Convert.ToInt32(Console.ReadLine());

int Max = FirstNumber;

if (SecondNumber > Max) Max = SecondNumber;
if (ThirdNumber > Max) Max = ThirdNumber;

Console.Write("Max number is: " + Max);