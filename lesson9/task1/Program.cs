// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.


// вызов функции "сумма чисел от N до M"
void SumNumber(int n, int m)
{
    Console.Write($"Сумму натуральных чисел в промежутки от {n} до {m} равна = {Sum(n - 1, m)}");
}

// функция сумма чисел от N до M
int Sum(int n, int m)
{
    int res = n;
    if (n == m)
        return 0;
    else
    {
        n++;
        res = n + Sum(n, m);
        return res;
    }
}

Console.Clear();
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
SumNumber(n, m);