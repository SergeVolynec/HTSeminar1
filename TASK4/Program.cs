Console.Write("Enter number: ");
int Number = Convert.ToInt32(Console.ReadLine());

//Если введут отрицательное, поменяем знак
if (Number < 0) Number = Number * (-1);

int count = 2;

while (count <= Number)
{
    Console.Write(count + " ");
    count = count + 2;
}


