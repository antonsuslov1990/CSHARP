// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 99);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);

Console.Write("Введите строку элемента: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите столбец элемента: ");
int column = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

    if (row < 0 || row > matrix.GetLength(0) || column < 0 || column > matrix.GetLength(1))
{
Console.WriteLine("Такого элемент не существует!!!");
}
    else
{
    Console.WriteLine("Значение элемента массива = {0}", matrix[row-1, column-1]);
}