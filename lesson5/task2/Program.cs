// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.Clear();
int amountNumber = new Random().Next(5, 10);
int[] array = new int[amountNumber];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 10);
Console.WriteLine($"[{string.Join(", ", array)}]");

int sumNumberUneven = 0;
for (int i = 1; i < array.Length; i += 2)
{
	sumNumberUneven =  sumNumberUneven + (array[i]);
}
Console.WriteLine(sumNumberUneven);