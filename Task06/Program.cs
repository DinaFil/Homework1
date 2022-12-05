Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
bool positive = true;

if (number >= 0) positive = true;
else positive = false;

switch(positive)

   { 
    case true:
    if (number % 2 == 0) Console.WriteLine("Введено четное число");
    else Console.WriteLine("Введено нечетное число");
    break;

    case false:
    if (number % 2 == -1) Console.WriteLine("Введено нечетное число");
    else Console.WriteLine("Введено четное число");
    break;
    default: Console.WriteLine("Число не введено");
}


   
    
  




