// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// int[,] create2DRandomArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] new2DArray = new int[rows,columns];
//     for(int i = 0; i < rows; i++)
//     {
//         for( int j = 0; j < columns; j++)
//         {
//             new2DArray[i,j] =  new Random().Next(minValue, maxValue);
//         }
//     }
//     return new2DArray;
// }

// void print2DRandomArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for( int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i,j]} ");
//         }
//         Console.WriteLine("");

//     }
// }    

// void SelectionSort (int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for ( int j = 0; j < array.GetLength(1)-1; j++)
//         {
//             int MinPostition = j;
//             for ( int z = j +1; z < array.GetLength(1); z++)  
//             {
//                 if (array[i, z] > array[i, MinPostition]) MinPostition = z;
//             }
//             int temp = array[i,j];
//             array[i, j] = array[i, MinPostition];
//             array[i, MinPostition] = temp;
//         }
//     }
// }


// Console.WriteLine("Input please number of rows");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input please number of columns");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input please minValue of the array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input please maxValue of the array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());


// int[,] myArray = create2DRandomArray(rows, columns, minValue, maxValue);
// print2DRandomArray(myArray);
// SelectionSort(myArray);
// Console.WriteLine("");
// print2DRandomArray(myArray);

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int[,] create2DRandomArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] new2DArray = new int[rows,columns];
//     for(int i = 0; i < rows; i++)
//     {
//         for( int j = 0; j < columns; j++)
//         {
//             new2DArray[i,j] =  new Random().Next(minValue, maxValue);
//         }
//     }
//     return new2DArray;
// }

// void print2DRandomArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for( int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i,j]} ");
//         }
//         Console.WriteLine("");

//     }
// }    

// int SumOfRowInArray (int[,] array, int row)
// {
//     int sumOfRow = 0;
//     for(int j = 0; j < array.GetLength(1); j++)
//     {
//         sumOfRow += array[row,j];
//     }
//     return sumOfRow;
// }

// void MinimumSumOfRowInArray (int[,] array)
// {
//     int minRow = 0;
//     int minimumSumInRow = SumOfRowInArray(array, 0);
//     for(int i = 1; i <array.GetLength(0); i++)
//     {
//         int sum = SumOfRowInArray(array, i);
//         if (sum <minimumSumInRow)
//         {
//             minimumSumInRow = sum;
//             minRow = i;
//         }
//     }
//     Console.WriteLine($"Строка с индексом {minRow} имеет минимальную сумму элементов в строке: {minimumSumInRow}");
// }

// Console.WriteLine("Input please number of rows");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input please number of columns");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input please minValue of the array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input please maxValue of the array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());


// int[,] myArray = create2DRandomArray(rows, columns, minValue, maxValue);

// Console.WriteLine("");
// print2DRandomArray(myArray);
// Console.WriteLine("");
// MinimumSumOfRowInArray(myArray);

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int[,] create2DRandomArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] new2DArray = new int[rows,columns];
//     for(int i = 0; i < rows; i++)
//     {
//         for( int j = 0; j < columns; j++)
//         {
//             new2DArray[i,j] =  new Random().Next(minValue, maxValue);
//         }
//     }
//     return new2DArray;
// }

// void print2DRandomArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for( int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i,j]} ");
//         }
//         Console.WriteLine("");

//     }
// }    

// int[] MembersOfRow (int[,] array, int row)
// {
//     int[] membersOfRow = new int[array.GetLength(1)];
//     for(int j = 0; j < array.GetLength(1); j++)
//     {
//         membersOfRow[j] = array[row,j];
//     }
//     return membersOfRow;
// }

// int[] MembersOfColumn (int[,] array, int column)
// {
//     int[] membersOfColumn = new int[array.GetLength(0)];
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         membersOfColumn[i] = array[i,column];
//     }
//     return membersOfColumn;
// }

// int SumOfMultiplyingArray (int[] array, int[] array2)
// {
//     int sum = 0;
//     for (int i = 0; i < array.GetLength(0);i++)
//     {
//         sum += array[i]*array2[i];
//     }
//     return sum;
// }

// void PrintMembers(int[] array)
// {
//     Console.Write($"Members : ");
//     for( int i = 0; i < array.Length-1; i++)
//     {
//         Console.Write($"{array[i]}; ");
//     }
//     Console.Write($"{array[array.Length-1]}.");
//     Console.WriteLine("");
// }


// bool CheckIfMayMyltiplyed (int[,] array, int[,] array2)
// {
//     return (array.GetLength(1) == array2.GetLength(0));
// }



// int[,] MultiplyiedArray (int[,] array, int[,] array2)
// {
//     if (CheckIfMayMyltiplyed(array, array2))
//     {
//         int[,] result = new int[array.GetLength(0), array2.GetLength(1)];
//         for(int i = 0; i < result.GetLength(0); i++)
//         {
//             for( int j = 0; j < result.GetLength(1); j++)
//             {
//                 result[i,j] = SumOfMultiplyingArray(MembersOfRow(array, i), MembersOfColumn(array2,j));
//             }}
//         return result;
//     }
//     else
//     Console.WriteLine("Not possible to multuply");
//     return array;
// }

