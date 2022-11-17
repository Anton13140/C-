// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива. 
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// void PrintArray(int[,]matrix)
// {
//     for(int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void StringDescending(int[,]matrix)
// {
//     int temp = 0;
//     int index = 0;
//     for(int i = 0; i < matrix.GetLength(0); i++)
//     {
//         while(index < matrix.GetLength(1) * matrix.GetLength(1))
//         {
//             for(int j = 0; j < matrix.GetLength(1) - 1; j++)
//             {
//                 if(matrix[i, j] < matrix[i, j + 1])
//                 {
//                     temp = matrix[i, j];
//                     matrix[i, j] = matrix[i, j + 1];
//                     matrix[i, j + 1] = temp;
//                 }
//             } 
//             index++;
//         }
//         index = 0;
//     }
// }

// int [,] matrix = new int [,]
// {
//     {1, 4, 7, 2},
//     {5, 9, 2, 3},
//     {8, 4, 2, 4}
// };

// PrintArray(matrix);
// Console.WriteLine(); 
// StringDescending(matrix);
// PrintArray(matrix);

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
// находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 
// 1 строка

// void StringMinSum(int[,] matrix)
// {
//     int sum = 0;
//     int [] array = new int [matrix.GetLength(0)];

//     for(int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             sum = sum + matrix[i, j];
//         }
//         array[i] = sum;
//         sum = 0;
//     }

//     int min = 0;
//     for (int t = 0; t < matrix.GetLength(0); t++)
//     {
//         min = array[0];
//         if(array[t] < min) 
//         {
//             min = array[t];
//         }
//     }

//     int index = 0;
//     while(index < matrix.GetLength(0))
//     {
//         if(min == array[index])
//         {
//             Console.WriteLine($"{index + 1} строка");
//         }
//         index++;
//     }
// }

// int[,] matrix = new int [,]
// {
//     {1, 4, 7, 2},
//     {5, 9, 2, 3},
//     {8, 4, 2, 4},
//     {9, 2, 2, 9}
// };

// StringMinSum(matrix);


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// void PrintArray(int[,]matrix)
// {
//     for(int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] ProductMatrix (int[,] matrix1, int[,] matrix2)
// {
//     int[,] newMatrix = new int [matrix1.GetLength(0), matrix2.GetLength(1)];

//     for(int i = 0; i < matrix1.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix2.GetLength(1); j++)
//         {
//             for(int k = 0; k < matrix2.GetLength(0); ++k)
//             {
//                 newMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
//             }
//         }
//     }
//     return newMatrix;
// }


// int[,] matrix1 = new int [,]
// {
//     {2, 4},
//     {3, 2}
// };

// int[,] matrix2 = new int [,]
// {
//     {3, 4},
//     {3, 3}
// };

// ProductMatrix (matrix1, matrix2);
// int[,] newMatrix = new int [2, 2];
// newMatrix = ProductMatrix(matrix1, matrix2);
// PrintArray(newMatrix);

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// Массив размером 2 x 2 x 2

// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07