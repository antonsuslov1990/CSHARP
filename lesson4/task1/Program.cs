

// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Нельзя использовать функцию Math.Pow


Console.Clear();
Console.Write("Введите 1-ое число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите степень в которую нужно возвести число {number} : ");
int degree = Convert.ToInt32(Console.ReadLine());

int numberDeg = 1;

	for (int i = 1; i <= degree; i++)
	{
		numberDeg = numberDeg * number;
	}
	
Console.WriteLine(numberDeg);