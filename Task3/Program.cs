// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
System.Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
if (number > 0 && number < 6)
    System.Console.WriteLine("Нет");
else if (number > 6 && number < 8)
    System.Console.WriteLine("Да");
else
    System.Console.WriteLine("А сколько дней в твоей неделе?");

// Console.Clear();
// System.Console.WriteLine("Введите число: ");
// int number = int.Parse(Console.ReadLine()!);
// switch (number)
// {
//     case 1:
//         System.Console.WriteLine("Нет");
//         break;
//     case 2:
//         System.Console.WriteLine("Нет");
//         break;
//     case 3:
//         System.Console.WriteLine("Нет");
//         break;
//     case 4:
//         System.Console.WriteLine("Нет");
//         break;
//     case 5:
//         System.Console.WriteLine("Нет");
//         break;
//     case 6:
//         System.Console.WriteLine("Да");
//         break;
//     case 7:
//         System.Console.WriteLine("Да");
//         break;
//     default:
//         System.Console.WriteLine("А сколько дней в твоей неделе?");
//         break;
// }