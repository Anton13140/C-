// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int PoF(int num1, int num2)
// {
//     int result = num1;
//     for (int i = 1; i < num2; i++)
//     {
//         result = result * num1;
//     }
//     return result;
// }

// Console.Write("Введите число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// int result = PoF(num1, num2);
// Console.WriteLine(result);

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int Sum(int num)
// {
    
//     int sum = 0;
//     while (num > 0)
//     {
//         sum = sum + num % 10;
//         num = num / 10;
//     }
//     return sum;
// }
// int sum = Sum(821);
// Console.WriteLine(sum);


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int[] num = {new Random().Next(1, 10), new Random().Next(1, 10), 
// new Random().Next(1, 10),new Random().Next(1, 10), new Random().Next(1, 10),
// new Random().Next(1, 10), new Random().Next(1, 10),
// new Random().Next(1, 10), new Random().Next(1, 10), new Random().Next(1, 10)};

// Console.WriteLine($"{num[0]}, {num[1]}, {num[2]}, {num[3]}, {num[4]}, {num[5]}, {num[6]}, {num[7]}, {num[8]}, {num[9]}");
