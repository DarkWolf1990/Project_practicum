﻿/*
Задача 25: Напишите цикл, который принимает на вход
два числа (A и B) и возводит число A в натуральную
степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

Console.WriteLine("введите число A ->");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("введите число B ->");
int stepen = int.Parse(Console.ReadLine());;
Console.WriteLine("n^stepen = " + Math.Pow(n, stepen));



