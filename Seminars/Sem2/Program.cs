// int DeleteSd (int num)
// {
//     if (num >= 100 && num <= 1000)
//  {
//    int ed = num%10;
//    int sot = num /100;
//    return sot * 10 + ed;
//  }
// else
//  {
//    Console.Write("Вы ввели не трехзначное число");
//    return 0;
//  }
// }
// Console.WriteLine("Введите трехзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(DeleteSd(num));


// Задача 2.

// int SecondPower (int num)
// {
//     if (num >= 100 && num <= 1000)
//  {
//    int ed = num%10;
//    int des = num /10 % 10;
//    int resalt = 1;
//   for (int i = 0; i < ed; i++)
//   {
//     resalt = resalt * des;
//   }
//   return resalt;
//  }
// else
//  {
//    Console.Write("Вы ввели не трехзначное число");
//    return 0;
//  }
// }
// Console.WriteLine("Введите трехзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(SecondPower(num));


void Myltipla (int num1, int num2)
{
  if (num1 % num2 == 0)
  {
    System.Console.WriteLine($"{num1}  кратно  {num2}");
  }
  else
  {
    System.Console.WriteLine($"{num1}  не кратно  {num2}  остаток от деления равено = {num1 % num2}");
  }
}

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Myltipla (num1, num2);