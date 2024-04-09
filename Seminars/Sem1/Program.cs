// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"Квадрат вашего числа {a} =  {a*a}");

// Console.WriteLine("Введите первое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int b = Convert.ToInt32(Console.ReadLine());
// if (a == b*b)
// {
// System.Console.Write($"Введеное число {a} является квадратом числа {b}");
// }
// else
// {
//    System.Console.Write($"Введеное число {a} не является квадратом числа {b}"); 
// }

// Console.WriteLine("Введите число N ");
// int n = Convert.ToInt32(Console.ReadLine());
// int st= -n;

// while (st <= n)
// {
//    Console.Write(st + " ");
//    st++;
// }


Console.WriteLine("Введите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n >= 100 && n <= 1000)
{
   int fn = n % 10;
   int ln = n/100;
   Console.Write($"Сумма первго числа {fn} и последнего числа {ln} трехзначного числа =  {fn + ln}");
}
else
{
   Console.Write("Вы ввели не трехзначное число");
}