// Console.WriteLine("Input please number of rows for first matrix");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input please number of columns for first matrix");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input please number of rows for second matrix");
// int rows2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input please number of columns for second matrix");
// int columns2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input please minValue of the array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input please maxValue of the array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());


// int[,] myArray1 = create2DRandomArray(rows, columns, minValue, maxValue);
// int[,] myArray2 = create2DRandomArray(rows2, columns2, minValue, maxValue);

// Console.WriteLine("");
// print2DRandomArray(myArray1);
// Console.WriteLine("");
// print2DRandomArray(myArray2);
// Console.WriteLine("");

// int[,] multiArray = MultiplyiedArray(myArray1, myArray2);
// print2DRandomArray(multiArray);
// Console.WriteLine("");

//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// int RandomNumber (int min, int max)
// {
//     int randomNumber = new Random().Next(min, max);
//     return randomNumber;
// }

// int[,,] create3DRandomArray(int rows, int columns, int levels)
// {
//     int[,,] new3DArray = new int[rows, columns, levels];
//     for(int i = 0; i < rows; i++)
//     {
//         for( int j = 0; j < columns; j++)
//         {
//             for( int k = 0; k < levels; k++)
//             {
//                 new3DArray[i,j,k] =  RandomNumber(10, 99);
//             }
//         }
//     }
//     return new3DArray;
// }

// int[] ConvertMatixToArray(int[,,] array)
// {
//     int[] simpleArray = new int[array.GetLength(0)*array.GetLength(1)*array.GetLength(2)];
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for( int j = 0; j < array.GetLength(1); j++)
//         {
//             for( int k = 0; k < array.GetLength(2); k++)
//             {
//                 simpleArray[i*array.GetLength(1)*array.GetLength(2)+j*array.GetLength(2)+k] = array[i,j,k];
//             }
//         }
//     }
//     return simpleArray;
// }


// void PrintMembers(int[] array) 
// {
//     Console.Write($"Members : ");
//     for( int i = 0; i < array.Length-1; i++)
//     {
//         Console.Write($"{array[i]}; ");
//     }
//     Console.Write($"{array[array.Length-1]}.");
//     Console.WriteLine("");
// }
// bool CheckMatch(int[] array, int n)
// {
//     bool check = false;
//     int index = 0;
//     for( int i = 0; i < array.Length; i++)
//     {
//         if( array[i] == n)
//         {
//             index += 1;
//         }
//     }
//     if(index >0)
//     {
//     check = true;
//     }
//     return check;
// }

// int[,,] Unique3DRandomArray(int[,,] array)
// {
//     int[,,] new3DArray = array;
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for( int j = 0; j < array.GetLength(1); j++)
//         {
//             for( int k = 0; k < array.GetLength(2); k++)
//             {
//                 while(CheckMatch(ConvertMatixToArray(new3DArray),new3DArray[i,j,k]) is false)
//                 {
//                 new3DArray[i,j,k] =  RandomNumber(10, 99);
//                 }
//             }
//         }
//     }
//     return new3DArray;
// }


// void print2DRandomArray(int[,,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for( int j = 0; j < array.GetLength(1); j++)
//         {
//             for( int k = 0; k < array.GetLength(2); k++)
//             {
//             Console.Write($"{array[i,j,k]} ({i},{j},{k})");
//             }
//             Console.WriteLine("");
//         }
//     }
// }    

//  int rows, int columns,
// Console.WriteLine("Input please number of levels");
// int levels = Convert.ToInt32(Console.ReadLine());

// int[,,] my3DArray = create3DRandomArray(rows, columns, levels);

// int[,,] unique3DArray = Unique3DRandomArray(my3DArray);

// print2DRandomArray(unique3DArray);
// PrintMembers(ConvertMatixToArray(unique3DArray));


//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// void FillArraySpiral(int[,] array, int n)
// {
//     int i = 0, j = 0;
//     int value = 1;
//     for (int e = 0; e < n * n; e++)
//     {
//         int k = 0;
//         do { array[i, j++] = value++; } while (++k < n - 1);
//         for (k = 0; k < n - 1; k++) array[i++, j] = value++;
//         for (k = 0; k < n - 1; k++) array[i, j--] = value++;
//         for (k = 0; k < n - 1; k++) array[i--, j] = value++;
//         ++i; ++j;
//         n = n < 2 ? 0 : n - 2;
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] < 10)
//             {
//                 Console.Write("0" + array[i, j]);
//                 Console.Write(" ");
//             }
//             else Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.WriteLine("Input please size of array");
// int size = Convert.ToInt32(Console.ReadLine());
// int[,] table = new int[size, size];
// FillArraySpiral(table, size);
// PrintArray(table);


