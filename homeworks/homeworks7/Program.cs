/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

void Create2DRandomArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().NextDouble();
//         }
//     }

// }

// void Show2DArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// double[,] numbers = new double[rows, columns];

// Create2DRandomArray(numbers);
// Show2DArray(numbers);


/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет. Во вводе первая цифра - номер строки, вторая - столбца. Цифры не больше 9.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет  */

void Create2DRandomArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(-9, 9);
//         }
//     }
// }

// void Show2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// int[,] numbers = new int[rows, columns];
// Console.WriteLine("Input number of idRows: ");
// int idRows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of idColumns: ");
// int idColumns = Convert.ToInt32(Console.ReadLine());

// Create2DRandomArray(numbers);
// Show2DArray(numbers);

// if ((idRows < rows)&(idColumns < columns))
// {
//     Console.WriteLine(numbers[idRows, idColumns]);
// }
// else
// {
//     Console.WriteLine("Такого числа в массиве нет");
// }


/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4       Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.   */

Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// int[,] numbers = new int[rows, columns];

// double sum = 0;
// double result = 0;

// for (int j = 0; j < numbers.GetLength(1); j++)
// {
//     for (int i = 0; i < numbers.GetLength(1); i++)
//     {
//         sum += numbers[i, j];
//     }
// result = sum / numbers.GetLength(1);
// result = Math.Round(result, 2);
// Console.Write(result + "; ");
// result = 0;
// sum = 0;
// }
// Create2DRandomArray(numbers);
// Show2DArray(numbers);

// void Create2DRandomArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0, 9);
//         }
//     }
    
// }

// void Show2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
