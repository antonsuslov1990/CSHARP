// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.Clear();
int amountNumber = new Random().Next(5, 10);
int[] array = new int[amountNumber];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(9, 100);
Console.WriteLine($"[{string.Join(", ", array)}]");

int numMax = 0;
int numMin = array[0];

for (int i = 0; i < array.Length; i++)
{
	if (array[i] > numMax)
		numMax = array[i];

	else if (array[i] > numMin);

	else
		numMin = array[i];
}

int diffNum = numMax - numMin;

Console.WriteLine($"Максимальное число в данном массиве {numMax}");
Console.WriteLine($"Минимальное число в данном массиве {numMin}");
Console.WriteLine($"Разница между числами {numMax} и {numMin} = {diffNum}");