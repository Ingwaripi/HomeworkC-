﻿// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число от 1 до N: ");
int num1 = Convert.ToInt32(Console.ReadLine());

for( int i = 2; i <= num1; i = i +2)
Console.Write($"{i} ");