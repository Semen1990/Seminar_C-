// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"Квадрат вашего числа {a} =  {a*a}");

Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a == b*b)
{
System.Console.WriteLine($"Введеное число {a} является квадратом числа {b}");
}
else
{
   System.Console.WriteLine($"Введеное число {a} не является квадратом числа {b}"); 
}