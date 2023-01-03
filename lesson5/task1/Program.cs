// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Clear();
int amountNumber = new Random().Next(10, 20);
int[] array = new int[amountNumber];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(100, 1000);
Console.WriteLine($"[{string.Join(", ", array)}]");

int numberEven = 0;
for (int j = 0; j < array.Length; j++)
{
	if (array[j] % 2 != 0);

	else
	numberEven++;
}

Console.WriteLine($"В этом массиве {numberEven} четных чисел.");