// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// int Task(int m)
// {
//     int amount = 0;
//     for(int i = 0; i < m; i++)
//     {
//         Console.Write("Введтите число: ");
//         int num = Convert.ToInt32(Console.ReadLine());
//         if(num > 0) amount++;

//     }
//     return amount;

// }
// int resalt = Task (5);
// Console.Write(resalt);


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


// Console.Write("Введте b1 ");
// double b1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите k1 ");
// double k1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введитк b2 ");
// double b2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите k2 ");
// double k2 = Convert.ToInt32(Console.ReadLine());

// double x = (b2-b1)/(k1-k2);
// double y1 = k1 * x + b1;
// double y2 = k2 * x + b2;

// Console.WriteLine($"{y1}; {y2}");


// Задача 45: Напишите программу, которая будет создавать копию заданного массива с 
// помощью поэлементного копирования


// void Task(int[] array1, int[] array2)
// {
//     for(int i = 0; i < array1.Length; i++)
//     {
//         array2[i] = array1[i];
//         Console.WriteLine(array2[i]);
//     }
// }

// int[] array1 = {2, 5, 3, 8, 3, 1};
// int[] array2 = new int[6];
// Task(array1, array2);