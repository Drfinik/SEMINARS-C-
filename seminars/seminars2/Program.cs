/*Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

78 -> 8

12-> 2

85 -> 8

void MaxDecimal(int num)
{
    int ed = num % 10;
    int dec = num / 10;
    if (ed > dec)
    {
        Console.WriteLine($"Большая цифра{num} -> {ed}");

    }
    else
    {
        Console.WriteLine($"Большая цифра{num} -> {dec}");

    }

}


int num = new Random().Next(10, 99 + 1);

MaxDecimal(num);*/


/*Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

456 -> 46

782 -> 72

918 -> 98

int DeleteDecimal(int num)
{
    int sot = num / 100;
    Console.WriteLine(sot);
    int ed = num % 10;
    Console.WriteLine(ed);
    return sot * 10 + ed;

}

int randomnumber = new Random().Next(100, 999 + 1);
Console.WriteLine(randomnumber);
//int result = DeleteDecimal(randomnumber);
//Console.WriteLine(result);
Console.WriteLine(DeleteDecimal(randomnumber));*/


/*Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

14  ->  нет
46  ->  нет
161 ->  да

void Krat2(int num)
{
    if (num % 7 == 0 && num % 23 == 0)
    {
        Console.WriteLine($"Число {num} кратно одновременно 7 и 23");

    }
    else
    {
        Console.WriteLine($"Число {num} не кратно одновременно 7 и 23");
    }
}
int num = Convert.ToInt32(Console.ReadLine());

Krat2(num);*/


/*Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если второе число не кратно числу первому, то программа выводит остаток от деления.

34, 5 -> не кратно, остаток 4
16, 4  -> кратно


void Krat2(int num, int num2)
{
    if (num % num2 == 0)
    {
        Console.WriteLine($"Число {num} кратно ");

    }
    else
    {
        int ostatok = num % num2;

        Console.WriteLine($"Число {num} не кратно остаток {ostatok}");
    }
}
int num = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
Krat2(num, num2);*/



