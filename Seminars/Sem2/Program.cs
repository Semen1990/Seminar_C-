int DeleteSd (int num)
{
    if (num >= 100 && num <= 1000)
 {
   int ed = num%10;
   int sot = num /100;
   return sot * 10 + ed;
 }
else
 {
   Console.Write("Вы ввели не трехзначное число");
   return 0;
 }
}
Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(DeleteSd(num));