﻿/* Напишите программу, которая выводит случайное
трёхзначное число и удаляет вторую цифру этого
числа.
456 -> 46
782 -> 72
918 -> 98
*/

int number = new Random().Next(100, 1000);
int last = number % 10;
int first = number / 100;
int res = first * 10 + last;

Console.WriteLine($"случайное число = {number}");
Console.WriteLine($"результат = {res}");

