
Console.Write("Введите любое число: ");
int n = int.Parse(Console.ReadLine());
if (n % 2 == 0)
{
	Console.WriteLine($"Это число является четным: {n}");
} 
else
{
	Console.WriteLine($"Число {n} является нечетным!/ Загадайте другое.");
}


