// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


Random RandomArray = new Random();
int[,] matrix = new int[RandomArray.Next(3, 9), RandomArray.Next(3, 9)];
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			matrix[i, j] = RandomArray.Next(1, 99);
			Console.Write($"{matrix[i, j]} \t");
		}
		Console.WriteLine();
	}

Console.WriteLine($"Всего столбцов: {matrix.GetLength(1)}");
	for (int j = 0; j < matrix.GetLength(1); j++)
	{
		double sum = 0;
		for (int i = 0; i < matrix.GetLength(0); i++)
		{
			sum = sum + matrix[i, j];
		}
		Console.Write($"[{ Math.Round(sum / matrix.GetLength(0),2)}]");
	}
