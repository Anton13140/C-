        // Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// double num2 = num;
// int i = 0;

// while (num > 10)
// {
//     num = num/10;
//     i++;
// }

// num2 = num2 % 10;

// if (num == num2)
// {
//     Console.WriteLine("да");
// }
// else
// {
//     Console.WriteLine("Нет");
// }


//                                                        Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними 
// в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.Write("Введите координату первой точки по X: ");
// int xA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату первой точки по Y: ");
// int yA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату второй точки по Z: ");
// int zA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату второй точки по X: ");
// int xB = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату второй точки по Y: ");
// int yB = Convert.ToInt32(Console.ReadLine()); 
// Console.Write("Введите координату второй точки по Z: ");
// int zB = Convert.ToInt32(Console.ReadLine()); 


// double distanceAB = Math.Round(Math.Sqrt(Math.Pow((xB-xA), 2) + Math.Pow((yB-yA), 2) + Math.Pow((zB-zA), 2)), 2);

// Console.WriteLine(distanceAB);

//                                                         Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// double i = 1;

// while (i < num)
// {
//     i = Math.Pow(i, 3);
//     Console.WriteLine(i);
//     i++;
// }