﻿// Написать программу,которая на вход принимает число и выдаёт является ли число чётным
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num%2 == 0)
{
    Console.WriteLine($"Число {num} чётное");
}
else 
{
    Console.WriteLine($"Число {num} нечётное");
}