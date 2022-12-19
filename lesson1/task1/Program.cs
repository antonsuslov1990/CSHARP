
Console.Write("Введите любое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе любое число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA > numberB) {
	Console.WriteLine($"Результат: {numberA} больше, чем число {numberB}");
}
else {
	Console.WriteLine($"Результат: {numberB} больше, чем число {numberA}");
}
