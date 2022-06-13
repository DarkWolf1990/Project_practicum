// Задача 47: Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();
Console.Write("Введите число m ->  ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число n ->  ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine($"m = {m}, n = {n}");

double[,] GetArray = new double[m, n];
Random rnd = new Random();
MakeArrDouble(GetArray);

Console.WriteLine();

void MakeArrDouble(double[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			array[i, j] = rnd.Next(1, 5) + rnd.NextDouble() * 20 / 2147483648 - 10.0;
			Console.Write(String.Format("{0,5:f1}", array[i, j]));
		}
	}
	void PrintArray(double[,] array)
	{
		for (int i = 0; i < array.GetLength(0); i++)
		{
			for (int j = 0; j < array.GetLength(1); j++)
			{
				Console.Write($"{array[i, j]} ");
			}
			Console.WriteLine();

		}
	}
	void WriteArray (double[,] array){
for (int i = 0; i < m; i++)
  {
      for (int j = 0; j < n; j++)
      {
        double alignNumber = Math.Round(array[i, j], 1);
        Console.Write(alignNumber + " ");
      }
      Console.WriteLine();
	}
	PrintArray(GetArray);
	WriteArray(array);
}
}




