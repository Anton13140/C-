// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает 
// вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.Write("Введите трехзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num < 100 || num > 999) 
// {
//     Console.WriteLine($"Число {nam} не трехзначное, попробуй снова");
// }
// else
// {
//     num = num % 100 / 10;
//     Console.WriteLine(nam);
// }


// Задача 13: Напишите программу, которая выводит третью цифру СЛЕВА заданного числа или сообщает, 
// что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 3267912 -> 6

// Console.Write("Введите трехзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int num2 = num;
// int index = -2;

// if (num < 100) Console.WriteLine("Третьей цифры слева нет");

// while (num2 > 0)
// {
//     num2 = num2 / 10;
//     index++;
// }
 
//  index = Convert.ToInt32(Math.Pow(10, index));

// num = num % index;
// index = index / 10;
// num = num / index;

// Console.WriteLine(num);


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// Console.Write("Введите день недели: ");
// int day = Convert.ToInt32(Console.ReadLine());

// if (day < 1 || day >= 8) 
// {
//     Console.WriteLine("К сожалению или к счастью в неделе 7 дней");
// }
// else if (day < 6) 
// {
//     Console.WriteLine("Опять работа");
// }    
// else if (day >= 6)
// {
//     Console.WriteLine("Можно и отдохнуть");
// }