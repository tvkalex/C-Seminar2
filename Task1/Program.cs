// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает
// вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
System.Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(System.Console.ReadLine());
if ((num / 100 > 0) && (num / 1000 == 0))
    Console.WriteLine(num / 10 % 10);
else
    Console.WriteLine("Число не трёхзначное");




