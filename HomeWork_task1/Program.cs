/* Напишите программу, которая 
 на выход принимает два числа
 и выдаёт, какое число большее,
 а какое меньшее.   */

Console.WriteLine("введите целое число a:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите целое число b:");
int num2 = Convert.ToInt32(Console.ReadLine());
int max = num1;
int min = num2;
if (num1 > num2) { min = num2; max = num1; }
{

Console.WriteLine("Максимальное число");
Console.WriteLine(max);
    
    if (num2 < num1) { max = num1; }
    { 
    
Console.WriteLine("Минимальное число");
Console.WriteLine(min);


    }
Console.ReadKey();
    }