﻿// Задача 2:
// Напишите программу, которая
// на вход принимает два числа
// и выдаёт, какое число большее, а какое меньшее.
// a =  5; b =  7 –> max =  7
// a =  2; b = 10 –> max = 10
// a = -9; b = -3 –> max = -3

Console.WriteLine("Введите первое целое число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число:");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine($"Первое число {number1} большее, а второе {number2} меньшее.");
}
else if (number2 > number1)
{
    Console.WriteLine($"Второе число {number2} большее, а первое {number1} меньшее.");
}
else
{
    Console.WriteLine("Числа равны.");
}