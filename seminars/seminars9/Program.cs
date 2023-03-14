// Задача 1: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

// void ShowNumbers(int n)
// {
//     if (n >1)
//     ShowNumbers(n - 1);
//     Console.Write(n + " ");
// }
// Console.WriteLine("Input N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// ShowNumbers(n);


// Задача 2. Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
//453 ->12

// int FindSum(int num)
// {
//     if (num > 0)
//         return FindSum(num / 10) + num % 10;
//     else
//         return num;
// }
// Console.WriteLine(FindSum(453));



// Задача 3. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 5, 6, 7, 8"

// void NaturalToLow(int m, int n)
// {
//     Console.Write(m + " ");
//     if (m < n)
//     NaturalToLow(m + 1, n);
// }
// Console.Write("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// NaturalToLow(m, n);


// Задача 4. Напишите программу, которая на вход принимает два числа A и B, и возводит число A в целую степень B с помощью рекурсии.
// А = 3; В = 5. -> 243
// А = 2; В = 3. -> 8

// int PowerAB(int a, int b)
// {
//     if (b < 0) return (1 / a) * PowerAB(a, b + 1); 
//     if (b > 0) return a * PowerAB(a, b - 1);
//     else return 1;
// }

// Console.Write("Input A:  ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input B:  ");
// int b = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"A в целой степени B :  {PowerAB(a, b)}");;