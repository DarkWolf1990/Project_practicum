/* Напишите программу, которая 
 на выход принимает два числа
 и выдаёт, какое число большее,
 а какое меньшее. */

Console.WriteLine(" введите целое число a:");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine(" введите целое число b:");
int num2 = int.Parse(Console.ReadLine());
int max = num1;
if (num1 > num2);
int min = num2;
if (num2 < num1);
Console.WriteLine("Максимальное число");
Console.WriteLine(max);
Console.WriteLine("Минимальное число");
Console.WriteLine(min);
Console.ReadKey();
