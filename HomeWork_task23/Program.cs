﻿/*
Задача 23: Напишите программу, которая принимает на
вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 4, 9.
5 -> 1, 8, 27, 64, 125
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.WriteLine("введите число :");
int n = int.Parse(Console.ReadLine());
int stepen = 3;
Console.WriteLine("n^3 = " + Math.Pow(n, stepen));

