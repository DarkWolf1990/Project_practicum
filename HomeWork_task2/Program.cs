/*
Напишите программу, которая принимает 
 на вход три числа и выдаёт максимальное из этих чисел.
 */


Console.WriteLine(" введите целое число a:");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine(" введите целое число b:");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine("введите число c");
int num3 = int.Parse(Console.ReadLine());
int[] array = {num1, num2, num3};
int count=0;
int max = num1;
while(count <3)
{
	count++;
}
if (num1 > num2 & num2 < num3) max = num1;
if (num1 < num2 & num2 > num3) max = num2;
if (num1 < num2 & num2 < num3) max = num3;
Console.WriteLine("Максимальное число");
Console.WriteLine(max);
Console.ReadKey();