﻿// Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(number % 2==0);

if(number % 2==0)

    Console.WriteLine($"{number} четное число");
else
{
    Console.Write($"{number} нечетное число");
    Console.WriteLine(number);
    }