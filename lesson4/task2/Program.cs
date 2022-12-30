// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


Console.Clear();
Console.Write("Введите любое число: ");
int number = Convert.ToInt32(Console.ReadLine());

string? numberStr = number.ToString();
int sumNumber = 0;

for (int i = 0; i < numberStr.Length; i++)
{
	sumNumber = sumNumber + Convert.ToInt32(numberStr[i].ToString());
}

Console.WriteLine(sumNumber);