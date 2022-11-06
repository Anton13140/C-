// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// void FillArray(double[,] matrix)
// {
//     for(int rows = 0; rows < matrix.GetLength(0); rows++)
//     {
//         for(int columns = 0; columns < matrix.GetLength(1); columns++)
//         {
//             matrix[rows, columns] = Convert.ToDouble(new Random().Next(-50, 50)) / 2;
//             Console.Write($"{matrix[rows, columns]} ");
//         }
//         Console.WriteLine();
//     }
// }

// double[,] matrix = new double [3, 4];
// FillArray(matrix);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// void Task(int[,] matrix, int num)
// {
//     int result = 0;
//     int i = 0;            //Проверка на ноль
//     for(int rows = 0; rows < matrix.GetLength(0); rows++)
//     {
//         for(int columns = 0; columns < matrix.GetLength(1); columns++)
//         {
//             if(num == matrix[rows, columns]) 
//             {
//                 result = matrix[rows, columns];
//                 Console.WriteLine($"Позиция э-та [{rows}, {columns}]");
//             }
//             if(matrix[rows, columns] == 0) i++;   //Добавляет еденицу, если искать ноль
//         }
//     }
//     if(result != num && result == i) Console.WriteLine("Такого числа нет.");
// }

// int[,] matrix = new int [,]
// {
//     {1, 4, 7, 2},
//     {5, 9, 2, 3},
//     {8, 4, 2, 4}
// };
// Task(matrix, 4);

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом 
// столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


// void Task(double[,] matrix)
// {
//     double average = 0;
//     for(int columns = 0; columns < matrix.GetLength(1); columns++)
//     {
//         for(int rows = 0; rows < matrix.GetLength(0); rows++)
//         {
//             average = average + matrix[rows, columns];
//         }
//         Console.Write($"{Math.Round(average/3, 2)}|");
//         average = 0;
//     }
// }


// double[,] matrix = new double [,]
// {
//     {1, 4, 7, 2},
//     {5, 9, 2, 3},
//     {8, 4, 2, 4}
// };
// Task(matrix);