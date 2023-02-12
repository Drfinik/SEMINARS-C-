/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3

Console.WriteLine("Input a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input b: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.WriteLine("max = " + a);
    Console.WriteLine("min = " + b);

}
else
{
    Console.WriteLine("max = " + b);
    Console.WriteLine("min = " + a);

}*/

/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22

Console.WriteLine("Input a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input c: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (a > b)
{
    max = a;

}
else
{
    max = b;
    if (b < c)
    {
        max = c;
    }
}
Console.WriteLine("max = " + max); */


/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет

Console.WriteLine("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0)
{
    Console.WriteLine("Число " + number + " является четным");

}
else
{
    Console.WriteLine("Число " + number + " является нечетным");
}
*/

/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8


Console.WriteLine("Input number N: ");
int N = Convert.ToInt32(Console.ReadLine());
int result = 2;
while (result <= N)
{
    Console.WriteLine(result);
    result = result + 2;

}*/