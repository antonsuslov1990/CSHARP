// Напишите программу, которая принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());
while (number < 9999 || number > 99999)
 {
	Console.Write("Вы вводите не пятизначное число,\nповторите попытку снова: ");
	number = int.Parse(Console.ReadLine());
 }
 string palindrome = number.ToString();

 if (palindrome[0] == palindrome[4] && palindrome[1] == palindrome[3] )
{
	Console.WriteLine($"Данное число {palindrome} явлется палиндромом! ");
}
 else
 {
	Console.WriteLine($"Данное число {palindrome} неявлется палиндромом! ");
 }