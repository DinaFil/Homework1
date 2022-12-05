Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int number3 = int.Parse(Console.ReadLine());
int max = 0;
if (number1 >= number2)
{
    max = number1;
}
else
{
max = number2;
}

if (number3 >= max)
{
Console.WriteLine("Максимальное число: "+ +number3);
}

else
{
    Console.WriteLine("Максимальное числое: "+ +max);
}