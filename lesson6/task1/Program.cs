// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.


Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
Console.WriteLine("Введите массив чисел: ");
	for (int i = 0; i < n; i++)
	{
	array[i] = Convert.ToInt32(Console.ReadLine());
	}

int sumPositiveNumber = 0;

for (int i = 0; i < n; i++)
{
	if (array[i] > 0)
		sumPositiveNumber++;

}

Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine($"Положительных числе в данном массиве: {sumPositiveNumber}");