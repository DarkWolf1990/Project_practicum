﻿// Задача 41. Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine(" Введите целые числа через пробел -> ");
int[] num = Console.ReadLine().Split().Select(int.Parse).ToArray();
int count = 0;

for (int i = 0; i < num.Length; i++)
	if (num[i] > 0) count += 1;

Console.WriteLine($"количество чисел  {count}");
Console.ReadKey();


