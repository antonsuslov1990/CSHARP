// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

void InputMatrix(double[,] matrix)
{
	for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
            Console.Write($"{matrix[i, j]} \t"); 
				// t - порядок чисел в матрице становится, друг под другом числа нахоядтся. 
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
double[,] matrix = new double[size[0], size[1]];
InputMatrix(matrix);