﻿Console.WriteLine("Введите число 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1>num2) 
{
Console.WriteLine($"Первое число {num1} большее, второе число {num2} меньшее");
}
else 
{
Console.WriteLine($"Первое число {num1} меньшее, второе число {num2} большее");
}
