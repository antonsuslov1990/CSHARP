// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.


Console.Write("Введите любое число: ");
int n = int.Parse(Console.ReadLine());
int i = 1;
double sum = 0;
for ( i = 1; i <= n; i++)
	Console.WriteLine(sum = Math.Pow(i, 3));