// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
System.Console.Write("Введите число: ");
int number = Convert.ToInt32(System.Console.ReadLine());
int result = -1;
if (number < 100)
    Console.WriteLine("Третьей цифры нет");
else if (number >= 100)
    {
        while (number > 999)
        {
            number = number / 10;
        }
        result = number % 10;    
    Console.WriteLine($"Третья цифра '{result}'");
    }

// Console.Clear();
// int number = ReadInt("Введите число: ");
// int count = number.ToString().Length;
// Console.Write(MakeArray(number, count));

// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int MakeArray(int a, int b)
// {
// int result = -1;
//     if (b < 3)
//     {
//         Console.WriteLine("Третьей цифры нет.");
//     }
//     else
//     {
//         int c = 1;
//         for (int i = b; i > 3; i--)
//         {
//             c = c * 10;
//         }

//         result = (a / c) % 10;
//     }
// return result;
// }

// Console.Clear();
// System.Console.Write("Введите число: ");
// int num = Convert.ToInt32(System.Console.ReadLine());
// string str = num.ToString();
// Console.WriteLine(str[2]);
    