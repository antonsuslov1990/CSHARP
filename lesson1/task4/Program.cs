Console.Write("Введите любое число: ");
int n = Convert.ToInt32(Console.ReadLine());
int m = 1;
int i = 2;
for ( i = m; i <= n; i++)
 if ( i % 2 == 0) {
	Console.WriteLine(i);
 }
Console.WriteLine($"Это все четные числа из указанного числа: {n}");