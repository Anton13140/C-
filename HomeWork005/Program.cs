// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// int Task(int[] array)
// {
//     int amount = 0;
//     for(int i =0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(100, 1000);
//         if(array[i] % 10 % 2 == 0) amount++;
//     }
//     return amount;
// }

// int[] array = new int[15];
// // int[] array = {345, 897, 568, 234, 352, 333}; проверка
// int amount = Task(array);
// Console.WriteLine(amount);

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int Task(int[] array)  !!!НЕПРАВИЛЬНО ПОНЯЛ И СКЛАДЫВАЛ ВСЕ НЕЧЕТНЫЕ ЧИСЛА. НИЖЕ МЕТОД ПО ДЗ))!!!
// {
//     int sum = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         // array[i] = new Random().Next(-100, 101);
//         // array[i] = Math.Abs(array[i]);
//         int rankArray = array[i];
//         int j = 0;
//         while (rankArray > 0)
//         {
//             rankArray = rankArray / 10;
//             j++;
//         }
//         if(array[i] % Convert.ToInt32(Math.Pow(10, j)) % 2 != 0) 
//         {
//             sum = sum + array[i];
//         }

//     }
//     return sum;
// }

// int Task(int[]array)
// {
//     int sum = 0;
//     for(int i = 1; i < array.Length; i++)
//     {
//         if(i % 2 != 0) sum = sum + array[i];
//     }
//     return sum;
// }

// // int[] array = {3, 7, 23, 12};
// int[] array = {-4, -6, 89, 6};
// int sum = Task(array);
// Console.WriteLine(sum);

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным 
// и минимальным элементов массива.

// [3 7 22 2 78] -> 76

// double Task(double[] array)
// {
//     double max = array[0];
//     double min = array[0];
//     for(int i = 0; i < array.Length; i++)
//     {
//         if( max < array[i]) max = array[i];
//         if( min > array[i]) min = array[i];

//     }
//     double sum = max - min;
//     return sum;
// }

// double[] array = {3, 7, 22, 2, 78};
// double sum = Task(array);
// Console.WriteLine(sum);