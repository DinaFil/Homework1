Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 2; 
if (n < i) Console.WriteLine("Нет чисел для отображения");
while (i <= n)
{
Console.WriteLine(i); 
i = i + 2;
}
