/* Console.Clear();
int numberA = new Random().Next(100, 999);
string n = numberA.ToString();
Console.WriteLine(numberA);
Console.WriteLine(n[1]); */	



// Задача 10: Напишите программу, которая принимает на вход трёхзначное
// число и на выходе показывает вторую цифру этого числа.

Console.Clear();
int numberA = new Random().Next(100, 999);
Console.WriteLine(numberA);

numberA = numberA / 10;
numberA = numberA % 10;

Console.WriteLine(numberA);