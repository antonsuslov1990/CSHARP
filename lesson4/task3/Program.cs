// Задача 29: Напишите программу, которая спрашивает у пользователя кол-во элементов и спршивает сами элементы. После записи элементов в массив, необходимо его вывести на экран.


Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
Console.Write("Введите массив чисел: ");
	for (int i = 0; i < n; i++)
	{
	array[i] = Convert.ToInt32(Console.ReadLine());
	}
Console.WriteLine($"[{string.Join(", ", array)}]");