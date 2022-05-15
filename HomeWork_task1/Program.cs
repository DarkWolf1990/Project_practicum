// Напишите программу, которая 
// на выход принимает два числа
// и выдаёт, какое число большее,
// а какое меньшее.

Console.WriteLine("Ввидите целое число а:");
int num1 = int.Parse(Console.ReadLine());
Console.Write("введите число b" +" ");
int num2 = int.Parse(Console.ReadLine());
bool Intresult = num1 > num2;
 
 if (Intresult)
{
  Console.Write("Первое число больше"+" ");
  Console.Write("Второе число меньше"+" ");
}
else
{
  Console.Write("Второе число больше"+" ");
  Console.Write("Первое число меньше"+" ");
}
