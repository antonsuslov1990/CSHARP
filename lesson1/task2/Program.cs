int numberA = new Random().Next (1, 100);
Console.WriteLine(numberA);
int numberB = new Random().Next (1, 100);
Console.WriteLine(numberB);
int numberC = new Random().Next (1, 100);
Console.WriteLine(numberC);
if (numberA > numberB && numberA > numberC){
	Console.WriteLine($"Это число самое большое из всех чисел: {numberA}");
}
else if (numberB > numberA && numberB > numberC){
	Console.WriteLine($"Это число самое большое из всех чисел: {numberB}");
}
else if (numberC > numberA && numberC > numberB){
	Console.WriteLine($"Это число самое большое из всех чисел: {numberC}");
}