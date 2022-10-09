// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, 
// а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.Write("Введите певое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Ввендите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num1 > num2)
// {
//     Console.WriteLine(num1);
// }
// else
// {
//     Console.WriteLine(num2);
// }

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.Write("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите третье число: ");
// int num3 = Convert.ToInt32(Console.ReadLine());
// int max = 0;

// if (num1 > max) max = num1;
// if (num2 > max) max = num2;
// if (num3 > max) max = num3;

// Console.Write($"Максимальное число: {max}");

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
// (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num % 2 == 0)
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Нет");
// }

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает 
// все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int index = 1;
// int result = num;

// while (index < num)
// {
//     if (result % 2 == 0)
//     {
//         Console.Write(result);
//     }
//   result--;
//   index++;
// }

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает 
// вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.Write("Введите трехзначное число: ");
// int nam = Convert.ToInt32(Console.ReadLine());

// if (nam < 100 & nam > 999) Console.WriteLine($"Число {nam} не трехзначное, попробуй снова");

// nam = nam % 100 / 10;

// Console.WriteLine(nam);


// Задача 13: Напишите программу, которая выводит третью цифру СЛЕВА заданного числа или сообщает, 
// что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 3267912 -> 6

Console.Write("Введите трехзначное число: ");
int nam = Convert.ToInt32(Console.ReadLine());

if (nam < 100) Console.WriteLine("Третьей цифры нет");


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет